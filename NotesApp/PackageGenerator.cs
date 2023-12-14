using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ed = System.IO;

namespace AdminTools
{
    public partial class PackageGenerator : Form
    {
        private DA DA = new DA();
        private XMessage x = new XMessage();
        public PackageGenerator()
        {
            InitializeComponent();
            branchCB.SelectedIndex = 0;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (fromDate.Value > toDate.Value)
            {
                x.err("From Date must not greater than To Date.", "Invalid");
                return;
            }

            try
            {
                string filePath = ed.Directory.GetCurrentDirectory().ToString() + "\\Report\\Report.xlsx";
                string filePathTEMP = ed.Directory.GetCurrentDirectory().ToString() + "\\Report\\Report_TEMP.xlsx";
                ed.File.Copy(filePath, filePathTEMP, true);
                ed.FileInfo file = new ed.FileInfo(filePathTEMP);

                using (var _wb = new XLWorkbook(filePath))
                {
                    string type = "P";
                    if (packageRadBtn.Checked)
                    {
                        type = "P";
                    }
                    else if (singleRadBtn.Checked)
                    {
                        type = "S";
                    }

                    List<BO.Package> packages = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(),
                        branchCB.SelectedItem.ToString(), type);

                    DataTable dt = DA.ConvertListToDataTable(packages);

                    var existingWorksheet = _wb.Worksheets.FirstOrDefault(ws => ws.Name.Contains("PACKAGES") || ws.Name.Contains("SINGLE TESTS"));
                    if (existingWorksheet != null)
                    {
                        _wb.Worksheets.Delete(existingWorksheet.Name);
                    }

                    var worksheet = _wb.Worksheets.Add(dt, (type == "P" ? "PACKAGES " : "SINGLE TESTS ") + "(" + branchCB.SelectedItem + ")");
                    worksheet.Column(1).Width = 20;
                    worksheet.Column(2).Width = 35;
                    worksheet.Column(3).Width = 15;
                    worksheet.Column(4).Width = 15;
                    worksheet.Column(5).Width = 15;
                    worksheet.Column(6).Width = 25;

                    _wb.Save();

                    System.Diagnostics.Process.Start(filePath);

                }

            }
            catch (Exception ex)
            {
                x.err(ex.Message.Contains("used by another process") ? ex.Message + "\nPlease close the excel file to generate again." : ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private void generatePackageComparative()
        {
            string type = "P";
            if (packageRadBtn.Checked)
            {
                type = "P";
            }
            else if (singleRadBtn.Checked)
            {
                type = "S";
            }
            List<BO.Package> wes = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "WES", type);
            List<BO.Package> dia = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "DIAMOND", type);
            List<BO.Package> lil = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "LILOAN", type);
            List<BO.Package> tab = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "TABUNOK", type);
            List<BO.Package> llc = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "MACTAN", type);
            List<BO.Package> naga = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "NAGA", type);
            List<BO.Package> con = DA.GenerateReport(fromDate.Value.ToShortDateString(), toDate.Value.AddDays(1).ToShortDateString(), "CONSO", type);
            PropertyInfo[] properties = typeof(BO.Package).GetProperties();

            try
            {
                string filePath = ed.Directory.GetCurrentDirectory().ToString() + "\\Report\\Summary.xlsx";
                string orgFilePath = ed.Directory.GetCurrentDirectory().ToString() + "\\Report\\Summary-BAK.xlsx";
                ed.File.Copy(orgFilePath, filePath, true);

                using (var _wb = new XLWorkbook(filePath))
                {
                    var worksheet = _wb.Worksheets.Worksheet(1);
                    for (int row = 3; row < wes.Count + 3; row++)
                    {
                        for (int col = 1; col < 24; col++)
                        {
                            if (col < 6)  // WES
                            {
                                BO.Package package = wes[row - 3];

                                PropertyInfo property = properties[col - 1];

                                object value = property.GetValue(package);

                                if (col == 1) worksheet.Cell(row, col).Style.NumberFormat.Format = "@";
                                worksheet.Cell(row, col).Value = value?.ToString();
                            }
                            else if (col < 9) // DIA
                            {
                                var _dia = dia.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_dia != null)
                                {

                                    BO.Package package = _dia;

                                    PropertyInfo property = properties[col - 4];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 4].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 12) // MACTAN
                            {
                                var _llc = llc.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_llc != null)
                                {

                                    BO.Package package = _llc;

                                    PropertyInfo property = properties[col - 7];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 7].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 15) // LILOAN
                            {
                                var _lil = lil.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_lil != null)
                                {

                                    BO.Package package = _lil;

                                    PropertyInfo property = properties[col - 10];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 10].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 18) // TABUNOK
                            {
                                var _tab = tab.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_tab != null)
                                {

                                    BO.Package package = _tab;

                                    PropertyInfo property = properties[col - 13];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 13].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 21) // NAGA
                            {
                                var _naga = naga.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_naga != null)
                                {

                                    BO.Package package = _naga;

                                    PropertyInfo property = properties[col - 16];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 16].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 24) // CONSO
                            {
                                var _con = con.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_con != null)
                                {

                                    BO.Package package = _con;

                                    PropertyInfo property = properties[col - 19];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 19].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                        }
                    }

                    _wb.Save();

                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                x.err(ex.Message.Contains("used  by another process") ? ex.Message + "\nPlease close the excel file to generate again." : ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            generatePackageComparative();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string type = "P";
            if (packageRadBtn.Checked)
            {
                type = "P";
            }
            else if (singleRadBtn.Checked)
            {
                type = "S";
            }

            try
            {
                List<BO.Package> wes = DA.GenerateReportStatus("WES", type);
                List<BO.Package> dia = DA.GenerateReportStatus("DIAMOND", type);
                List<BO.Package> lil = DA.GenerateReportStatus("LILOAN", type);
                List<BO.Package> tab = DA.GenerateReportStatus("TABUNOK", type);
                List<BO.Package> llc = DA.GenerateReportStatus("MACTAN", type);
                List<BO.Package> naga = DA.GenerateReportStatus("NAGA", type);
                List<BO.Package> con = DA.GenerateReportStatus("CONSO", type);
                PropertyInfo[] properties = typeof(BO.Package).GetProperties();


                string filePath = ed.Directory.GetCurrentDirectory().ToString() + "\\Report\\StatusReport.xlsx";
                string filePathTEMP = ed.Directory.GetCurrentDirectory().ToString() + "\\Report\\StatusReport-BAK.xlsx";
                ed.File.Copy(filePathTEMP, filePath, true);

                using (var _wb = new XLWorkbook(filePath))
                {
                    var worksheet = _wb.Worksheets.Worksheet(1);
                    for (int row = 3; row < wes.Count + 3; row++)
                    {
                        for (int col = 1; col < 10; col++)
                        {
                            if (col < 4)  // WES
                            {
                                BO.Package package = wes[row - 3];
                                PropertyInfo property;

                                if (col == 3) property = properties[col + 3];
                                else property = properties[col - 1];

                                object value = property.GetValue(package);

                                if (col == 1) worksheet.Cell(row, col).Style.NumberFormat.Format = "@";
                                worksheet.Cell(row, col).Value = value?.ToString();
                            }
                            else if (col < 5) // DIA
                            {
                                var _dia = dia.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_dia != null)
                                {

                                    BO.Package package = _dia;

                                    PropertyInfo property = properties[col + 2];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col + 2].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }

                            else if (col < 6) // MACTAN
                            {
                                var _llc = llc.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_llc != null)
                                {

                                    BO.Package package = _llc;

                                    PropertyInfo property = properties[col + 1];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col + 1].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 7) // LILOAN
                            {
                                var _lil = lil.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_lil != null)
                                {

                                    BO.Package package = _lil;

                                    PropertyInfo property = properties[col];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 8) // TABUNOK
                            {
                                var _tab = tab.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_tab != null)
                                {

                                    BO.Package package = _tab;

                                    PropertyInfo property = properties[col - 1];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 1].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 9) // NAGA
                            {
                                var _naga = naga.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_naga != null)
                                {

                                    BO.Package package = _naga;

                                    PropertyInfo property = properties[col - 2];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 2].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                            else if (col < 10) // CONSO
                            {
                                var _naga = naga.FirstOrDefault(a => a.code == wes[row - 3].code);

                                if (_naga != null)
                                {

                                    BO.Package package = _naga;

                                    PropertyInfo property = properties[col - 3];

                                    object value = property.GetValue(package);

                                    worksheet.Cell(row, col).Value = value?.ToString();

                                    if (value.ToString() != properties[col - 3].GetValue(wes[row - 3]).ToString())
                                    {
                                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.BlanchedAlmond;
                                        worksheet.Cell(row, col).Style.Font.SetFontColor(XLColor.GoldenBrown);
                                    }
                                }
                                else
                                {
                                    worksheet.Cell(row, col).Style.Fill.BackgroundColor = XLColor.Pink;
                                }
                            }
                        }
                    }
                    _wb.Save();

                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                x.err(ex.Message.Contains("used  by another process") ? ex.Message + "\nPlease close the excel file to generate again." : ex.Message, "Error - " + ex.GetType().Name);
            }
        }
    }
}
