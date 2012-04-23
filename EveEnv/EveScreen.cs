using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace EveEnv
{
    public class EveScreen
    {
        public EnvWindow Window { get; set; }  

        public EveScreen(EnvWindow window)
        {
            Window = window;
            var windowRect = window.GetWindowRect(window.Hwnd);
            BasePoint = new AiPoint(windowRect.left, windowRect.top);
            //Location = new AiPoint(8, 30);
            Location = new AiPoint(0, 0);
        }

        protected AiPoint BasePoint { get; set; }
        public Image bmp { get; set; }
        public AiPoint Location { get; set; }

        public void SaveToFile(string fileName = null)
        {
            if (fileName == null) fileName = @"D:\" + Window.Title + ".png";
            bmp.Save(fileName, ImageFormat.Png);            
        }

        public void Capture()
        {
            bmp = Window.CaptureWindow();
            InvokeOnCapture(EventArgs.Empty);
        }

        public event EventHandler OnCapture;

        public void InvokeOnCapture(EventArgs e)
        {
            EventHandler handler = OnCapture;
            if (handler != null) handler(this, e);
        }
    }
}