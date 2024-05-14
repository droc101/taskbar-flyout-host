using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskbarFlyoutHost
{
    internal static class Round
    {

        internal enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_INVALID_STATE = 4
        }

        internal enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public static OneFlyout flyout = new OneFlyout();
        public static Form1 volFlyout = new Form1();
        public static Network netFlyout= new Network();
        public static Time timeFlyout = new Time();
        public static Options optFlyout = new Options();

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33,
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
            DWMWA_MICA_EFFECT = 1029
        }
        const int DWMWCP_DEFAULT = 0;
        const int DWMWCP_DONOTROUND = 1;
        const int DWMWCP_ROUND = 2;
        const int DWMWCP_ROUNDSMALL = 3;
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern long DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref int pvAttribute,
                                                         uint cbAttribute);

        public static void RoundWindow(Form window)
        {
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWMWCP_ROUND;
            DwmSetWindowAttribute(window.Handle, attribute, ref preference, sizeof(uint));
            window.BackColor = SystemColors.Control;
            var accent = new AccentPolicy { AccentState = AccentState.ACCENT_DISABLED };
            if (Properties.Settings.Default.glass)
            {
                window.BackColor = SystemColors.AppWorkspace; // looks really bad with the default back color
                accent = new AccentPolicy { AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND };
            }
            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            var data = new WindowCompositionAttributeData
            {
                Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                SizeOfData = accentStructSize,
                Data = accentPtr
            };
            SetWindowCompositionAttribute(window.Handle, ref data);
            Marshal.FreeHGlobal(accentPtr);
        }

        public static void AnimateShow(Form window)
        {
            window.ShowInTaskbar = false;
            window.TopMost = true;
            RoundWindow(window);
            window.Location = new Point(window.Location.X, Screen.PrimaryScreen.Bounds.Height);
            window.Show();
            Rectangle stRect = WinAPI.GetTrayRectangle();
            if (Properties.Settings.Default.animationType == 1) // Fade only
            {
                window.Location = new Point(window.Location.X, stRect.Top - 10 - window.Height);
            }
            if (Properties.Settings.Default.doAnimation)
            {
                
                for (int y = Screen.PrimaryScreen.Bounds.Height; y > stRect.Top - 10 - window.Height; y -= window.Height / 20)
                {
                    if (Properties.Settings.Default.animationType == 1 || Properties.Settings.Default.animationType == 2)
                    {
                        window.Opacity = (double)Remap(y, Screen.PrimaryScreen.Bounds.Height, stRect.Top - 10 - window.Height, 0.0f, 1.0f);
                    }
                    if (Properties.Settings.Default.animationType != 1)
                    {
                        window.Location = new Point(window.Location.X, y);
                    }
                    
                    window.Refresh();
                }
                window.Opacity = 1.0;
            }
            
            
            window.Location = new Point(window.Location.X, stRect.Top - 10 - window.Height);
            
            window.Activate();
            window.Focus();
        }

        public static void FakeShow(Form window)
        {
            window.ShowInTaskbar = false;
            window.TopMost = true;
            window.Show();
            window.Activate();
            window.Hide();
        }


        public static float Remap(float value, float InputA, float InputB, float OutputA, float OutputB)
        {
            return ((float)(value)- (float)(InputA))/ ((float)(InputB)- (float)(InputA))* ((float)(OutputB)- (float)(OutputA))+ (float)(OutputA);
        }

        public static HandlerForm GetHandler()
        {
            return (HandlerForm)Application.OpenForms[0];
        }

        public static void AnimateHide(Form window)
        {
            if (Properties.Settings.Default.doAnimation)
            {
                Rectangle stRect = WinAPI.GetTrayRectangle();
                if (Properties.Settings.Default.animationType == 1) // Fade only
                {
                    window.Location = new Point(window.Location.X, Screen.PrimaryScreen.Bounds.Height);
                }
                for (int y = stRect.Top - 10 - window.Height; y < Screen.PrimaryScreen.Bounds.Height; y += window.Height / 20)
                {
                    if (Properties.Settings.Default.animationType == 1 || Properties.Settings.Default.animationType == 2)
                    {
                        window.Opacity = (double)Remap(y, Screen.PrimaryScreen.Bounds.Height, stRect.Top - 10 - window.Height, 1.0f, 0.0f);
                    }
                    //
                    if (Properties.Settings.Default.animationType != 1)
                    {
                        window.Location = new Point(window.Location.X, y);
                    }
                    window.Refresh();
                }
                window.Location = new Point(window.Location.X, Screen.PrimaryScreen.Bounds.Height);
            }
            window.Hide();
        }
    }
}
