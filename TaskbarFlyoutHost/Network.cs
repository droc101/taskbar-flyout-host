using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    public partial class Network : Form
    {
        public Network()
        {
            InitializeComponent();
            Rectangle stRect = WinAPI.GetTrayRectangle();
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width - 10, stRect.Top - 10 - Height);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Round.AnimateHide(this);
        }

        private void navigationButton1_Click_1(object sender, EventArgs e)
        {
            var f = Round.flyout;
            Round.AnimateShow(f);
            Round.AnimateHide(this);
        }

        public bool IsConnectedToInternet()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        enum IType
        {
            Ethernet,
            Wifi,
            Modem,
            Unknown
        }

        IType determineAdapterType(NetworkInterface adapter)
        {
            int[] eth = new int[] { 6, 26, 69, 62, 117 };
            int[] wfi = new int[] { 71 };
            int[] mod = new int[] { 48 };
            if (eth.Contains((int)adapter.NetworkInterfaceType))
            {
                return IType.Ethernet;
            }
            else if (wfi.Contains((int)adapter.NetworkInterfaceType))
            {
                return IType.Wifi;
            }
            else if (mod.Contains((int)adapter.NetworkInterfaceType))
            {
                return IType.Modem;
            }
            return IType.Unknown;
        }

        public NetworkInterface getAdapter()
        {
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in interfaces.Where(x => x.OperationalStatus == OperationalStatus.Up))
            {
                if (adapter.Name.ToLower() == "ethernet" || adapter.Name.ToLower() == "wi-fi")
                {
                    var props = adapter.GetIPProperties();
                    var result = props.UnicastAddresses.FirstOrDefault(x => x.Address.AddressFamily == AddressFamily.InterNetwork);
                    if (result != null)
                    {
                        return adapter;
                    }
                }
            }
            return NetworkInterface.GetAllNetworkInterfaces().First();
        }


        private void Network_Load(object sender, EventArgs e)
        {
        }

        private void aeroLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Properties.Settings.Default.openInSettings)
            {
                System.Diagnostics.Process.Start("ms-settings:network");
            }
            else
            {
                System.Diagnostics.Process.Start("explorer", "shell:::{8E908FC9-BECC-40f6-915B-F4CA0E70D03D}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                var inf = getAdapter();
                name.Text = inf.Name;
                desc.Text = "Description: " + inf.Description;
                switch (determineAdapterType(inf))
                {
                    case IType.Ethernet:
                        type.Text = "Type: Ethernet";
                        Round.GetHandler().UpdateNetworkTrayIcon("Ethernet (" + inf.Name + ") - Connected", Properties.Resources.ethernet);
                        break;
                    case IType.Wifi:
                        type.Text = "Type: WiFi";
                        Round.GetHandler().UpdateNetworkTrayIcon("WiFi (" + inf.Name + ") - Connected", Properties.Resources.wifi);
                        break;
                    case IType.Modem:
                        Round.GetHandler().UpdateNetworkTrayIcon("Modem (" + inf.Name + ") - Connected", Properties.Resources.modem);
                        type.Text = "Type: Modem";
                        break;
                    default:
                        Round.GetHandler().UpdateNetworkTrayIcon("Network (" + inf.Name + ") - Connected", Properties.Resources.globe);
                        type.Text = "Type: Unknown";
                        break;
                }
            }
            else
            {
                Round.GetHandler().UpdateNetworkTrayIcon("Not Connected - Connected", Properties.Resources.neterr);
                name.Text = "Not Connected";
                desc.Text = "";
                type.Text = "";
            }
        }
    }
}
