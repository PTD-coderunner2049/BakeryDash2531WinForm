using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolbergBakery2531._utils
{
    public static class UIUtils
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                // You can choose the format (Jpeg, Png, etc.)
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static async Task ShowToast(string message, string title = "BakeryDash", int durationInMs = 2200, bool isSuccess = true)
        {
            // --- Artisan Theme Colors ---
            // Background: Warm Chocolate Brown sampled from the image
            Color backColor = Color.FromArgb(89, 54, 41);
            // Text: Soft Cream / Marble color
            Color textColor = Color.FromArgb(242, 230, 218);
            // Accent: Terracotta (Success) or Deep Clay (Error)
            Color accentColor = isSuccess ? Color.FromArgb(184, 115, 81) : Color.FromArgb(139, 0, 0);

            using (Form toast = new Form
            {
                Size = new Size(380, 90), // Slightly wider for the thicker font
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                ControlBox = false,
                ShowInTaskbar = false,
                TopMost = true,
                BackColor = backColor,
                Opacity = 0.75 // 50% Transparency as requested
            })
            {
                // Left Accent Bar
                Panel accentBar = new Panel
                {
                    Dock = DockStyle.Left,
                    Width = 8,
                    BackColor = accentColor
                };

                // Title Label - Using Trebuchet MS for a "fuller" look
                Label lblTitle = new Label
                {
                    Text = title.ToUpper(),
                    ForeColor = accentColor,
                    Font = new Font("Trebuchet MS", 10, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    Height = 30,
                    Padding = new Padding(12, 8, 0, 0),
                    AutoSize = false
                };

                // Message Label
                Label lblMsg = new Label
                {
                    Text = message,
                    ForeColor = textColor,
                    Font = new Font("Verdana", 11, FontStyle.Regular), // Verdana is very "filling" and smooth
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(12, 0, 10, 5)
                };

                toast.Controls.Add(lblMsg);
                toast.Controls.Add(lblTitle);
                toast.Controls.Add(accentBar);

                toast.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, toast.Width, toast.Height, 20, 20));
                toast.Show();
                // Keep it on screen
                await Task.Delay(durationInMs);

                // Simple Fade Out effect before closing
                for (double i = 0.5; i > 0; i -= 0.05)
                {
                    toast.Opacity = i;
                    await Task.Delay(25);
                }

                toast.Close();
            }
        }
    }
}