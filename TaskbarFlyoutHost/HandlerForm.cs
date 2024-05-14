using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    public partial class HandlerForm : Form
    {
        public HandlerForm()
        {
            InitializeComponent();
        }

        public void UpdateNetworkTrayIcon(string text, Icon icon)
        {
            notifyIcon3.Text = text;
            notifyIcon3.Icon = icon;
        }

        public void UpdateVolumeTrayIcon(string text, Icon icon)
        {
            notifyIcon2.Text = text;
            notifyIcon2.Icon= icon;
        }

        private void HandlerForm_Load(object sender, EventArgs e)
        {
            
            WindowState= FormWindowState.Minimized;
            Hide();
            var f = Round.flyout;
            Round.FakeShow(f);
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            var f = Round.flyout;
            Round.AnimateShow(f);
        }

        private void HandlerForm_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon2_Click(object sender, EventArgs e)
        {
            var v = Round.volFlyout;
            Round.AnimateShow(v);
        }

        private void notifyIcon3_Click(object sender, EventArgs e)
        {
            Network n = Round.netFlyout;
            Round.AnimateShow(n);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon2.Visible = Properties.Settings.Default.trayVolume;
            notifyIcon3.Visible = Properties.Settings.Default.trayNetwork;
        }
    }
}
