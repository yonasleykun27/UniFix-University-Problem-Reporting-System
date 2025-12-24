using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks; 
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormTeacherDashboard : Form
    {
        private User _currentUser;
        private ApiClient _api = new ApiClient();
        private Report _selectedReport = null;

        public FormTeacherDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
            lblWelcome.Text = $"Welcome, Teacher {_currentUser.FullName}";


            UpdateWarningUI();

          
            try
            {
                this.BackColor = UIHelper.BgColor;

          
                lblWelcome.ForeColor = Color.White;
                lblWelcome.Font = new Font("Segoe UI", 16, FontStyle.Bold);

                UIHelper.StyleGrid(gridHistory);
                UIHelper.StyleButton(btnSubmit, true);
                UIHelper.StyleButton(btnRefresh, false);
                UIHelper.StyleButton(btnEdit, false);    
                UIHelper.StyleDangerButton(btnDelete);  
                UIHelper.StyleDangerButton(btnLogout);

                pnlDetails.ForeColor = UIHelper.PrimaryColor;
                pnlDetails.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                UIHelper.StyleTextBox(txtPhone);
                UIHelper.StyleTextBox(txtDesc);
                UIHelper.StyleTextBox(txtDet1);
                UIHelper.StyleTextBox(txtDet2);
            }
            catch {  }

            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] {
                "Teaching Materials",
                "Classroom Mgmt",
                "Work Environment",
                "Other"
            });

   
            cboCategory.SelectedIndex = 0;
            cboUrgency.SelectedIndex = 0;

        
            gridHistory.CellClick += GridHistory_CellClick;
        }

    
        private void UpdateWarningUI()
        {
            if (_currentUser.Warnings > 0)
            {
                lblWarnings.Text = $"⚠️ Warnings: {_currentUser.Warnings}/3";
                lblWarnings.Visible = true;
                lblWarnings.ForeColor = Color.Gold; 
            }
            else
            {
                lblWarnings.Visible = false;
            }
        }

      
        private async Task ReloadUserStatus()
        {
            try
            {
                
                var users = await _api.GetAllUsersAsync();
                var freshUser = users.FirstOrDefault(u => u.Username == _currentUser.Username);

                if (freshUser != null)
                {
                    _currentUser = freshUser; 

                  
                    if (_currentUser.IsBanned)
                    {
                        MessageBox.Show("Your account has been BANNED by Admin.\nLogging out...", "Access Revoked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        new FormLogin().Show();
                        this.Close();
                        return;
                    }

              
                    UpdateWarningUI();
                }
            }
            catch { }
        }

        private void GridHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _selectedReport = (Report)gridHistory.Rows[e.RowIndex].DataBoundItem;

         
            if (_selectedReport.Status == "Pending")
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnDelete.Text = "Cancel Report";
            }
            else if (_selectedReport.Status == "Finished")
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnDelete.Text = "Delete History";

                MessageBox.Show($"Report Finished!\n\nSolver Note: {_selectedReport.SpecificDetails}", "Job Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnDelete.Text = "Locked";

                if (_selectedReport.Status == "Declined")
                {
                    MessageBox.Show($"Admin Reason: {_selectedReport.DeclineReason}", "Report Declined", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("This report is currently being worked on by staff. You cannot edit or delete it.", "In Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = cboCategory.SelectedItem.ToString();

            if (cat == "Teaching Materials") SetupDetails("Material Name", "Quantity/Type");
            else if (cat == "Classroom Mgmt") SetupDetails("Room Number", "Asset/Issue");
            else if (cat == "Work Environment") SetupDetails("Office Number", "Issue Type");
            else
            {
                pnlDetails.Visible = false;
            }
        }

        private void SetupDetails(string label1, string label2)
        {
            pnlDetails.Visible = true;
            lblDet1.Text = label1;
            txtDet1.Clear();

            if (label2 != null)
            {
                lblDet2.Visible = true;
                txtDet2.Visible = true;
                lblDet2.Text = label2;
                txtDet2.Clear();
            }
            else
            {
                lblDet2.Visible = false;
                txtDet2.Visible = false;
            }
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesc.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            string specificDetails = "";
            if (pnlDetails.Visible)
            {
                specificDetails = $"{lblDet1.Text}: {txtDet1.Text}";
                if (txtDet2.Visible) specificDetails += $", {lblDet2.Text}: {txtDet2.Text}";
            }

            var report = new Report
            {
                ReporterName = _currentUser.FullName,
                ReporterUsername = _currentUser.Username,
                ReporterPhone = txtPhone.Text,
                Category = cboCategory.SelectedItem.ToString(),
                Urgency = cboUrgency.SelectedItem.ToString(),
                Description = txtDesc.Text,
                SpecificDetails = specificDetails,
                Status = "Pending",
                DateReported = DateTime.Now
            };

            btnSubmit.Enabled = false;
            try
            {
                bool success = await _api.AddReportAsync(report);
                if (success)
                {
                    MessageBox.Show("Report Submitted Successfully!");
                    txtDesc.Clear();
                    txtDet1.Clear();
                    txtDet2.Clear();
                    tabControl1.SelectedIndex = 1;
                    LoadHistory();
                }
                else MessageBox.Show("Failed.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { btnSubmit.Enabled = true; }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedReport == null || _selectedReport.Status != "Pending") return;

            DialogResult result = MessageBox.Show("To edit, we will remove the current request and fill the form for resubmission. Continue?", "Edit Report", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                await _api.DeleteReportAsync(_selectedReport.Id);
                txtPhone.Text = _selectedReport.ReporterPhone;
                txtDesc.Text = _selectedReport.Description;
                cboCategory.SelectedItem = _selectedReport.Category;
                cboUrgency.SelectedItem = _selectedReport.Urgency;
                tabControl1.SelectedIndex = 0;
                LoadHistory();
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedReport == null) return;

            if (MessageBox.Show("Are you sure you want to delete this report?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool success = await _api.DeleteReportAsync(_selectedReport.Id);
                if (success)
                {
                    MessageBox.Show("Report Deleted.");
                    LoadHistory();
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    _selectedReport = null;
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                LoadHistory();
               
                _ = ReloadUserStatus();
            }
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
   
            await ReloadUserStatus();
        }

        private async void LoadHistory()
        {
            try
            {
                var allReports = await _api.GetAllReportsAsync();
                var myReports = allReports
                    .Where(r => r.ReporterUsername == _currentUser.Username)
                    .OrderByDescending(r => r.DateReported)
                    .ToList();

                gridHistory.DataSource = myReports;

                string[] colsToHide = { "ReporterName", "ReporterUsername", "Id", "IsHidden" };
                foreach (string col in colsToHide)
                {
                    if (gridHistory.Columns[col] != null) gridHistory.Columns[col].Visible = false;
                }
            }
            catch { }
        }
    }
}