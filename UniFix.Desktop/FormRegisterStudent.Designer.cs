namespace UniFix.Desktop
{
    partial class FormRegisterStudent
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
            pnlCard = new Panel();
            btnEye = new Button();
            btnBack = new Button();
            btnRegister = new Button();
            grpIdVerify = new GroupBox();
            btnUploadBack = new Button();
            btnUploadFront = new Button();
            lblVerifyStatus = new Label();
            txtDorm = new TextBox();
            lblDorm = new Label();
            txtBlock = new TextBox();
            lblBlock = new Label();
            txtYear = new TextBox();
            lblYear = new Label();
            txtDept = new TextBox();
            lblDept = new Label();
            txtPass = new TextBox();
            lblPass = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblTitle = new Label();
            pnlCard.SuspendLayout();
            grpIdVerify.SuspendLayout();
            SuspendLayout();
           
            pnlCard.AutoScroll = true;
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(btnEye);
            pnlCard.Controls.Add(btnBack);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(grpIdVerify);
            pnlCard.Controls.Add(txtDorm);
            pnlCard.Controls.Add(lblDorm);
            pnlCard.Controls.Add(txtBlock);
            pnlCard.Controls.Add(lblBlock);
            pnlCard.Controls.Add(txtYear);
            pnlCard.Controls.Add(lblYear);
            pnlCard.Controls.Add(txtDept);
            pnlCard.Controls.Add(lblDept);
            pnlCard.Controls.Add(txtPass);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtStudentId);
            pnlCard.Controls.Add(lblStudentId);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(150, 20);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 700);
            pnlCard.TabIndex = 0;
           
            btnEye.Location = new Point(430, 279);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(30, 23);
            btnEye.TabIndex = 21;
            btnEye.UseVisualStyleBackColor = true;
           
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Gray;
            btnBack.Location = new Point(150, 640);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 30);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back to Login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
          
            btnRegister.BackColor = Color.Navy;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(40, 580);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(420, 45);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
          
            grpIdVerify.BackColor = Color.AliceBlue;
            grpIdVerify.Controls.Add(btnUploadBack);
            grpIdVerify.Controls.Add(btnUploadFront);
            grpIdVerify.Controls.Add(lblVerifyStatus);
            grpIdVerify.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpIdVerify.Location = new Point(40, 450);
            grpIdVerify.Name = "grpIdVerify";
            grpIdVerify.Size = new Size(420, 110);
            grpIdVerify.TabIndex = 18;
            grpIdVerify.TabStop = false;
            grpIdVerify.Text = "ID Verification (Required)";
          
            btnUploadBack.BackColor = Color.White;
            btnUploadBack.FlatStyle = FlatStyle.Flat;
            btnUploadBack.Font = new Font("Segoe UI", 8F);
            btnUploadBack.Location = new Point(220, 30);
            btnUploadBack.Name = "btnUploadBack";
            btnUploadBack.Size = new Size(180, 30);
            btnUploadBack.TabIndex = 1;
            btnUploadBack.Text = "Upload Back ID";
            btnUploadBack.UseVisualStyleBackColor = false;
            btnUploadBack.Click += BtnUpload_Click;
        
            btnUploadFront.BackColor = Color.White;
            btnUploadFront.FlatStyle = FlatStyle.Flat;
            btnUploadFront.Font = new Font("Segoe UI", 8F);
            btnUploadFront.Location = new Point(20, 30);
            btnUploadFront.Name = "btnUploadFront";
            btnUploadFront.Size = new Size(180, 30);
            btnUploadFront.TabIndex = 0;
            btnUploadFront.Text = "Upload Front ID";
            btnUploadFront.UseVisualStyleBackColor = false;
            btnUploadFront.Click += BtnUpload_Click;
            
         
            lblVerifyStatus.AutoSize = true;
            lblVerifyStatus.ForeColor = Color.Red;
            lblVerifyStatus.Location = new Point(20, 75);
            lblVerifyStatus.Name = "lblVerifyStatus";
            lblVerifyStatus.Size = new Size(116, 15);
            lblVerifyStatus.TabIndex = 2;
            lblVerifyStatus.Text = "Status: Not Verified";
            
            txtDorm.Location = new Point(260, 400);
            txtDorm.Name = "txtDorm";
            txtDorm.Size = new Size(200, 23);
            txtDorm.TabIndex = 17;
            
            lblDorm.AutoSize = true;
            lblDorm.Location = new Point(260, 380);
            lblDorm.Name = "lblDorm";
            lblDorm.Size = new Size(84, 15);
            lblDorm.TabIndex = 16;
            lblDorm.Text = "Dorm Number";
           
            txtBlock.Location = new Point(40, 400);
            txtBlock.Name = "txtBlock";
            txtBlock.Size = new Size(200, 23);
            txtBlock.TabIndex = 15;
            
            lblBlock.AutoSize = true;
            lblBlock.Location = new Point(40, 380);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(83, 15);
            lblBlock.TabIndex = 14;
            lblBlock.Text = "Block Number";
          
            txtYear.Location = new Point(260, 340);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(200, 23);
            txtYear.TabIndex = 13;
            lblYear.AutoSize = true;
            lblYear.Location = new Point(260, 320);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(76, 15);
            lblYear.TabIndex = 12;
            lblYear.Text = "Year of Study";
             
            txtDept.Location = new Point(40, 340);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(200, 23);
            txtDept.TabIndex = 11;
            
            lblDept.AutoSize = true;
            lblDept.Location = new Point(40, 320);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(70, 15);
            lblDept.TabIndex = 10;
            lblDept.Text = "Department";
           
            txtPass.Location = new Point(260, 280);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(200, 23);
            txtPass.TabIndex = 9;
           
            lblPass.AutoSize = true;
            lblPass.Location = new Point(260, 260);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 8;
            lblPass.Text = "Password";
             
            txtUser.Location = new Point(40, 280);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "e.g. stud12345";
            txtUser.Size = new Size(200, 23);
            txtUser.TabIndex = 7;
            
            lblUser.AutoSize = true;
            lblUser.Location = new Point(40, 260);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Username";
            
            txtStudentId.Location = new Point(40, 220);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.PlaceholderText = "DBU...";
            txtStudentId.Size = new Size(420, 23);
            txtStudentId.TabIndex = 5;
            
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(40, 200);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(62, 15);
            lblStudentId.TabIndex = 4;
            lblStudentId.Text = "Student ID";
            
            txtName.Location = new Point(40, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(420, 23);
            txtName.TabIndex = 3;
           
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Full Name";
           
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(110, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Registration";
             
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 8, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 800);
            Controls.Add(pnlCard);
            Name = "FormRegisterStudent";
            Text = "Student Registration";
            WindowState = FormWindowState.Maximized;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            grpIdVerify.ResumeLayout(false);
            grpIdVerify.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.TextBox txtDorm;
        private System.Windows.Forms.Label lblDorm;
        private System.Windows.Forms.GroupBox grpIdVerify;
        private System.Windows.Forms.Button btnUploadBack;
        private System.Windows.Forms.Button btnUploadFront;
        private System.Windows.Forms.Label lblVerifyStatus;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEye; 
    }
}