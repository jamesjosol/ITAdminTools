using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            this.dataTable.BackColor = Color.FromArgb(58, 52, 95);
            this.dataTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(77, 70, 130);
            this.dataTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(77, 70, 130);
            this.dataTable.RowsDefaultCellStyle.BackColor = Color.FromArgb(58, 52, 95);
            this.dataTable.RowsDefaultCellStyle.ForeColor = Color.Gainsboro;
            this.dataTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(58, 52, 95);
            this.dataTable.AlternatingRowsDefaultCellStyle.ForeColor = Color.Gainsboro;
            this.dataTable.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(85, 79, 136);

            //this.bunifuVScrollBar1.BorderRadius = 14;
            //Bunifu.Utils.DatagridView.BindDatagridViewScrollBar(dataTable, bunifuVScrollBar1);
            this.dataTable.MouseWheel += new MouseEventHandler(dataTable_MouseWheel);
            //dataTable.Controls.Add(bunifuVScrollBar1);
        }

        private void dataTable_MouseWheel(object sender, MouseEventArgs e)
        {
            int currentIndex = this.dataTable.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (e.Delta > 0)
            {
                this.dataTable.FirstDisplayedScrollingRowIndex
                    = Math.Max(0, currentIndex - scrollLines);
                //this.bunifuVScrollBar1.Value = Math.Max(0, currentIndex - scrollLines);
            }
            else if (e.Delta < 0)
            {
                this.dataTable.FirstDisplayedScrollingRowIndex
                    = currentIndex + scrollLines;

                //this.bunifuVScrollBar1.Value = currentIndex + scrollLines;
            }
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                dataTable.Rows.Add(
                    new object[]
                    {
                        Faker.NameFaker.Name(),
                        Faker.NameFaker.FirstName() + "@gmail.com",
                        Faker.PhoneFaker.InternationalPhone(),
                        Faker.CompanyFaker.BS(),
                        Faker.CompanyFaker.Name()
                    }
                );
            }
        }
    }
}
