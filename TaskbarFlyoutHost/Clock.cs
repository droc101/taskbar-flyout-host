using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TaskbarFlyoutHost.Properties;

namespace uxlib
{
    public partial class Clock : UserControl
    {

        Bitmap clock = new Bitmap(256, 256);

        Color dtc = SystemColors.ControlDark;

        bool ovrt = false;
        public DateTime ovr_time;

        [Description("Detail color for the clock face"), Category("Colors")]
        public Color DetailColor
        {
            get => dtc;
            set => dtc = value;
        }

        [Description("Override the current time with a custom one"), Category("Clock")]
        public bool UseCustomTime
        {
            get => ovrt;
            set => ovrt = value;
        }

        Image outline = Resources.clockOutline;

        public Clock()
        {
            InitializeComponent();
            BackColor = Color.Transparent;
        }

        private void Clock_Load(object sender, EventArgs e)
        {
        }

        static float map(float source, float sourceFrom, float sourceTo, float targetFrom, float targetTo)
        {
            return targetFrom + (source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom);
        }

        public static Point trg(float angle, float len, Point center)
        {
            return new Point((int)(Math.Cos(angle) * len) + center.X, (int)(Math.Sin(angle) * len) + center.Y);
        }

        public static Point getHand(float val, float max, float len)
        {
            float rad = (float)(map(val, 0.0f, max, 0.0f, (float)(Math.PI*2f)));
            return trg(rad - (float)(Math.PI / 2f), len, new Point(128, 128));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (ovrt)
            {
                now = ovr_time;
            }
            Graphics graphics = Graphics.FromImage(clock);
            graphics.Clear(BackColor);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            Pen fg = new Pen(ForeColor);
            Pen SH = new Pen(dtc);
            graphics.DrawImage(outline, new Rectangle(new Point(5, 5), clock.Size - new Size(11, 11)));
            int ix = 12;
            for (int i = 0; i < 60; i++)
            {
                Point DP = getHand(i, 60f, 100f);
                if (i % 5 == 0)
                {
                    Point TP = getHand(i, 60f, 85f);
                    graphics.FillEllipse(fg.Brush, new Rectangle(new Point(DP.X - (4), DP.Y - (4)), new Size(8, 8)));
                    if (ix == 12) { ix = 0; }
                    ix++;
                }
                else
                {
                    graphics.FillEllipse(SH.Brush, new Rectangle(new Point(DP.X - (3), DP.Y - (3)), new Size(6, 6)));
                }
            }
            Point SP = getHand((float)now.Millisecond + (now.Second * 1000), 60000f, 80f);
            graphics.DrawLine(SH, new Point(128, 128), SP);
            Point MP = getHand((float)now.Second + (now.Minute * 60), 3600f, 90f);
            graphics.DrawLine(fg, new Point(128, 128), MP);
            Point HP = getHand((float)now.Minute + ((now.Hour%12) * 60), 720f, 70f);
            graphics.DrawLine(fg, new Point(128, 128), HP);
            graphics.FillEllipse(fg.Brush, new Rectangle(new Point(124, 124), new Size(8, 8)));
            pictureBox1.Image = clock;
        }
    }
}
