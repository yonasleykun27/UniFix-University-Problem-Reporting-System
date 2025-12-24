namespace UniFix.Desktop
{
    partial class FormRegisterTeacher
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
            txtPass = new TextBox();
            lblPass = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            txtTeacherId = new TextBox();
            lblTeacherId = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblTitle = new Label();
            pnlCard.SuspendLayout();
            grpIdVerify.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(btnEye);
            pnlCard.Controls.Add(btnBack);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(grpIdVerify);
            pnlCard.Controls.Add(txtPass);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtTeacherId);
            pnlCard.Controls.Add(lblTeacherId);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(150, 20);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 600);
            pnlCard.TabIndex = 0;
            // 
            // btnEye
            // 
            btnEye.Location = new Point(430, 299);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(30, 23);
            btnEye.TabIndex = 21;
            btnEye.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Gray;
            btnBack.Location = new Point(150, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 30);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back to Login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Navy;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(40, 480);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(420, 45);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "REGISTER TEACHER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // grpIdVerify
            // 
            grpIdVerify.BackColor = Color.AliceBlue;
            grpIdVerify.Controls.Add(btnUploadBack);
            grpIdVerify.Controls.Add(btnUploadFront);
            grpIdVerify.Controls.Add(lblVerifyStatus);
            grpIdVerify.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpIdVerify.Location = new Point(40, 350);
            grpIdVerify.Name = "grpIdVerify";
            grpIdVerify.Size = new Size(420, 110);
            grpIdVerify.TabIndex = 18;
            grpIdVerify.TabStop = false;
            grpIdVerify.Text = "Staff ID Verification";
            // 
            // btnUploadBack
            // 
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
            // 
            // btnUploadFront
            // 
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
            // 
            // lblVerifyStatus
            // 
            lblVerifyStatus.AutoSize = true;
            lblVerifyStatus.ForeColor = Color.Red;
            lblVerifyStatus.Location = new Point(20, 75);
            lblVerifyStatus.Name = "lblVerifyStatus";
            lblVerifyStatus.Size = new Size(116, 15);
            lblVerifyStatus.TabIndex = 2;
            lblVerifyStatus.Text = "Status: Not Verified";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(260, 300);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(200, 23);
            txtPass.TabIndex = 9;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(260, 280);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 8;
            lblPass.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(40, 300);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "e.g. tech1001";
            txtUser.Size = new Size(200, 23);
            txtUser.TabIndex = 7;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(40, 280);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Username";
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(40, 220);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.PlaceholderText = "DBU...";
            txtTeacherId.Size = new Size(420, 23);
            txtTeacherId.TabIndex = 5;
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Location = new Point(40, 200);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(45, 15);
            lblTeacherId.TabIndex = 4;
            lblTeacherId.Text = "Staff ID";
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(420, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Full Name";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(110, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(281, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Teacher Registration";
            // 
            // FormRegisterTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 700);
            Controls.Add(pnlCard);
            Name = "FormRegisterTeacher";
            Text = "Teacher Registration";
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
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox grpIdVerify;
        private System.Windows.Forms.Button btnUploadBack;
        private System.Windows.Forms.Button btnUploadFront;
        private System.Windows.Forms.Label lblVerifyStatus;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEye; 
    }
}