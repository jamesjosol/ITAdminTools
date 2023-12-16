using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class UserManage : Form
    {
        private DA DA = new DA();
        private List<BO.User> users = new List<BO.User>();
        private BO.User selectedUser = null;
        private XMessage x = new XMessage();
        public UserManage()
        {
            var loadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(ShowLoader));
            loadingThread.Start();
            InitializeComponent();

            dataTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 31, 75);
            dataTable.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(32, 31, 75);
            dataTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 31, 75);
            dataTable.DefaultCellStyle.BackColor = Color.FromArgb(51, 46, 84);
            dataTable.DefaultCellStyle.ForeColor = Color.Gainsboro;
            dataTable.DefaultCellStyle.SelectionBackColor = Color.SlateBlue;
            dataTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(51, 46, 84);
            dataTable.CellDoubleClick += dataTable_CellContentDoubleClick;
            CloseLoadingDialog();
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

        private void loadDataTable()
        {
            users = DA.getAllUsers();

            var filtered = users.Select(a => new
            {
                UserId = a.UserID,
                UserType = a.UserType,
                UpdatedBy = a.UpdatedBy,
                UpdatedOn = a.UpdatedOn == DateTime.MinValue ? "" : a.UpdatedOn.ToString(),
                Active = a.Active
            }).ToList();

            dataTable.DataSource = filtered;
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void dataTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string selectedUserID = dataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                selectedUser = users.FirstOrDefault(a => a.UserID == selectedUserID);
                if (selectedUser != null)
                {
                    txtUserID.Text = selectedUser.UserID;
                    List<string> _l = new List<string> { "USER", "ADMIN", "SUPERADMIN" };
                    List<string> _a = new List<string> { "ACTIVE", "INACTIVE" };

                    if (txtUserID.Text == "JMJOSOL")
                    {
                        txtUserType.DataSource = new List<string> { "SUPERADMIN" };
                        txtStatus.DataSource = new List<string> { "ACTIVE" };
                        saveBtn.Visible = false;
                        clearBtn.Visible = false;
                    }
                    else
                    {
                        txtUserType.DataSource = _l;
                        txtStatus.DataSource = _a;
                        txtUserType.SelectedIndex = txtUserType.FindStringExact(selectedUser.UserType);
                        txtStatus.SelectedIndex = txtStatus.FindStringExact(selectedUser.Active ? "ACTIVE" : "INACTIVE");
                        saveBtn.Visible = true;
                        clearBtn.Visible = true;
                    }

                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            selectedUser = null;
            txtUserID.Text = null;
            txtUserType.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            selectedUser.UserType = txtUserType.SelectedItem.ToString();
            selectedUser.Active = txtStatus.SelectedIndex == 0;

            if (DA.UpdateUser(selectedUser))
            {
                x.scs("Changes have been saved successfully.");
                loadDataTable();
                clearBtn.PerformClick();
            }
            else
            {
                x.err("Oops, something went wrong while saving.");
            }
        }
    }
}
