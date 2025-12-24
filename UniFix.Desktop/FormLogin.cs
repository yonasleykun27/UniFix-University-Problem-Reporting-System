using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public partial class FormLogin : Form
    {
        private ApiClient _api = new ApiClient();

       
        private int borderRadius = 20;

        public FormLogin()
        {
            InitializeComponent();

         
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
            this.DoubleBuffered = true;

            this.WindowState = FormWindowState.Maximized;

            try
            {
                this.BackgroundImage = Image.FromFile("dbu5.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                this.BackColor = UIHelper.NavbarColor;
            }

     
            AddWindowControls();
       
            ApplyBeautifulStyles();
         
            CenterPanel();
            this.Resize += (s, e) => CenterPanel();
        }

        private void AddWindowControls()
        {
 
            Size btnSize = new Size(45, 30);
            Font btnFont = new Font("Segoe UI", 12, FontStyle.Regular);


            Button btnExit = new Button();
            btnExit.Text = "✕";
            btnExit.ForeColor = Color.White;
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.Font = btnFont;
            btnExit.Size = btnSize;
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(this.Width - 45, 0);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Click += (s, e) => Application.Exit();

            Button btnMax = new Button();
            btnMax.ForeColor = Color.White;
            btnMax.BackColor = Color.Transparent;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnMax.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            btnMax.Size = btnSize;
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Location = new Point(this.Width - 90, 0);
            btnMax.Cursor = Cursors.Hand;

  
            if (this.WindowState == FormWindowState.Maximized)
                btnMax.Text = "❐"; 
            else
                btnMax.Text = "☐";

          
            btnMax.Click += (s, e) =>
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMax.Text = "☐"; 
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    btnMax.Text = "❐";
                }
                CenterPanel();
            };

  
            Button btnMin = new Button();
            btnMin.Text = "—";
            btnMin.ForeColor = Color.White;
            btnMin.BackColor = Color.Transparent;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnMin.Font = btnFont;
            btnMin.Size = btnSize;
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Location = new Point(this.Width - 135, 0);
            btnMin.Cursor = Cursors.Hand;
            btnMin.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

           
            this.Controls.Add(btnExit);
            this.Controls.Add(btnMax);
            this.Controls.Add(btnMin);
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = pnlCard.ClientRectangle;
            rect.Width--; rect.Height--;

        
            Rectangle shadowRect = rect;
            shadowRect.Offset(5, 5);
            using (GraphicsPath shadowPath = GetRoundedPath(shadowRect, borderRadius))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0)))
            {
                e.Graphics.FillPath(shadowBrush, shadowPath);
            }

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(245, 255, 255, 255)))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void ApplyBeautifulStyles()
        {
            if (pnlCard != null)
            {
                pnlCard.BackColor = Color.Transparent;
                pnlCard.Paint += pnlCard_Paint;
            }

            StyleTextBox(txtUser);
            StyleTextBox(txtPass);

      
            UIHelper.SetupPasswordToggle(txtPass, btnEye);

            Color navColor = UIHelper.NavbarColor;

            try
            {
                UIHelper.StyleButton(btnLogin, true);
                int width = btnLogin.Width;
                int height = btnLogin.Height;
                IntPtr rgn = CreateRoundRectRgn(0, 0, width, height, 20, 20);
                btnLogin.Region = Region.FromHrgn(rgn);
            }
            catch { }

            btnLogin.BackColor = navColor;

            try
            {
                UIHelper.StyleButton(btnRegStudent, false);
                btnRegStudent.BackColor = Color.Transparent;
                btnRegStudent.ForeColor = UIHelper.PrimaryColor;
                btnRegStudent.FlatStyle = FlatStyle.Flat;
                btnRegStudent.FlatAppearance.BorderSize = 0;

                UIHelper.StyleButton(btnRegTeacher, false);
                btnRegTeacher.BackColor = Color.Transparent;
                btnRegTeacher.ForeColor = UIHelper.PrimaryColor;
                btnRegTeacher.FlatStyle = FlatStyle.Flat;
                btnRegTeacher.FlatAppearance.BorderSize = 0;
            }
            catch { }

            if (label1 != null)
            {
                label1.ForeColor = navColor;
                label1.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            }
        }

        private void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.WhiteSmoke;
            txt.Font = new Font("Segoe UI", 12);
            txt.AutoSize = false;
            txt.Height = 30;
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter credentials.");
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Checking...";

            try
            {
                User loggedUser = await _api.LoginAsync(user, pass);

                if (loggedUser != null)
                {
                    MessageBox.Show($"Welcome {loggedUser.FullName}!");
                    this.Hide();

                    if (loggedUser.Role == "Student") new FormStudentDashboard(loggedUser).Show();
                    else if (loggedUser.Role == "Teacher") new FormTeacherDashboard(loggedUser).Show();
                    else if (loggedUser.Role == "Admin") new FormAdminDashboard(loggedUser).Show();
                    else if (loggedUser.Role == "Solver") new FormSolverDashboard(loggedUser).Show();
                }
                else
                {
                    btnLogin.Text = "LOGIN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "LOGIN";
            }
        }

        private void BtnRegStudent_Click(object sender, EventArgs e)
        {
            new FormRegisterStudent().ShowDialog();
        }

        private void BtnRegTeacher_Click(object sender, EventArgs e)
        {
            new FormRegisterTeacher().ShowDialog();
        }


        private void btnEye_Click(object sender, EventArgs e) { }
    }
}