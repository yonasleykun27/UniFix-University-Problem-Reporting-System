using System;
using System.Drawing;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormRegisterTeacher : Form
    {
        private ApiClient _api = new ApiClient();
        private bool _isIdVerified = false;

        public FormRegisterTeacher()
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
                UIHelper.StyleTextBox(txtTeacherId);
                UIHelper.StyleTextBox(txtUser);
                UIHelper.StyleTextBox(txtPass);

                lblTitle.ForeColor = UIHelper.PrimaryColor;
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
                lblVerifyStatus.Text = "Status: Verified!";
                lblVerifyStatus.ForeColor = Color.Green;
                MessageBox.Show("Staff ID Verified Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            
            if (!_isIdVerified)
            {
                MessageBox.Show("Please verify your Staff ID first.", "Security Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtTeacherId.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

          
            if (!txtUser.Text.StartsWith("tech"))
            {
                MessageBox.Show("Teacher username must start with 'tech' (e.g., tech1050).");
                return;
            }

          
            var newUser = new User
            {
                FullName = txtName.Text,
                UserIdCard = txtTeacherId.Text,
                Username = txtUser.Text,
                Password = txtPass.Text,
                Role = "Teacher",
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
                    MessageBox.Show("Teacher Account Created! Please Login.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration Failed. Username might exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnRegister.Enabled = true;
                btnRegister.Text = "REGISTER TEACHER";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}