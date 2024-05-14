using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    

        public partial class Form1 : Form
    {

        const string mute = "";
        const string volProg = "";
        int volProgSize = 100 / volProg.Length;

        PeakObserver po = new PeakObserver();

        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        public Form1()
        {
            InitializeComponent();
            Rectangle stRect = WinAPI.GetTrayRectangle();
            tbar1.Value = (int)defaultPlaybackDevice.Volume;
            defaultPlaybackDevice.PeakValueChanged.Subscribe(po);
            label1.Text = "Volume - " + defaultPlaybackDevice.Name;
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
            if (e.Button == MouseButtons.Left)
            {
                Process.Start("SndVol.exe");
            }
        }

        private void tbar1_ValueChanged(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = tbar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Mute(!defaultPlaybackDevice.IsMuted);
        }

        private void soundSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.openInSettings)
            {
                Process.Start("ms-settings:sound");
            }
            else
            {
                Process.Start("explorer", "shell:::{F2DDFC82-8F12-4CDD-B7DC-D4FE1425AA4D}");
            }
        }

        private void volumeMixerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("SndVol.exe");
        }

        private void systemSoundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "C:\\WINDOWS\\system32\\shell32.dll,Control_RunDLL C:\\WINDOWS\\System32\\mmsys.cpl ,2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            verticalAeroProgressBar1.Value = (int)(po.last);
            if (defaultPlaybackDevice.IsMuted)
            {
                button1.Text = mute;
                Round.GetHandler().UpdateVolumeTrayIcon(defaultPlaybackDevice.Name + " (Muted)", Properties.Resources.mute);
            } else
            {
                int pos = (int)Math.Round(Round.Remap((float)defaultPlaybackDevice.Volume, 0f, 100f, 0f, 3f));
                string icon = volProg[pos].ToString();
                button1.Text = icon;
                Icon ic = Properties.Resources.vol0;
                if (pos == 0)
                {
                    ic = Properties.Resources.vol0;
                } else if (pos == 1)
                {
                    ic = Properties.Resources.vol1;
                } else if (pos == 2)
                {
                    ic = Properties.Resources.vol2;
                }
                else if (pos == 3)
                {
                    ic = Properties.Resources.vol3;
                }
                Round.GetHandler().UpdateVolumeTrayIcon(defaultPlaybackDevice.Name + " (" + defaultPlaybackDevice.Volume.ToString() + "%)", ic);
            }
        }

        private void tbar1_Scroll(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = tbar1.Value;
        }
    }

    public class PeakObserver : IObserver<AudioSwitcher.AudioApi.DevicePeakValueChangedArgs>
    {
        public double last;

        public void OnCompleted()
        {

        }

        public void OnError(Exception error)
        {

        }

        public void OnNext(DevicePeakValueChangedArgs value)
        {
            last = value.PeakValue;
        }
    }
}
