using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormAdminDashboard : Form
    {
        private ApiClient _api = new ApiClient();

        public FormAdminDashboard(User user)
        {
            InitializeComponent();

            lblWelcome.Text = $"Admin Dashboard - {user.FullName}";

         
            cboFilterRole.SelectedIndex = 0; 
            cboFilterStatus.SelectedIndex = 0; 

         
            ApplyModernStyles();

            LoadReports();

        
            gridUsers.SelectionChanged += GridUsers_SelectionChanged;
            gridPending.SelectionChanged += GridReport_SelectionChanged;   
            gridAllReports.SelectionChanged += GridReport_SelectionChanged; 

            ClearUserLabels();
            ClearReportLabels();
        }

        private void ApplyModernStyles()
        {
            try
            {
                
                this.BackColor = UIHelper.BgColor; 
                tabReports.BackColor = Color.White;
                tabUsers.BackColor = Color.White;

        
                lblWelcome.ForeColor = Color.White;
                lblWelcome.Font = new Font("Segoe UI", 16, FontStyle.Bold);

              
                UIHelper.StyleGrid(gridPending);
                UIHelper.StyleGrid(gridAllReports);
                UIHelper.StyleGrid(gridUsers);
                UIHelper.StyleGrid(gridUserHistory);

          
                UIHelper.StyleButton(btnAssign, true);

                UIHelper.StyleButton(btnAddStaff, true);
                btnAddStaff.Visible = true;

                UIHelper.StyleDangerButton(btnDecline);
                UIHelper.StyleDangerButton(btnLogout);
                UIHelper.StyleDangerButton(btnRemoveUser);
                UIHelper.StyleButton(btnWarnUser, false);

               
                UIHelper.StyleTextBox(txtFilterId);
                UIHelper.StyleTextBox(txtSearchUser);

                grpReportDetails.ForeColor = UIHelper.PrimaryColor;
                grpUserDetails.ForeColor = UIHelper.PrimaryColor;

                label1.ForeColor = UIHelper.PrimaryColor;
                label2.ForeColor = UIHelper.AccentColor;
                label3.ForeColor = UIHelper.TextColor;
                lblFilterId.ForeColor = UIHelper.TextColor;
                labelStatus.ForeColor = UIHelper.TextColor;
                lblSearchUser.ForeColor = UIHelper.TextColor;
                lblHistoryTitle.ForeColor = UIHelper.PrimaryColor;
            }
            catch {  }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) LoadReports();
            else LoadUsers();
        }

     

        private async void LoadReports()
        {
            try
            {
                var reports = await _api.GetAllReportsAsync();

              
                var pendingReports = reports.Where(r => r.Status == "Pending").ToList();

            
                var historyReports = reports.OrderByDescending(r => r.DateReported).ToList();

              
                string statusFilter = cboFilterStatus.SelectedItem.ToString();
                if (statusFilter != "All")
                {
                    historyReports = historyReports.Where(r => r.Status == statusFilter).ToList();
                }

               
                string searchText = txtFilterId.Text?.Trim().ToLower() ?? "";
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    pendingReports = pendingReports
                        .Where(r => (r.ReporterUsername != null && r.ReporterUsername.ToLower().Contains(searchText)) ||
                                    (r.ReporterName != null && r.ReporterName.ToLower().Contains(searchText)))
                        .ToList();

                    historyReports = historyReports
                        .Where(r => (r.ReporterUsername != null && r.ReporterUsername.ToLower().Contains(searchText)) ||
                                    (r.ReporterName != null && r.ReporterName.ToLower().Contains(searchText)))
                        .ToList();
                }

          
                gridPending.DataSource = pendingReports;
                HideTechColumns(gridPending);

                gridAllReports.DataSource = historyReports;
                HideTechColumns(gridAllReports);
            }
            catch { }
        }

        private void HideTechColumns(DataGridView grid)
        {
            if (grid.Columns["Id"] != null) grid.Columns["Id"].Visible = false;
            if (grid.Columns["IsHidden"] != null) grid.Columns["IsHidden"].Visible = false;
        }

        private void CboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadReports();
        private void TxtFilterId_TextChanged(object sender, EventArgs e) => LoadReports();

        private void GridReport_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.SelectedRows.Count > 0)
            {
                var report = (Report)senderGrid.SelectedRows[0].DataBoundItem;

                lblRepName.Text = $"Reporter: {report.ReporterName}";
                lblRepCat.Text = $"Cat: {report.Category}";
                lblRepPhone.Text = $"Phone: {report.ReporterPhone}";
                lblRepDesc.Text = $"Desc: {report.Description}";

                if (report.Status == "Declined")
                {
                    lblRepUrgency.Text = "Status: DECLINED";
                    lblRepUrgency.ForeColor = Color.Red;
                    lblRepDetails.Text = $"Reason: {report.DeclineReason}";
                    lblRepDetails.ForeColor = Color.Red;
                }
                else if (report.Status == "Finished")
                {
                    lblRepUrgency.Text = "Status: FINISHED";
                    lblRepUrgency.ForeColor = Color.Green;
                    lblRepDetails.Text = $"Specific: {report.SpecificDetails}";
                    lblRepDetails.ForeColor = UIHelper.TextColor;
                }
                else
                {
                    lblRepUrgency.Text = $"Urgency: {report.Urgency}";
                    lblRepUrgency.ForeColor = GetUrgencyColor(report.Urgency);
                    lblRepDetails.Text = $"Specific: {report.SpecificDetails}";
                    lblRepDetails.ForeColor = UIHelper.TextColor;
                }
            }
        }

        private Color GetUrgencyColor(string urgency)
        {
            if (urgency == "High" || urgency == "Urgent") return Color.Red;
            if (urgency == "Medium") return Color.Orange;
            return Color.Green;
        }

        private void ClearReportLabels()
        {
            lblRepName.Text = "Reporter: -";
            lblRepCat.Text = "Cat: -";
            lblRepUrgency.Text = "Urgency: -";
            lblRepUrgency.ForeColor = Color.Black;
            lblRepPhone.Text = "Phone: -";
            lblRepDesc.Text = "Desc: -";
            lblRepDetails.Text = "Specific: -";
            lblRepDetails.ForeColor = Color.Black;
        }

        private async void BtnAssign_Click(object sender, EventArgs e)
        {
            if (gridPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Pending report.");
                return;
            }
            var report = (Report)gridPending.SelectedRows[0].DataBoundItem;
            string solver = "Staff General Technician";

            if (report.Category == "Dormitory") solver = "Staff Dormitory Manager";
            else if (report.Category == "Health") solver = "Staff Health Center Manager";
            else if (report.Category == "Cafeteria") solver = "Staff Cafeteria Manager";
            else if (report.Category == "Academic") solver = "Staff Dean";
            else if (report.Category == "Administrative") solver = "Staff University Administration Manager";
            else if (report.Category == "Technology") solver = "Staff ICT Manager";
            else if (report.Category == "Social") solver = "Staff Campus Security Manager";
            else if (report.Category == "Teaching Materials") solver = "Staff Academic Resources Manager";
            else if (report.Category == "Classroom Mgmt") solver = "Staff Department Head";
            else if (report.Category == "Work Environment") solver = "Staff Human Resource Manager";
            else if (report.Category == "Other") solver = "Staff General Technician";

            if (await _api.UpdateReportStatusAsync(report.Id, "Assigned", solver))
            {
                MessageBox.Show($"Assigned to: {solver}");
                LoadReports();
                ClearReportLabels();
            }
            else MessageBox.Show("Failed to assign.");
        }

        private async void BtnDecline_Click(object sender, EventArgs e)
        {
            if (gridPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a Pending report.");
                return;
            }
          
            string reason = Prompt.ShowDialog("Enter reason:", "Decline Report");

            if (!string.IsNullOrWhiteSpace(reason))
            {
                if (await _api.UpdateReportStatusAsync(((Report)gridPending.SelectedRows[0].DataBoundItem).Id, "Declined", "Admin", reason))
                {
                    MessageBox.Show("Declined.");
                    LoadReports();
                    ClearReportLabels();
                }
            }
        }


        private async void LoadUsers()
        {
            try
            {
                var users = await _api.GetAllUsersAsync();
                string filterRole = cboFilterRole.SelectedItem.ToString();
                string search = txtSearchUser.Text.Trim().ToLower();

                var filteredUsers = users.Where(u =>
                {
                    bool matchesRole = (filterRole == "All") || (u.Role == filterRole);
                    bool matchesSearch = string.IsNullOrEmpty(search) ||
                                         (u.Username != null && u.Username.ToLower().Contains(search)) ||
                                         (u.FullName != null && u.FullName.ToLower().Contains(search)) ||
                                         (u.UserIdCard != null && u.UserIdCard.ToLower().Contains(search));
                    return matchesRole && matchesSearch;
                }).ToList();

                gridUsers.DataSource = filteredUsers;

                string[] colsToHide = { "Password", "IsBanned", "Id", "Warnings" };
                foreach (string col in colsToHide)
                {
                    if (gridUsers.Columns[col] != null) gridUsers.Columns[col].Visible = false;
                }
            }
            catch { }
        }

        private void CboFilterRole_SelectedIndexChanged(object sender, EventArgs e) => LoadUsers();
        private void TxtSearchUser_TextChanged(object sender, EventArgs e) => LoadUsers();

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            var addForm = new FormAddStaff();
            addForm.ShowDialog();
            LoadUsers();
        }

        private async void GridUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count > 0)
            {
                var user = (User)gridUsers.SelectedRows[0].DataBoundItem;

                lblSelName.Text = $"Name: {user.FullName}";
                lblSelUser.Text = $"Username: {user.Username}";
                lblSelRole.Text = $"Role: {user.Role}";
                lblSelId.Text = $"ID Card: {user.UserIdCard}";

                if (user.Role == "Student")
                {
                    lblSelDept.Visible = true;
                    lblSelDorm.Visible = true;
                    lblSelDept.Text = $"Dept: {user.Department} (Year {user.Year})";
                    lblSelDorm.Text = $"Housing: Block {user.Block} - Dorm {user.Dorm}";

                    if (user.Warnings > 0)
                    {
                        lblSelDorm.Text += $"   ⚠️ WARNINGS: {user.Warnings}";
                        lblSelDorm.ForeColor = Color.Red;
                    }
                    else lblSelDorm.ForeColor = Color.DarkSlateGray;
                }
                else
                {
                    lblSelDept.Visible = false;
                    lblSelDorm.Visible = false;
                    if (user.Warnings > 0)
                    {
                        lblSelId.Text += $"   ⚠️ WARNINGS: {user.Warnings}";
                        lblSelId.ForeColor = Color.Red;
                    }
                    else lblSelId.ForeColor = Color.DarkSlateGray;
                }

                try
                {
                    var allReports = await _api.GetAllReportsAsync();
                    var userHistory = allReports
                        .Where(r => r.ReporterUsername == user.Username)
                        .OrderByDescending(r => r.DateReported)
                        .ToList();

                    gridUserHistory.DataSource = userHistory;
                    HideTechColumns(gridUserHistory);
                }
                catch { }
            }
            else
            {
                ClearUserLabels();
                gridUserHistory.DataSource = null;
            }
        }

        private void ClearUserLabels()
        {
            lblSelName.Text = "Name: -";
            lblSelUser.Text = "Username: -";
            lblSelRole.Text = "Role: -";
            lblSelId.Text = "ID Card: -";
            lblSelId.ForeColor = Color.DarkSlateGray;
            lblSelDept.Text = "";
            lblSelDorm.Text = "";
            lblSelDorm.ForeColor = Color.DarkSlateGray;
        }

        private async void BtnWarnUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count == 0) return;
            var user = (User)gridUsers.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Warn {user.Username}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (await _api.WarnUserAsync(user.Id))
                {
                    MessageBox.Show("User Warned.");
                    LoadUsers();
                }
            }
        }

        private async void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count == 0) return;
            var user = (User)gridUsers.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Delete {user.Username}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (await _api.DeleteUserAsync(user.Id))
                {
                    MessageBox.Show("User Deleted.");
                    LoadUsers();
                }
            }
        }
    }


    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}