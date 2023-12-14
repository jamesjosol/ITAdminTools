using CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class UpdateSource : Form
    {
        private XMessage x = new XMessage();
        private DA DA = new DA();
        private BO.Source source = new BO.Source();
        private List<BO.DispatchMode> dispatchModes = new List<BO.DispatchMode>();
        private List<BO.CustMaster> custMasters = new List<BO.CustMaster>();
        private List<BO.Term> terms = null;

        public UpdateSource()
        {

            var loadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(ShowLoader));
            loadingThread.Start();
            InitializeComponent();
            loadData();
            updatedLabelTitle.Visible = false;
            CloseLoadingDialog();
        }

        private void UpdateSource_Load(object sender, EventArgs e)
        {

            dispatchModes = DA.GetDispatchModes();
            dispatchDrp.DataSource = dispatchModes.Select(a => a.desc).ToList();

            terms = DA.GetTerms();
            termsDrp.DataSource = terms.Select(a => a.code).ToList();

            billingLabel.Text = "";

        }

        private void loadData()
        {
            custMasters = new List<BO.CustMaster>();
            custMasters = DA.GetCustMasters();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourcecodeTxt.Text))
            {
                x.warn("Clinician code is empty!");
                return;
            }

            try
            {
                source = DA.GetSource(sourcecodeTxt.Text, "WES");

                if (source != null)
                {
                    descTxt.Text = source.desc;
                    phoneTxt.Text = source.telNo;
                    faxTxt.Text = source.faxNo;
                    emailAddTxt.Text = source.email;
                    contactTxt.Text = source.contact;
                    dispatchDrp.SelectedIndex = dispatchDrp.FindStringExact(dispatchModes.FirstOrDefault(a => a.code == source.dispatchMode).desc);
                    billingTxt.Text = source.billingCode;
                    billingLabel.Text = custMasters.FirstOrDefault(a => a.code == source.billingCode)?.name;
                    addrTxt1.Text = source.address1;
                    addrTxt2.Text = source.address2;
                    addrTxt3.Text = source.address3;
                    addrTxt4.Text = source.address4;
                    termsDrp.SelectedIndex = termsDrp.FindStringExact(custMasters.FirstOrDefault(a => a.code == source.billingCode).term);
                    billingFolderId.Text = custMasters.FirstOrDefault(a => a.code == source.billingCode).folder_id;

                    if (source.updatedOn != null)
                    {
                        updatedLabelTitle.Visible = true;
                        updatedByLabel.Text = string.IsNullOrEmpty(source.updatedBy) ? " - " : source.updatedBy;
                        updatedOnLabel.Text = source.updatedOn.ToString();
                    }

                    BO.CBBranches cbBranches = DA.CheckSourceBranches(source.code);
                    wesCB.Checked = cbBranches.wes;
                    diaCB.Checked = cbBranches.dia;
                    llcCB.Checked = cbBranches.llc;
                    lilCB.Checked = cbBranches.lil;
                    tabCB.Checked = cbBranches.tab;
                    nagaCB.Checked = cbBranches.naga;
                    conCB.Checked = cbBranches.con;

                    wesCB.Enabled = cbBranches.wes;
                    diaCB.Enabled = cbBranches.dia;
                    llcCB.Enabled = cbBranches.llc;
                    lilCB.Enabled = cbBranches.lil;
                    tabCB.Enabled = cbBranches.tab;
                    nagaCB.Enabled = cbBranches.naga;
                    conCB.Enabled = cbBranches.con;
                }
                else
                {
                    x.warn("Source not found.", "NOT FOUND");
                    return;
                }
            }
            catch (Exception ex)
            {
                x.err(ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private void billingTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            BillingModal billingModal = new BillingModal();
            billingModal.custMasters = custMasters;
            billingModal.ShowDialog(this);

            if (billingModal.selected != null)
            {
                billingTxt.Text = billingModal.selected.code;
                billingLabel.Text = billingModal.selected.name;
                billingFolderId.Text = billingModal.selected.folder_id;
                termsDrp.SelectedIndex = termsDrp.FindStringExact(custMasters.FirstOrDefault(a => a.code == billingModal.selected.code).term);
            }


            e.Handled = true;
        }

        private void sourcecodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(source.code) || source == null)
            {
                x.warn("No Source selected.");
                return;
            }

            DialogResult dr = RJMessageBox.Show("Do you want to save your changes?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            source.desc = descTxt.Text;
            source.telNo = phoneTxt.Text;
            source.faxNo = faxTxt.Text;
            source.email = emailAddTxt.Text;
            source.contact = contactTxt.Text;
            source.dispatchMode = dispatchModes.FirstOrDefault(a => a.desc == dispatchDrp.SelectedItem.ToString())?.code;
            source.billingCode = billingTxt.Text;
            source.term = termsDrp.SelectedItem.ToString();
            source.address1 = addrTxt1.Text;
            source.address2 = addrTxt2.Text;
            source.address3 = addrTxt3.Text;
            source.address4 = addrTxt4.Text;
            source.updatedBy = Session.UserID;

            try
            {
                if (wesCB.Checked) DA.UpdateSource(source, "WES");
                if (diaCB.Checked) DA.UpdateSource(source, "DIAMOND");
                if (llcCB.Checked) DA.UpdateSource(source, "MACTAN");
                if (lilCB.Checked) DA.UpdateSource(source, "LILOAN");
                if (tabCB.Checked) DA.UpdateSource(source, "TABUNOK");
                if (nagaCB.Checked) DA.UpdateSource(source, "NAGA");
                if (conCB.Checked) DA.UpdateSource(source, "CONSO");

                x.scs("Source updated successfully");

                clearBtn.PerformClick();
                loadData();
            }
            catch (Exception ex)
            {
                x.err(ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            source = new BO.Source();

            foreach (Control control in this.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuTextBox textBox)
                {
                    textBox.Text = null;
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuCheckBox checkBox)
                {
                    checkBox.Enabled = true;
                    checkBox.Checked = true;
                }
            }

            dispatchDrp.SelectedIndex = 0;
            termsDrp.SelectedIndex = 0;
            billingLabel.Text = "";
            updatedLabelTitle.Visible = false;
            updatedByLabel.Text = "";
            updatedOnLabel.Text = "";
        }

        private void descTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowLoader()
        {
            LoaderDialogSM loader = new LoaderDialogSM("Loading...");
            loader.ShowDialog();
            loader.ShowInTaskbar = false;
        }


        private void CloseLoadingDialog()
        {
            try
            {
                if (Application.OpenForms["LoaderDialogSM"] != null)
                {
                    Application.OpenForms["LoaderDialogSM"].Invoke(new Action(() =>
                    {
                        Application.OpenForms["LoaderDialogSM"].Close();
                    }));
                }
            }
            catch (Exception e) { }
        }
    }
}
