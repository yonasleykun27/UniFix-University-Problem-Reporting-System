namespace UniFix.Desktop
{
    partial class FormAddStaff
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.cboJobTitle = new System.Windows.Forms.ComboBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
          
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Staff";
         
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.cboJobTitle);
            this.pnlContent.Controls.Add(this.lblJobTitle);
            this.pnlContent.Controls.Add(this.txtPass);
            this.pnlContent.Controls.Add(this.lblPass);
            this.pnlContent.Controls.Add(this.txtUser);
            this.pnlContent.Controls.Add(this.lblUser);
            this.pnlContent.Controls.Add(this.txtStaffId);
            this.pnlContent.Controls.Add(this.lblStaffId);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Location = new System.Drawing.Point(40, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(350, 450);
            this.pnlContent.TabIndex = 1;
           
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(25, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
         
            this.txtName.Location = new System.Drawing.Point(25, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 23);
            this.txtName.TabIndex = 1;
          
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffId.Location = new System.Drawing.Point(25, 80);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(49, 15);
            this.lblStaffId.TabIndex = 2;
            this.lblStaffId.Text = "Staff ID";
           
            this.txtStaffId.Location = new System.Drawing.Point(25, 100);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(300, 23);
            this.txtStaffId.TabIndex = 3;
            
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(25, 135);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 15);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username";
           
            this.txtUser.Location = new System.Drawing.Point(25, 155);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 23);
            this.txtUser.TabIndex = 5;
          
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPass.Location = new System.Drawing.Point(25, 190);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 15);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
          
            this.txtPass.Location = new System.Drawing.Point(25, 210);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(300, 23);
            this.txtPass.TabIndex = 7;
          
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJobTitle.Location = new System.Drawing.Point(25, 245);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(56, 15);
            this.lblJobTitle.TabIndex = 8;
            this.lblJobTitle.Text = "Job Title";
            
            this.cboJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobTitle.FormattingEnabled = true;
            this.cboJobTitle.Location = new System.Drawing.Point(25, 265);
            this.cboJobTitle.Name = "cboJobTitle";
            this.cboJobTitle.Size = new System.Drawing.Size(300, 23);
            this.cboJobTitle.TabIndex = 9;
          
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE STAFF";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
           
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(25, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(300, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(430, 560);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Staff";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.ComboBox cboJobTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}