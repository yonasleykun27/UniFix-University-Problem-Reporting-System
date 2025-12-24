namespace UniFix.Desktop
{
    partial class FormTeacherDashboard
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
            lblWelcome = new Label();
            lblWarnings = new Label();
            btnLogout = new Button();
            tabControl1 = new TabControl();
            tabReport = new TabPage();
            pnlDetails = new GroupBox();
            txtDet2 = new TextBox();
            lblDet2 = new Label();
            txtDet1 = new TextBox();
            lblDet1 = new Label();
            btnSubmit = new Button();
            txtDesc = new TextBox();
            label2 = new Label();
            cboUrgency = new ComboBox();
            label1 = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            cboCategory = new ComboBox();
            lblCat = new Label();
            tabHistory = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            gridHistory = new DataGridView();
            tabControl1.SuspendLayout();
            tabReport.SuspendLayout();
            pnlDetails.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridHistory).BeginInit();
            SuspendLayout();
          
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(23, 17);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(165, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Teacher";
           
            lblWarnings.AutoSize = true;
            lblWarnings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWarnings.ForeColor = Color.Gold;
            lblWarnings.Location = new Point(583, 23);
            lblWarnings.Margin = new Padding(4, 0, 4, 0);
            lblWarnings.Name = "lblWarnings";
            lblWarnings.Size = new Size(126, 21);
            lblWarnings.TabIndex = 3;
            lblWarnings.Text = "⚠️ Warnings: 0";
            lblWarnings.Visible = false;
          
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Crimson;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(793, 17);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(105, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
           
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabReport);
            tabControl1.Controls.Add(tabHistory);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(23, 69);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 577);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
           
        
            tabReport.Controls.Add(pnlDetails);
            tabReport.Controls.Add(btnSubmit);
            tabReport.Controls.Add(txtDesc);
            tabReport.Controls.Add(label2);
            tabReport.Controls.Add(cboUrgency);
            tabReport.Controls.Add(label1);
            tabReport.Controls.Add(txtPhone);
            tabReport.Controls.Add(lblPhone);
            tabReport.Controls.Add(cboCategory);
            tabReport.Controls.Add(lblCat);
            tabReport.Location = new Point(4, 26);
            tabReport.Margin = new Padding(4, 3, 4, 3);
            tabReport.Name = "tabReport";
            tabReport.Padding = new Padding(23, 23, 23, 23);
            tabReport.Size = new Size(867, 547);
            tabReport.TabIndex = 0;
            tabReport.Text = "Report Issue";
            tabReport.UseVisualStyleBackColor = true;
           
            pnlDetails.BackColor = Color.AliceBlue;
            pnlDetails.Controls.Add(txtDet2);
            pnlDetails.Controls.Add(lblDet2);
            pnlDetails.Controls.Add(txtDet1);
            pnlDetails.Controls.Add(lblDet1);
            pnlDetails.Location = new Point(28, 92);
            pnlDetails.Margin = new Padding(4, 3, 4, 3);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(4, 3, 4, 3);
            pnlDetails.Size = new Size(793, 92);
            pnlDetails.TabIndex = 9;
            pnlDetails.TabStop = false;
            pnlDetails.Text = "Specific Details";
            pnlDetails.Visible = false;
            
            txtDet2.Location = new Point(420, 46);
            txtDet2.Margin = new Padding(4, 3, 4, 3);
            txtDet2.Name = "txtDet2";
            txtDet2.Size = new Size(349, 25);
            txtDet2.TabIndex = 3;
          
            lblDet2.AutoSize = true;
            lblDet2.Location = new Point(420, 23);
            lblDet2.Margin = new Padding(4, 0, 4, 0);
            lblDet2.Name = "lblDet2";
            lblDet2.Size = new Size(56, 19);
            lblDet2.TabIndex = 2;
            lblDet2.Text = "Detail 2";
           
            txtDet1.Location = new Point(23, 46);
            txtDet1.Margin = new Padding(4, 3, 4, 3);
            txtDet1.Name = "txtDet1";
            txtDet1.Size = new Size(349, 25);
            txtDet1.TabIndex = 1;
        
            lblDet1.AutoSize = true;
            lblDet1.Location = new Point(23, 23);
            lblDet1.Margin = new Padding(4, 0, 4, 0);
            lblDet1.Name = "lblDet1";
            lblDet1.Size = new Size(56, 19);
            lblDet1.TabIndex = 0;
            lblDet1.Text = "Detail 1";
            
            btnSubmit.BackColor = Color.Navy;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(28, 462);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(233, 46);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit Report";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
           
            txtDesc.Location = new Point(28, 300);
            txtDesc.Margin = new Padding(4, 3, 4, 3);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(793, 138);
            txtDesc.TabIndex = 7;
           
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "Description";
          
            cboUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrgency.FormattingEnabled = true;
            cboUrgency.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cboUrgency.Location = new Point(28, 231);
            cboUrgency.Margin = new Padding(4, 3, 4, 3);
            cboUrgency.Name = "cboUrgency";
            cboUrgency.Size = new Size(349, 25);
            cboUrgency.TabIndex = 5;
          
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 208);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Urgency";
           
            txtPhone.Location = new Point(471, 52);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(349, 25);
            txtPhone.TabIndex = 3;
          
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(471, 29);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(91, 15);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number";
            
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(28, 52);
            cboCategory.Margin = new Padding(4, 3, 4, 3);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(349, 25);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
           
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCat.Location = new Point(28, 29);
            lblCat.Margin = new Padding(4, 0, 4, 0);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(57, 15);
            lblCat.TabIndex = 0;
            lblCat.Text = "Category";
           
            tabHistory.Controls.Add(btnDelete);
            tabHistory.Controls.Add(btnEdit);
            tabHistory.Controls.Add(btnRefresh);
            tabHistory.Controls.Add(gridHistory);
            tabHistory.Location = new Point(4, 26);
            tabHistory.Margin = new Padding(4, 3, 4, 3);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(4, 3, 4, 3);
            tabHistory.Size = new Size(867, 547);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "My History";
            tabHistory.UseVisualStyleBackColor = true;
           
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(723, 12);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
           
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(583, 12);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
           
            btnRefresh.Location = new Point(7, 12);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            
            gridHistory.AllowUserToAddRows = false;
            gridHistory.AllowUserToDeleteRows = false;
            gridHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridHistory.BackgroundColor = Color.White;
            gridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHistory.Location = new Point(7, 52);
            gridHistory.Margin = new Padding(4, 3, 4, 3);
            gridHistory.Name = "gridHistory";
            gridHistory.ReadOnly = true;
            gridHistory.RowHeadersVisible = false;
            gridHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridHistory.Size = new Size(852, 483);
            gridHistory.TabIndex = 0;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 8, 65);
            ClientSize = new Size(933, 692);
            Controls.Add(lblWarnings);
            Controls.Add(tabControl1);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormTeacherDashboard";
            Text = "Teacher Dashboard";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabReport.ResumeLayout(false);
            tabReport.PerformLayout();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.GroupBox pnlDetails;
        private System.Windows.Forms.TextBox txtDet2;
        private System.Windows.Forms.Label lblDet2;
        private System.Windows.Forms.TextBox txtDet1;
        private System.Windows.Forms.Label lblDet1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.Label lblWarnings;
    }
}