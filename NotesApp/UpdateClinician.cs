using CustomMessageBox;
using System;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class UpdateClinician : Form
    {
        private XMessage x = new XMessage();
        private DA DA = new DA();
        private BO.Clinician clinician = new BO.Clinician();
        public UpdateClinician()
        {
            var loadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(ShowLoader));
            loadingThread.Start();
            InitializeComponent();
            updatedLabelTitle.Visible = false;
            saveBtn.Visible = Session.UserType == "SUPERADMIN" || Session.UserType == "ADMIN";
            CloseLoadingDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cliniciancodeTxt.Text))
            {
                x.warn("Clinician code is empty!");
                return;
            }

            try
            {
                clinician = DA.GetClinician(cliniciancodeTxt.Text, "WES");

                if (clinician != null)
                {
                    nameTxt.Text = clinician.name;
                    telTxt.Text = clinician.telNo;
                    faxTxt.Text = clinician.faxNo;
                    mobileTxt.Text = clinician.mobileNo;
                    pagerTxt.Text = clinician.pagerNo;
                    addrTxt1.Text = clinician.address1;
                    addrTxt2.Text = clinician.address2;
                    addrTxt3.Text = clinician.address3;
                    addrTxt4.Text = clinician.address4;

                    if (clinician.updatedOn != null)
                    {
                        updatedLabelTitle.Visible = true;
                        updatedByLabel.Text = string.IsNullOrEmpty(clinician.updatedBy) ? " - " : clinician.updatedBy;
                        updatedOnLabel.Text = clinician.updatedOn.ToString();
                    }

                    BO.CBBranches cbBranches = DA.CheckClinicianBranches(clinician.code);
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
                    x.warn("Clinician not found.", "NOT FOUND");
                    return;
                }

            }
            catch (Exception ex)
            {
                x.err(ex.Message, "Error - " + ex.GetType().Name);
            }
        }

        private void UpdateClinician_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clinician = new BO.Clinician();

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

            updatedLabelTitle.Visible = false;
            updatedByLabel.Text = "";
            updatedOnLabel.Text = "";
        }

        private void cliniciancodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cliniciancodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clinician.code))
            {
                x.warn("No Clinician selected.");
                return;
            }

            DialogResult dr = RJMessageBox.Show("Do you want to save your changes?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            clinician.name = nameTxt.Text;
            clinician.telNo = telTxt.Text;
            clinician.faxNo = faxTxt.Text;
            clinician.mobileNo = mobileTxt.Text;
            clinician.pagerNo = pagerTxt.Text;
            clinician.address1 = addrTxt1.Text;
            clinician.address2 = addrTxt2.Text;
            clinician.address3 = addrTxt3.Text;
            clinician.address4 = addrTxt4.Text;
            clinician.updatedBy = Session.UserID;

            try
            {
                if (wesCB.Checked) DA.UpdateClinician(clinician, "WES");
                if (diaCB.Checked) DA.UpdateClinician(clinician, "DIAMOND");
                if (llcCB.Checked) DA.UpdateClinician(clinician, "MACTAN");
                if (lilCB.Checked) DA.UpdateClinician(clinician, "LILOAN");
                if (tabCB.Checked) DA.UpdateClinician(clinician, "TABUNOK");
                if (nagaCB.Checked) DA.UpdateClinician(clinician, "NAGA");
                if (conCB.Checked) DA.UpdateClinician(clinician, "CONSO");

                x.scs("Clinician updated successfully");

                clearBtn.PerformClick();
            }
            catch (Exception ex)
            {
                x.err(ex.Message, "Error - " + ex.GetType().Name);
            }
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
