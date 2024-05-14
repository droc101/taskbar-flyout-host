using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    public partial class Options : Form
    {
        public Options()
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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.doAnimation;
            trayNetwork.Checked = Properties.Settings.Default.trayNetwork;
            trayVol.Checked = Properties.Settings.Default.trayVolume;
            animType.SelectedIndex = Properties.Settings.Default.animationType;
            if (Properties.Settings.Default.openInSettings)
            {
                openIn.SelectedIndex = 0;
            } else
            {
                openIn.SelectedIndex = 1;
            }
            checkBox2.Checked = Properties.Settings.Default.glass;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.doAnimation = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void trayVol_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.trayVolume = trayVol.Checked;
            Properties.Settings.Default.Save();
        }

        private void trayNetwork_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.trayNetwork= trayNetwork.Checked;
            Properties.Settings.Default.Save();
        }

        private void animType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.animationType= animType.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void openIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.openInSettings = openIn.SelectedIndex == 0;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.glass = checkBox2.Checked;
            Properties.Settings.Default.Save();
        }

        private void commandLink2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void commandLink1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
