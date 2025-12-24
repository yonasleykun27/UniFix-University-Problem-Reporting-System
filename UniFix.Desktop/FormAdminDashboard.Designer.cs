namespace UniFix.Desktop
{
    partial class FormAdminDashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.txtFilterId = new System.Windows.Forms.TextBox();
            this.lblFilterId = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.grpReportDetails = new System.Windows.Forms.GroupBox();
            this.lblRepDetails = new System.Windows.Forms.Label();
            this.lblRepDesc = new System.Windows.Forms.Label();
            this.lblRepPhone = new System.Windows.Forms.Label();
            this.lblRepUrgency = new System.Windows.Forms.Label();
            this.lblRepCat = new System.Windows.Forms.Label();
            this.lblRepName = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPending = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAllReports = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button(); // *** ADDED ***
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.gridUserHistory = new System.Windows.Forms.DataGridView();
            this.grpUserDetails = new System.Windows.Forms.GroupBox();
            this.lblSelDorm = new System.Windows.Forms.Label();
            this.lblSelDept = new System.Windows.Forms.Label();
            this.lblSelId = new System.Windows.Forms.Label();
            this.lblSelRole = new System.Windows.Forms.Label();
            this.lblSelUser = new System.Windows.Forms.Label();
            this.lblSelName = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnWarnUser = new System.Windows.Forms.Button();
            this.cboFilterRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.grpReportDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllReports)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserHistory)).BeginInit();
            this.grpUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
         
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(23, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(173, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Admin Dashboard";
           
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
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(23, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 692);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
          
            this.tabReports.Controls.Add(this.txtFilterId);
            this.tabReports.Controls.Add(this.lblFilterId);
            this.tabReports.Controls.Add(this.cboFilterStatus);
            this.tabReports.Controls.Add(this.labelStatus);
            this.tabReports.Controls.Add(this.grpReportDetails);
            this.tabReports.Controls.Add(this.btnDecline);
            this.tabReports.Controls.Add(this.btnAssign);
            this.tabReports.Controls.Add(this.label2);
            this.tabReports.Controls.Add(this.gridPending);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.gridAllReports);
            this.tabReports.Location = new System.Drawing.Point(4, 26);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(12);
            this.tabReports.Size = new System.Drawing.Size(867, 662);
            this.tabReports.TabIndex = 0;
            this.tabReports.Text = "Manage Reports";
            this.tabReports.UseVisualStyleBackColor = true;
           
            this.txtFilterId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterId.Location = new System.Drawing.Point(327, 433);
            this.txtFilterId.Name = "txtFilterId";
            this.txtFilterId.PlaceholderText = "Search ID or Name...";
            this.txtFilterId.Size = new System.Drawing.Size(174, 25);
            this.txtFilterId.TabIndex = 10;
            this.txtFilterId.TextChanged += new System.EventHandler(this.TxtFilterId_TextChanged);
        
            this.lblFilterId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterId.AutoSize = true;
            this.lblFilterId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterId.Location = new System.Drawing.Point(210, 436);
            this.lblFilterId.Name = "lblFilterId";
            this.lblFilterId.Size = new System.Drawing.Size(93, 19);
            this.lblFilterId.TabIndex = 9;
            this.lblFilterId.Text = "Search User:";
            
            this.cboFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Assigned",
            "In Progress",
            "Finished",
            "Declined"});
            this.cboFilterStatus.Location = new System.Drawing.Point(642, 433);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(174, 25);
            this.cboFilterStatus.TabIndex = 8;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.CboFilterStatus_SelectedIndexChanged);
             
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(525, 436);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(91, 19);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Filter Status:";
        
            this.grpReportDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReportDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.grpReportDetails.Controls.Add(this.lblRepDetails);
            this.grpReportDetails.Controls.Add(this.lblRepDesc);
            this.grpReportDetails.Controls.Add(this.lblRepPhone);
            this.grpReportDetails.Controls.Add(this.lblRepUrgency);
            this.grpReportDetails.Controls.Add(this.lblRepCat);
            this.grpReportDetails.Controls.Add(this.lblRepName);
            this.grpReportDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpReportDetails.Location = new System.Drawing.Point(12, 300);
            this.grpReportDetails.Name = "grpReportDetails";
            this.grpReportDetails.Size = new System.Drawing.Size(840, 115);
            this.grpReportDetails.TabIndex = 6;
            this.grpReportDetails.TabStop = false;
            this.grpReportDetails.Text = "Selected Report Details";
           
            this.lblRepDetails.AutoSize = true;
            this.lblRepDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRepDetails.Location = new System.Drawing.Point(420, 58);
            this.lblRepDetails.Name = "lblRepDetails";
            this.lblRepDetails.Size = new System.Drawing.Size(130, 15);
            this.lblRepDetails.TabIndex = 5;
            this.lblRepDetails.Text = "Specific: Block 3 - 101";
          
            this.lblRepDesc.AutoSize = true;
            this.lblRepDesc.ForeColor = System.Drawing.Color.Black;
            this.lblRepDesc.Location = new System.Drawing.Point(23, 87);
            this.lblRepDesc.Name = "lblRepDesc";
            this.lblRepDesc.Size = new System.Drawing.Size(131, 15);
            this.lblRepDesc.TabIndex = 4;
            this.lblRepDesc.Text = "Desc: Light is broken...";
           
            this.lblRepPhone.AutoSize = true;
            this.lblRepPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRepPhone.Location = new System.Drawing.Point(420, 29);
            this.lblRepPhone.Name = "lblRepPhone";
            this.lblRepPhone.Size = new System.Drawing.Size(91, 15);
            this.lblRepPhone.TabIndex = 3;
            this.lblRepPhone.Text = "Phone: 0911.....";
          
            this.lblRepUrgency.AutoSize = true;
            this.lblRepUrgency.ForeColor = System.Drawing.Color.Red;
            this.lblRepUrgency.Location = new System.Drawing.Point(23, 58);
            this.lblRepUrgency.Name = "lblRepUrgency";
            this.lblRepUrgency.Size = new System.Drawing.Size(86, 15);
            this.lblRepUrgency.TabIndex = 2;
            this.lblRepUrgency.Text = "Urgency: High";
          
            this.lblRepCat.AutoSize = true;
            this.lblRepCat.ForeColor = System.Drawing.Color.Navy;
            this.lblRepCat.Location = new System.Drawing.Point(210, 58);
            this.lblRepCat.Name = "lblRepCat";
            this.lblRepCat.Size = new System.Drawing.Size(89, 15);
            this.lblRepCat.TabIndex = 1;
            this.lblRepCat.Text = "Cat: Dormitory";
            
            this.lblRepName.AutoSize = true;
            this.lblRepName.ForeColor = System.Drawing.Color.Navy;
            this.lblRepName.Location = new System.Drawing.Point(23, 29);
            this.lblRepName.Name = "lblRepName";
            this.lblRepName.Size = new System.Drawing.Size(116, 15);
            this.lblRepName.TabIndex = 0;
            this.lblRepName.Text = "Reporter: John Doe";
            
            this.btnDecline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecline.BackColor = System.Drawing.Color.Firebrick;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.ForeColor = System.Drawing.Color.White;
            this.btnDecline.Location = new System.Drawing.Point(735, 17);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(117, 35);
            this.btnDecline.TabIndex = 5;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.BtnDecline_Click);
           
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(607, 17);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(117, 35);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
         
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incoming Pending Reports";
           
            this.gridPending.AllowUserToAddRows = false;
            this.gridPending.AllowUserToDeleteRows = false;
            this.gridPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.gridPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPending.Location = new System.Drawing.Point(12, 58);
            this.gridPending.Name = "gridPending";
            this.gridPending.ReadOnly = true;
            this.gridPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPending.Size = new System.Drawing.Size(840, 231);
            this.gridPending.TabIndex = 2;
          
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Overview";
          
            this.gridAllReports.AllowUserToAddRows = false;
            this.gridAllReports.AllowUserToDeleteRows = false;
            this.gridAllReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAllReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllReports.Location = new System.Drawing.Point(12, 467);
            this.gridAllReports.Name = "gridAllReports";
            this.gridAllReports.ReadOnly = true;
            this.gridAllReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllReports.Size = new System.Drawing.Size(840, 179);
            this.gridAllReports.TabIndex = 0;
          
            this.tabUsers.Controls.Add(this.txtSearchUser);
            this.tabUsers.Controls.Add(this.lblSearchUser);
            this.tabUsers.Controls.Add(this.btnAddStaff); 
            this.tabUsers.Controls.Add(this.lblHistoryTitle);
            this.tabUsers.Controls.Add(this.gridUserHistory);
            this.tabUsers.Controls.Add(this.grpUserDetails);
            this.tabUsers.Controls.Add(this.btnRemoveUser);
            this.tabUsers.Controls.Add(this.btnWarnUser);
            this.tabUsers.Controls.Add(this.cboFilterRole);
            this.tabUsers.Controls.Add(this.label3);
            this.tabUsers.Controls.Add(this.gridUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 26);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(12);
            this.tabUsers.Size = new System.Drawing.Size(867, 662);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "User Database";
            this.tabUsers.UseVisualStyleBackColor = true;
           
            this.txtSearchUser.Location = new System.Drawing.Point(380, 21);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.PlaceholderText = "Search by ID or Name";
            this.txtSearchUser.Size = new System.Drawing.Size(130, 25); 
            this.txtSearchUser.TabIndex = 13;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.TxtSearchUser_TextChanged);
          
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearchUser.ForeColor = System.Drawing.Color.Navy;
            this.lblSearchUser.Location = new System.Drawing.Point(310, 21);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(65, 21);
            this.lblSearchUser.TabIndex = 12;
            this.lblSearchUser.Text = "Search:";
           
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.BackColor = System.Drawing.Color.Navy;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(525, 17); 
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(100, 35);
            this.btnAddStaff.TabIndex = 11;
            this.btnAddStaff.Text = "+ Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
         
            this.lblHistoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblHistoryTitle.Location = new System.Drawing.Point(12, 485);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(184, 21);
            this.lblHistoryTitle.TabIndex = 10;
            this.lblHistoryTitle.Text = "Selected User's History";
        
            this.gridUserHistory.AllowUserToAddRows = false;
            this.gridUserHistory.AllowUserToDeleteRows = false;
            this.gridUserHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUserHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUserHistory.Location = new System.Drawing.Point(12, 513);
            this.gridUserHistory.Name = "gridUserHistory";
            this.gridUserHistory.ReadOnly = true;
            this.gridUserHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUserHistory.Size = new System.Drawing.Size(840, 133);
            this.gridUserHistory.TabIndex = 9;
          
            this.grpUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.grpUserDetails.Controls.Add(this.lblSelDorm);
            this.grpUserDetails.Controls.Add(this.lblSelDept);
            this.grpUserDetails.Controls.Add(this.lblSelId);
            this.grpUserDetails.Controls.Add(this.lblSelRole);
            this.grpUserDetails.Controls.Add(this.lblSelUser);
            this.grpUserDetails.Controls.Add(this.lblSelName);
            this.grpUserDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpUserDetails.Location = new System.Drawing.Point(12, 358);
            this.grpUserDetails.Name = "grpUserDetails";
            this.grpUserDetails.Size = new System.Drawing.Size(842, 115);
            this.grpUserDetails.TabIndex = 8;
            this.grpUserDetails.TabStop = false;
            this.grpUserDetails.Text = "Selected User Details";
            
            this.lblSelDorm.AutoSize = true;
            this.lblSelDorm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSelDorm.Location = new System.Drawing.Point(408, 87);
            this.lblSelDorm.Name = "lblSelDorm";
            this.lblSelDorm.Size = new System.Drawing.Size(125, 15);
            this.lblSelDorm.TabIndex = 5;
            this.lblSelDorm.Text = "Housing: Block X - 00";
            
            this.lblSelDept.AutoSize = true;
            this.lblSelDept.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSelDept.Location = new System.Drawing.Point(408, 58);
            this.lblSelDept.Name = "lblSelDept";
            this.lblSelDept.Size = new System.Drawing.Size(100, 15);
            this.lblSelDept.TabIndex = 4;
            this.lblSelDept.Text = "Dept: CS (Year 3)";
           
            this.lblSelId.AutoSize = true;
            this.lblSelId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSelId.Location = new System.Drawing.Point(408, 29);
            this.lblSelId.Name = "lblSelId";
            this.lblSelId.Size = new System.Drawing.Size(82, 15);
            this.lblSelId.TabIndex = 3;
            this.lblSelId.Text = "ID: DBU123...";
           
            this.lblSelRole.AutoSize = true;
            this.lblSelRole.ForeColor = System.Drawing.Color.Navy;
            this.lblSelRole.Location = new System.Drawing.Point(23, 87);
            this.lblSelRole.Name = "lblSelRole";
            this.lblSelRole.Size = new System.Drawing.Size(83, 15);
            this.lblSelRole.TabIndex = 2;
            this.lblSelRole.Text = "Role: Student";
             
            this.lblSelUser.AutoSize = true;
            this.lblSelUser.ForeColor = System.Drawing.Color.Navy;
            this.lblSelUser.Location = new System.Drawing.Point(23, 58);
            this.lblSelUser.Name = "lblSelUser";
            this.lblSelUser.Size = new System.Drawing.Size(94, 15);
            this.lblSelUser.TabIndex = 1;
            this.lblSelUser.Text = "Username: stud";
         
            this.lblSelName.AutoSize = true;
            this.lblSelName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelName.ForeColor = System.Drawing.Color.Navy;
            this.lblSelName.Location = new System.Drawing.Point(23, 29);
            this.lblSelName.Name = "lblSelName";
            this.lblSelName.Size = new System.Drawing.Size(125, 20);
            this.lblSelName.TabIndex = 0;
            this.lblSelName.Text = "Name: John Doe";
          
            this.btnRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUser.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Location = new System.Drawing.Point(750, 17); 
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveUser.TabIndex = 7;
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
           
            this.btnWarnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWarnUser.BackColor = System.Drawing.Color.Orange;
            this.btnWarnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarnUser.ForeColor = System.Drawing.Color.Black;
            this.btnWarnUser.Location = new System.Drawing.Point(640, 17); 
            this.btnWarnUser.Name = "btnWarnUser";
            this.btnWarnUser.Size = new System.Drawing.Size(100, 35);
            this.btnWarnUser.TabIndex = 6;
            this.btnWarnUser.Text = "Warn";
            this.btnWarnUser.UseVisualStyleBackColor = false;
            this.btnWarnUser.Click += new System.EventHandler(this.BtnWarnUser_Click);
            
            this.cboFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterRole.FormattingEnabled = true;
            this.cboFilterRole.Items.AddRange(new object[] {
            "All",
            "Student",
            "Teacher",
            "Solver"});
            this.cboFilterRole.Location = new System.Drawing.Point(140, 21);
            this.cboFilterRole.Name = "cboFilterRole";
            this.cboFilterRole.Size = new System.Drawing.Size(150, 25);
            this.cboFilterRole.TabIndex = 5;
            this.cboFilterRole.SelectedIndexChanged += new System.EventHandler(this.CboFilterRole_SelectedIndexChanged);
           
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter Role:";
          
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(12, 69);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(840, 277);
            this.gridUsers.TabIndex = 0;
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(933, 808);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormAdminDashboard";
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.grpReportDetails.ResumeLayout(false);
            this.grpReportDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllReports)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserHistory)).EndInit();
            this.grpUserDetails.ResumeLayout(false);
            this.grpUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView gridPending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAllReports;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnWarnUser;
        private System.Windows.Forms.ComboBox cboFilterRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpUserDetails;
        private System.Windows.Forms.Label lblSelName;
        private System.Windows.Forms.Label lblSelDorm;
        private System.Windows.Forms.Label lblSelDept;
        private System.Windows.Forms.Label lblSelId;
        private System.Windows.Forms.Label lblSelRole;
        private System.Windows.Forms.Label lblSelUser;
        private System.Windows.Forms.GroupBox grpReportDetails;
        private System.Windows.Forms.Label lblRepDesc;
        private System.Windows.Forms.Label lblRepPhone;
        private System.Windows.Forms.Label lblRepUrgency;
        private System.Windows.Forms.Label lblRepCat;
        private System.Windows.Forms.Label lblRepName;
        private System.Windows.Forms.Label lblRepDetails;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtFilterId;
        private System.Windows.Forms.Label lblFilterId;
        private System.Windows.Forms.DataGridView gridUserHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearchUser;
    }
}