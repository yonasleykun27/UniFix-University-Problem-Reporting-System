namespace UniFix.Desktop
{
    partial class FormLogin
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnEye = new System.Windows.Forms.Button();
            this.btnRegTeacher = new System.Windows.Forms.Button();
            this.btnRegStudent = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
          
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.btnEye);
            this.pnlCard.Controls.Add(this.btnRegTeacher);
            this.pnlCard.Controls.Add(this.btnRegStudent);
            this.pnlCard.Controls.Add(this.lblRegister);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.txtPass);
            this.pnlCard.Controls.Add(this.lblPass);
            this.pnlCard.Controls.Add(this.txtUser);
            this.pnlCard.Controls.Add(this.lblUser);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Location = new System.Drawing.Point(200, 50);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(400, 500);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
          
            this.btnEye.Location = new System.Drawing.Point(330, 196);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(30, 29);
            this.btnEye.TabIndex = 9;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
           
           
            this.btnRegTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegTeacher.ForeColor = System.Drawing.Color.Navy;
            this.btnRegTeacher.Location = new System.Drawing.Point(40, 410);
            this.btnRegTeacher.Name = "btnRegTeacher";
            this.btnRegTeacher.Size = new System.Drawing.Size(320, 35);
            this.btnRegTeacher.TabIndex = 8;
            this.btnRegTeacher.Text = "Register Teacher";
            this.btnRegTeacher.UseVisualStyleBackColor = true;
            this.btnRegTeacher.Click += new System.EventHandler(this.BtnRegTeacher_Click);
            
            this.btnRegStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegStudent.ForeColor = System.Drawing.Color.Navy;
            this.btnRegStudent.Location = new System.Drawing.Point(40, 360);
            this.btnRegStudent.Name = "btnRegStudent";
            this.btnRegStudent.Size = new System.Drawing.Size(320, 35);
            this.btnRegStudent.TabIndex = 7;
            this.btnRegStudent.Text = "Student Registration";
            this.btnRegStudent.UseVisualStyleBackColor = true;
            this.btnRegStudent.Click += new System.EventHandler(this.BtnRegStudent_Click);
            
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(130, 330);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(131, 15);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Don't have an account?";
           
            this.btnLogin.BackColor = System.Drawing.Color.Navy;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
           
           
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.Location = new System.Drawing.Point(40, 195);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(320, 29);
            this.txtPass.TabIndex = 4;
         
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.Gray;
            this.lblPass.Location = new System.Drawing.Point(40, 170);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(57, 15);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.Location = new System.Drawing.Point(40, 125);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(320, 29);
            this.txtUser.TabIndex = 2;
          
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(40, 100);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
           
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "UniFix Login";
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlCard);
            this.Name = "FormLogin";
            this.Text = "UniFix Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegStudent;
        private System.Windows.Forms.Button btnRegTeacher;
        private System.Windows.Forms.Button btnEye;
    }
}