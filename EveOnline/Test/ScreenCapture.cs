using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveOnline.Test
{
    using System.Diagnostics;
    using System.Drawing.Imaging;

    public partial class ScreenCapture : UserControl
    {
        public ScreenCapture()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            IntPtr hwnd = SystemLib.User32.FindWindowByCaption(IntPtr.Zero, "EVE - MoctisMining");
            if (hwnd == IntPtr.Zero) return;
            var image = SystemLib.ScreenCapture.CaptureWindow(hwnd);
            //image.Save(@"D:\test.png", ImageFormat.Png);
            this.pictureBox1.Image = image;
        }
    }
}
