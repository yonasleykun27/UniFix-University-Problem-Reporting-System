namespace UniFix.Desktop
{
    partial class FormStudentDashboard
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
            this.lblWarnings = new System.Windows.Forms.Label(); 
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtDet2 = new System.Windows.Forms.TextBox();
            this.lblDet2 = new System.Windows.Forms.Label();
            this.txtDet1 = new System.Windows.Forms.TextBox();
            this.lblDet1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUrgency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button(); 
            this.btnEdit = new System.Windows.Forms.Button();  
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.SuspendLayout();
          
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(23, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Student";
          
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWarnings.ForeColor = System.Drawing.Color.Gold;
            this.lblWarnings.Location = new System.Drawing.Point(500, 20);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(117, 21);
            this.lblWarnings.TabIndex = 3;
            this.lblWarnings.Text = "⚠️ Warnings: 0";
            this.lblWarnings.Visible = false;
            
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(793, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
           
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(23, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 577);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            
            this.tabReport.Controls.Add(this.grpDetails);
            this.tabReport.Controls.Add(this.btnSubmit);
            this.tabReport.Controls.Add(this.txtDesc);
            this.tabReport.Controls.Add(this.label2);
            this.tabReport.Controls.Add(this.cboUrgency);
            this.tabReport.Controls.Add(this.label1);
            this.tabReport.Controls.Add(this.txtPhone);
            this.tabReport.Controls.Add(this.lblPhone);
            this.tabReport.Controls.Add(this.cboCategory);
            this.tabReport.Controls.Add(this.lblCat);
            this.tabReport.Location = new System.Drawing.Point(4, 26);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(23);
            this.tabReport.Size = new System.Drawing.Size(867, 547);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "Report Issue";
            this.tabReport.UseVisualStyleBackColor = true;
           
            this.grpDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDetails.Controls.Add(this.txtDet2);
            this.grpDetails.Controls.Add(this.lblDet2);
            this.grpDetails.Controls.Add(this.txtDet1);
            this.grpDetails.Controls.Add(this.lblDet1);

            this.grpDetails.Location = new System.Drawing.Point(28, 92);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(793, 92);
            this.grpDetails.TabIndex = 9;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Specific Details";
            this.grpDetails.Visible = false;
         
            this.txtDet2.Location = new System.Drawing.Point(420, 52);
            this.txtDet2.Name = "txtDet2";
            this.txtDet2.Size = new System.Drawing.Size(349, 25);
            this.txtDet2.TabIndex = 3;
            this.lblDet2.AutoSize = true;
            this.lblDet2.Location = new System.Drawing.Point(420, 29);
            this.lblDet2.Name = "lblDet2";
            this.lblDet2.Size = new System.Drawing.Size(56, 19);
            this.lblDet2.TabIndex = 2;
            this.lblDet2.Text = "Detail 2";
           
            this.txtDet1.Location = new System.Drawing.Point(23, 52);
            this.txtDet1.Name = "txtDet1";
            this.txtDet1.Size = new System.Drawing.Size(349, 25);
            this.txtDet1.TabIndex = 1;
            
            this.lblDet1.AutoSize = true;
            this.lblDet1.Location = new System.Drawing.Point(23, 29);
            this.lblDet1.Name = "lblDet1";
            this.lblDet1.Size = new System.Drawing.Size(56, 19);
            this.lblDet1.TabIndex = 0;
            this.lblDet1.Text = "Detail 1";
           
            this.btnSubmit.BackColor = System.Drawing.Color.Navy;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(28, 438);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(233, 46);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit Report";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
           
            this.txtDesc.Location = new System.Drawing.Point(28, 277);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(793, 138);
            this.txtDesc.TabIndex = 7;
           
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
          
            this.cboUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrgency.FormattingEnabled = true;
            this.cboUrgency.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Urgent"});
            this.cboUrgency.Location = new System.Drawing.Point(28, 208);
            this.cboUrgency.Name = "cboUrgency";
            this.cboUrgency.Size = new System.Drawing.Size(349, 25);
            this.cboUrgency.TabIndex = 5;
           
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Urgency";
          
            this.txtPhone.Location = new System.Drawing.Point(471, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(349, 25);
            this.txtPhone.TabIndex = 3;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(471, 29);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(28, 52);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(349, 25);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
        
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCat.Location = new System.Drawing.Point(28, 29);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(57, 15);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Category";

            this.tabHistory.Controls.Add(this.btnDelete); 
            this.tabHistory.Controls.Add(this.btnEdit);   
            this.tabHistory.Controls.Add(this.btnRefresh);
            this.tabHistory.Controls.Add(this.gridHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 26);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tabHistory.Size = new System.Drawing.Size(867, 547);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "My History";
            this.tabHistory.UseVisualStyleBackColor = true;
            
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(740, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
         
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(620, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
          
            this.btnRefresh.Location = new System.Drawing.Point(7, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
          
            this.gridHistory.AllowUserToAddRows = false;
            this.gridHistory.AllowUserToDeleteRows = false;
            this.gridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHistory.BackgroundColor = System.Drawing.Color.White;
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Location = new System.Drawing.Point(7, 52);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ReadOnly = true;
            this.gridHistory.RowHeadersVisible = false;
            this.gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistory.Size = new System.Drawing.Size(852, 483);
            this.gridHistory.TabIndex = 0;
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(933, 692);
            this.Controls.Add(this.lblWarnings); 
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormStudentDashboard";
            this.Text = "Student Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cboUrgency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtDet2;
        private System.Windows.Forms.Label lblDet2;
        private System.Windows.Forms.TextBox txtDet1;
        private System.Windows.Forms.Label lblDet1;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete; 
        private System.Windows.Forms.Button btnEdit;   
        private System.Windows.Forms.Label lblWarnings; 
    }
}