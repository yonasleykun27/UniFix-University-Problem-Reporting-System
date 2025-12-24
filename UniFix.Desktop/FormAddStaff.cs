using System;
using System.Drawing;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormAddStaff : Form
    {
        private ApiClient _api = new ApiClient();

        public FormAddStaff()
        {
            InitializeComponent();

          
            try
            {
                this.BackColor = UIHelper.BgColor;
                lblTitle.ForeColor = UIHelper.AccentColor;
                UIHelper.StyleButton(btnSave, true);
                UIHelper.StyleButton(btnCancel, false);
            }
            catch { }

          
            cboJobTitle.Items.AddRange(new object[] {
                "Staff Dormitory Manager",
                "Staff Health Center Manager",
                "Staff Cafeteria Manager",
                "Staff Dean",
                "Staff Academic Resources Manager",
                "Staff Department Head",
                "Staff Human Resource Manager",
                "Staff University Administration Manager",
                "Staff ICT Manager",
                "Staff Campus Security Manager",
                "Staff General Technician"
            });
            cboJobTitle.SelectedIndex = 0;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtStaffId.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var newSolver = new User
            {
                FullName = txtName.Text,
                Username = txtUser.Text,
                Password = txtPass.Text,
                UserIdCard = txtStaffId.Text,
                Role = "Solver", 
                JobTitle = cboJobTitle.SelectedItem.ToString(),

              
                Department = null,
                Year = null,
                Block = null,
                Dorm = null,
                Warnings = 0,
                IsBanned = false
            };

            btnSave.Enabled = false;
            btnSave.Text = "Saving...";

            try
            {
                bool success = await _api.RegisterAsync(newSolver);
                if (success)
                {
                    MessageBox.Show($"Success!\n{newSolver.JobTitle} added.");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Failed. Username might already exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = "SAVE STAFF";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}