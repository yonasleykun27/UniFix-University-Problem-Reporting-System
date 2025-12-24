using System.Drawing;
using System.Windows.Forms;

namespace UniFix.Desktop
{
    public static class UIHelper
    {
     
        public static Color BgColor = Color.FromArgb(5, 10, 60);

        public static Color NavbarColor = Color.FromArgb(5, 10, 60);

        public static Color HeaderTextColor = Color.White;

        public static Color WarningColor = Color.Gold;

        public static Color TextColor = Color.FromArgb(30, 30, 30);

        public static Color TextColorOnDark = Color.White;

        public static Color PrimaryColor = Color.FromArgb(0, 0, 139);

        public static Color AccentColor = Color.Gold;

        public static Color CardBgColor = Color.White;

    
        public static void SetupPasswordToggle(TextBox txtPass, Button btnToggle)
        {
            btnToggle.Text = "👁";
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.BackColor = Color.White;
            btnToggle.ForeColor = Color.Gray;
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.Font = new Font("Segoe UI", 12);

            
            btnToggle.Click += (s, e) =>
            {
                if (txtPass.PasswordChar == '*')
                {
                    txtPass.PasswordChar = '\0'; 
                    btnToggle.ForeColor = PrimaryColor;
                }
                else
                {
                    txtPass.PasswordChar = '*'; 
                    btnToggle.ForeColor = Color.Gray;
                }
            };
        }

        public static void StyleButton(Button btn, bool isPrimary = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Height = 40;
            btn.Region = null;

            if (isPrimary)
            {
                btn.BackColor = PrimaryColor; 
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = PrimaryColor;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = PrimaryColor;
            }
        }

        public static void StyleDangerButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Color.Crimson; 
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.Font = new Font("Segoe UI", 11);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
            txt.ForeColor = TextColor;
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = CardBgColor;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

     
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor; 
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersHeight = 45;

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = TextColor;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 255); 
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 35;
        }
    }
}