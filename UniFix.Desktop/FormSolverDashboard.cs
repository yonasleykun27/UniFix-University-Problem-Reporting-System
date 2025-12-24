using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormSolverDashboard : Form
    {
        private User _currentUser;
        private ApiClient _api = new ApiClient();
        private Report _selectedHistoryReport = null;

        public FormSolverDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
            lblWelcome.Text = $"Welcome, {user.FullName}";
            lblJobTitle.Text = user.JobTitle;

            
            ApplyModernStyles();

            LoadTasks();

            
            gridHistory.CellClick += GridHistory_CellClick;
        }

        private void ApplyModernStyles()
        {
            try
            {
               
                this.BackColor = UIHelper.BgColor; 

                
                lblWelcome.ForeColor = Color.White;
                lblWelcome.Font = new Font("Segoe UI", 16, FontStyle.Bold);

                if (lblJobTitle != null)
                {
                    lblJobTitle.ForeColor = UIHelper.AccentColor; 
                    lblJobTitle.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                }

                
                UIHelper.StyleGrid(gridActive);
                UIHelper.StyleGrid(gridHistory);

                
                UIHelper.StyleButton(btnStart, true);    
                UIHelper.StyleButton(btnFinish, false);  
                UIHelper.StyleButton(btnRefresh, true);
                UIHelper.StyleDangerButton(btnLogout);
                UIHelper.StyleDangerButton(btnDeleteHistory); 
            }
            catch {  }
        }

        private void GridHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _selectedHistoryReport = (Report)gridHistory.Rows[e.RowIndex].DataBoundItem;
            btnDeleteHistory.Enabled = true;

            
            string msg = $"Job Details:\n\n" +
                         $"Description: {_selectedHistoryReport.Description}\n" +
                         $"Specifics: {_selectedHistoryReport.SpecificDetails}\n" +
                         $"Reporter: {_selectedHistoryReport.ReporterName} ({_selectedHistoryReport.ReporterPhone})\n" +
                         $"Date: {_selectedHistoryReport.DateReported}";

            MessageBox.Show(msg, "Job History Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private async void BtnDeleteHistory_Click(object sender, EventArgs e)
        {
            if (_selectedHistoryReport == null) return;

            if (MessageBox.Show("Remove this job from your history?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                bool success = await _api.DeleteReportAsync(_selectedHistoryReport.Id);
                if (success)
                {
                    MessageBox.Show("Job removed from history.");
                    LoadTasks();
                    btnDeleteHistory.Enabled = false;
                    _selectedHistoryReport = null;
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private async void LoadTasks()
        {
            try
            {
                var reports = await _api.GetAllReportsAsync();

               
                var myTasks = reports.Where(r => r.AssignedTo == _currentUser.JobTitle).ToList();

                
                gridActive.DataSource = myTasks
                    .Where(r => r.Status != "Finished" && r.Status != "Completed" && r.Status != "Declined")
                    .OrderBy(r => r.DateReported)
                    .ToList();

                
                gridHistory.DataSource = myTasks
                    .Where(r => r.Status == "Finished" || r.Status == "Completed")
                    .OrderByDescending(r => r.DateReported)
                    .ToList();

                
                string[] colsToHide = { "Id", "IsHidden", "ReporterUsername", "AssignedTo" };

                foreach (string col in colsToHide)
                {
                    if (gridActive.Columns[col] != null) gridActive.Columns[col].Visible = false;
                    if (gridHistory.Columns[col] != null) gridHistory.Columns[col].Visible = false;
                }
            }
            catch { }
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (gridActive.SelectedRows.Count == 0) return;
            var task = (Report)gridActive.SelectedRows[0].DataBoundItem;

            if (task.Status == "Assigned")
            {
                if (await _api.UpdateReportStatusAsync(task.Id, "In Progress"))
                {
                    MessageBox.Show("Job Started!");
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Job is already started.");
            }
        }

        private async void BtnFinish_Click(object sender, EventArgs e)
        {
            if (gridActive.SelectedRows.Count == 0) return;
            var task = (Report)gridActive.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("Mark job as Finished?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (await _api.UpdateReportStatusAsync(task.Id, "Finished"))
                {
                    MessageBox.Show("Great Job! Task Finished.");
                    LoadTasks();
                }
            }
        }
    }
}