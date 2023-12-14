using CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class UpdateDebtor : Form
    {
        private DA DA = new DA();
        private XMessage x = new XMessage();
        private List<BO.Term> terms = null;
        private List<BO.DBGroup> dbgroups = null;
        private BO.Debtor debtor = new BO.Debtor();

        public UpdateDebtor()
        {
            var loadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(ShowLoader));
            loadingThread.Start();
            InitializeComponent();
            CloseLoadingDialog();
        }

        private void UpdateDebtor_Load(object sender, EventArgs e)
        {
            terms = DA.GetTerms();
            dbgroups = DA.GetDBGroup();
            termsDrp.DataSource = terms.Select(a => a.code).ToList();
            cusgrpDrp.DataSource = dbgroups.Select(a => a.code + " - " + a.name).ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codeTxt.Text))
            {
                x.warn("Debtor code is empty!");
                return;
            }

            try
            {
                debtor = DA.GetDebtor(codeTxt.Text, "WES");

                if (debtor != null)
                {
                    nameTxt.Text = debtor.name;
                    contactTxt.Text = debtor.contact;
                    phoneTxt.Text = debtor.phoneNo;
                    faxTxt.Text = debtor.faxNo;
                    addrTxt1.Text = debtor.address1;
                    addrTxt2.Text = debtor.address2;
                    addrTxt3.Text = debtor.address3;
                    addrTxt4.Text = debtor.address4;
                    cusgrpDrp.SelectedIndex = getCusDrpIndex(debtor.cusgroup);
                    termsDrp.SelectedIndex = termsDrp.FindStringExact(debtor.term);
                    credLimitTxt.Text = debtor.credlimit;
                    blcklistCB.Checked = debtor.blacklist;
                    datecreateTxt.Text = debtor.created.ToString();
                    switch (debtor.pricegroup)
                    {
                        case "1":
                            pg1RB.Checked = true;
                            pg2RB.Checked = false;
                            pg3RB.Checked = false;
                            break;
                        case "2":
                            pg1RB.Checked = false;
                            pg2RB.Checked = true;
                            pg3RB.Checked = false;
                            break;
                        case "3":
                            pg1RB.Checked = false;
                            pg2RB.Checked = false;
                            pg3RB.Checked = true;
                            break;
                    }
                    sprefTxt.Text = debtor.specialprice;
                    if (debtor.updatedOn != null)
                    {
                        updatedLabelTitle.Visible = true;
                        updatedByLabel.Text = string.IsNullOrEmpty(debtor.updatedBy) ? " - " : debtor.updatedBy;
                        updatedOnLabel.Text = debtor.updatedOn.ToString();
                    }


                    BO.CBBranches cbBranches = DA.CheckDebtorBranches(debtor.code);
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
                    x.warn("Debtor not found.", "NOT FOUND");
                    return;
                }
            }
            catch (Exception ex)
            {
                x.err(ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(debtor.code) || debtor == null)
            {
                x.warn("No Debtor selected.");
                return;
            }

            DialogResult dr = RJMessageBox.Show("Do you want to save your changes?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            debtor.name = nameTxt.Text;
            debtor.contact = contactTxt.Text;
            debtor.phoneNo = phoneTxt.Text;
            debtor.faxNo = faxTxt.Text;
            debtor.address1 = addrTxt1.Text;
            debtor.address2 = addrTxt2.Text;
            debtor.address3 = addrTxt3.Text;
            debtor.address4 = addrTxt4.Text;
            debtor.cusgroup = dbgroups.FirstOrDefault(a => a.code == cusgrpDrp.SelectedItem.ToString().Split('-')[0].Trim())?.code;
            debtor.term = termsDrp.SelectedItem.ToString();
            debtor.credlimit = credLimitTxt.Text;
            debtor.blacklist = blcklistCB.Checked;
            debtor.specialprice = sprefTxt.Text;
            debtor.updatedBy = Session.UserID;
            if (pg1RB.Checked) debtor.pricegroup = "1";
            else if (pg2RB.Checked) debtor.pricegroup = "2";
            else if (pg3RB.Checked) debtor.pricegroup = "3";

            try
            {
                if (wesCB.Checked) DA.UpdateDebtor(debtor, "WES");
                if (diaCB.Checked) DA.UpdateDebtor(debtor, "DIAMOND");
                if (llcCB.Checked) DA.UpdateDebtor(debtor, "MACTAN");
                if (lilCB.Checked) DA.UpdateDebtor(debtor, "LILOAN");
                if (tabCB.Checked) DA.UpdateDebtor(debtor, "TABUNOK");
                if (nagaCB.Checked) DA.UpdateDebtor(debtor, "NAGA");
                if (conCB.Checked) DA.UpdateDebtor(debtor, "CONSO");

                x.scs("Debtor updated successfully");

                clearBtn.PerformClick();
            }
            catch (Exception ex)
            {
                x.err(ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private int getCusDrpIndex(string code)
        {
            for (int i = 0; i < cusgrpDrp.Items.Count; i++)
            {
                string s = cusgrpDrp.GetItemText(cusgrpDrp.Items[i]);
                if (s.Split('-')[0].Trim() == code)
                    return i;
            }

            return -1;
        }

        private void codeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            debtor = new BO.Debtor();

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

            cusgrpDrp.SelectedIndex = 0;
            termsDrp.SelectedIndex = 0;
            blcklistCB.Checked = false;
            pg1RB.Checked = true;
            pg2RB.Checked = false;
            pg3RB.Checked = false;
            updatedLabelTitle.Visible = false;
            updatedByLabel.Text = "";
            updatedOnLabel.Text = "";
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
