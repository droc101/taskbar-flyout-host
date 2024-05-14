using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
            Rectangle stRect = WinAPI.GetTrayRectangle();
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width - 10, stRect.Top - 10 - Height);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Round.AnimateHide(this);
        }

        private void navigationButton1_Click(object sender, EventArgs e)
        {
            var f = Round.flyout;
            Round.AnimateShow(f);
            Round.AnimateHide(this);
        }

        private void aeroLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Properties.Settings.Default.openInSettings)
            {
                System.Diagnostics.Process.Start("ms-settings:dateandtime");
            } else
            {
                System.Diagnostics.Process.Start("explorer", "shell:::{E2E7934B-DCE5-43C4-9576-7FE4F75E7480}");
            }
        }
    }
}
