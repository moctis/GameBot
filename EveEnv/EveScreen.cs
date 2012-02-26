using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace EveEnv
{
    public class EveScreen
    {
        public EveScreen(Process process)
        {
            _process = process;

            var windowRect = SystemLib.ScreenCapture.GetWindowRect(_process.MainWindowHandle);
            BasePoint = new AiPoint(windowRect.left, windowRect.top);
            Location = new AiPoint(8, 30);
        }

        protected AiPoint BasePoint { get; set; }

        private Process _process;


        public Image bmp { get; set; }

        public AiPoint Location { get; set; }

        public void SaveToFile(string fileName = null)
        {
            if (fileName == null) fileName = @"D:\" + _process.MainWindowTitle + ".png";
            bmp.Save(fileName, ImageFormat.Png);            
        }

        public void Capture()
        {
            bmp = SystemLib.ScreenCapture.CaptureWindow(_process.MainWindowHandle, Location.X, Location.Y);
        }
    }
}