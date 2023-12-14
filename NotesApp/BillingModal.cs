using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class BillingModal : Form
    {

        public List<BO.CustMaster> custMasters = null;
        public BO.CustMaster selected = null;

        public BillingModal()
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

            dataTable.CellDoubleClick += dataTable_CellContentDoubleClick;
        }

        private void BillingModal_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void tableLoad()
        {
            dataTable.DataSource = custMasters;
        }

        private void search()
        {
            if (!string.IsNullOrEmpty(sourcecodeTxt.Text))
            {
                var res = custMasters.Where(a => a.code.Contains(sourcecodeTxt.Text) || a.name.ToUpper().Contains(sourcecodeTxt.Text.ToUpper())).ToList();
                if (res != null)
                {
                    dataTable.DataSource = res;
                }
            }
            else
            {
                tableLoad();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sourcecodeTxt_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dataTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = custMasters.FirstOrDefault(a => a.code == dataTable.Rows[e.RowIndex].Cells["code"].Value);

            this.Close();
        }

        private void dataTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                selected = custMasters.FirstOrDefault(a => a.code == dataTable.SelectedRows[0].Cells["code"].Value);
                this.Close(); ;
                e.Handled = true;
            }
        }
    }
}
