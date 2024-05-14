using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    public partial class OneFlyout : Form
    {
        public OneFlyout()
        {
            InitializeComponent();
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            aeroProgressBar1.Value = (int)defaultPlaybackDevice.Volume;
            Rectangle stRect = WinAPI.GetTrayRectangle();
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width - 10, stRect.Top - 10 - Height);
        }

        private void OneFlyout_Deactivate(object sender, EventArgs e)
        {
            Round.AnimateHide(this);
        }

        private void OneFlyout_Load(object sender, EventArgs e)
        {
        }

        private void aeroLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void commandLink1_Click(object sender, EventArgs e)
        {
            Form1 f = Round.volFlyout;
            Round.AnimateShow(f);
            Round.AnimateHide(this);
        }

        private void commandLink2_Click(object sender, EventArgs e)
        {
            Network network = Round.netFlyout;
            Round.AnimateShow(network);
            Round.AnimateHide(this);
        }

        private void commandLink3_Click(object sender, EventArgs e)
        {
            Time time = Round.timeFlyout;
            Round.AnimateShow(time);
            Round.AnimateHide(this);
        }

        private void aeroLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Options op = Round.optFlyout;
            Round.AnimateShow(op);
            Round.AnimateHide(this);
        }
    }
}
