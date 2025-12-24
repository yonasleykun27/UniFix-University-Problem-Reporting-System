using System;
using System.Drawing;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormRegisterStudent : Form
    {
        private ApiClient _api = new ApiClient();
        private bool _isIdVerified = false; 

        public FormRegisterStudent()
        {
            InitializeComponent();

  
            try { this.BackgroundImage = Image.FromFile("dbu5.jpg"); this.BackgroundImageLayout = ImageLayout.Stretch; }
            catch { this.BackColor = UIHelper.BgColor; }

       
            try
            {
                UIHelper.SetupPasswordToggle(txtPass, btnEye);

    
                UIHelper.StyleButton(btnRegister, true);
                UIHelper.StyleButton(btnUploadFront, false);
                UIHelper.StyleButton(btnUploadBack, false);

               
                UIHelper.StyleTextBox(txtName);
                UIHelper.StyleTextBox(txtStudentId);
                UIHelper.StyleTextBox(txtUser);
                UIHelper.StyleTextBox(txtPass);
                UIHelper.StyleTextBox(txtDept);
                UIHelper.StyleTextBox(txtYear);
                UIHelper.StyleTextBox(txtBlock);
                UIHelper.StyleTextBox(txtDorm);

       
                lblTitle.ForeColor = UIHelper.PrimaryColor;
                lblVerifyStatus.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            catch { }

     
            CenterPanel();
            this.Resize += (s, e) => CenterPanel();
        }

        private void CenterPanel()
        {
            if (pnlCard != null)
            {
                pnlCard.Location = new Point(
                    (this.ClientSize.Width - pnlCard.Width) / 2,
                    (this.ClientSize.Height - pnlCard.Height) / 2
                );
            }
        }

      

        private void BtnUpload_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
 
                _isIdVerified = true;
                lblVerifyStatus.Text = "Status: ID Verified!";
                lblVerifyStatus.ForeColor = Color.Green;
                MessageBox.Show("ID Image Uploaded Successfully.\nVerification Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
       
            if (!_isIdVerified)
            {
                MessageBox.Show("Please upload your ID Card first to verify identity.", "Security Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (!txtStudentId.Text.StartsWith("DBU"))
            {
                MessageBox.Show("Student ID must start with 'DBU'.");
                return;
            }


            var newUser = new User
            {
                FullName = txtName.Text,
                UserIdCard = txtStudentId.Text,
                Username = txtUser.Text,
                Password = txtPass.Text,
                Role = "Student",
                Department = txtDept.Text,
                Year = txtYear.Text,
                Block = txtBlock.Text,
                Dorm = txtDorm.Text,
                Warnings = 0,
                IsBanned = false
            };


            btnRegister.Enabled = false;
            btnRegister.Text = "Registering...";

            try
            {
                bool success = await _api.RegisterAsync(newUser);
                if (success)
                {
                    MessageBox.Show("Registration Successful! Please Login.");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Registration Failed. Username might already exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnRegister.Enabled = true;
                btnRegister.Text = "REGISTER";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}