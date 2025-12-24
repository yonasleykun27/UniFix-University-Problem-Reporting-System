namespace UniFix.Desktop
{
    partial class FormSolverDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabActive = new System.Windows.Forms.TabPage();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridActive = new System.Windows.Forms.DataGridView();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnDeleteHistory = new System.Windows.Forms.Button(); 
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActive)).BeginInit();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.SuspendLayout();
           
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(155, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Solver";
             
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblJobTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblJobTitle.Location = new System.Drawing.Point(600, 20);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(59, 19);
            this.lblJobTitle.TabIndex = 1;
            this.lblJobTitle.Text = "Job Title";
            
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(780, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
             
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabActive);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 500);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            
            this.tabActive.Controls.Add(this.btnFinish);
            this.tabActive.Controls.Add(this.btnStart);
            this.tabActive.Controls.Add(this.label1);
            this.tabActive.Controls.Add(this.gridActive);
            this.tabActive.Location = new System.Drawing.Point(4, 26);
            this.tabActive.Name = "tabActive";
            this.tabActive.Padding = new System.Windows.Forms.Padding(10);
            this.tabActive.Size = new System.Drawing.Size(842, 470);
            this.tabActive.TabIndex = 0;
            this.tabActive.Text = "Active Tasks";
            this.tabActive.UseVisualStyleBackColor = true;
           
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(720, 15);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(110, 35);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish Job";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
             
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(600, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Job";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
             
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jobs To Do...";
           
            this.gridActive.AllowUserToAddRows = false;
            this.gridActive.AllowUserToDeleteRows = false;
            this.gridActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActive.Location = new System.Drawing.Point(10, 60);
            this.gridActive.Name = "gridActive";
            this.gridActive.ReadOnly = true;
            this.gridActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridActive.Size = new System.Drawing.Size(820, 400);
            this.gridActive.TabIndex = 0;
            
            this.tabHistory.Controls.Add(this.btnDeleteHistory);
            this.tabHistory.Controls.Add(this.btnRefresh);
            this.tabHistory.Controls.Add(this.gridHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 26);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(10);
            this.tabHistory.Size = new System.Drawing.Size(842, 470);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "Job History";
            this.tabHistory.UseVisualStyleBackColor = true;
           
            this.btnDeleteHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHistory.Location = new System.Drawing.Point(620, 15);
            this.btnDeleteHistory.Name = "btnDeleteHistory";
            this.btnDeleteHistory.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteHistory.TabIndex = 2;
            this.btnDeleteHistory.Text = "Delete";
            this.btnDeleteHistory.UseVisualStyleBackColor = true;
            this.btnDeleteHistory.Enabled = false;
            this.btnDeleteHistory.Click += new System.EventHandler(this.BtnDeleteHistory_Click);
            
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(730, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            
            this.gridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Location = new System.Drawing.Point(10, 50);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ReadOnly = true;
            this.gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistory.Size = new System.Drawing.Size(820, 410);
            this.gridHistory.TabIndex = 0;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormSolverDashboard";
            this.Text = "Staff Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabActive.ResumeLayout(false);
            this.tabActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActive)).EndInit();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabActive;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.DataGridView gridActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.Button btnDeleteHistory; 
    }
}