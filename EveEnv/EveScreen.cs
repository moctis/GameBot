﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace EveEnv
{
    public class EveScreen
    {
        public IntPtr Hwnd { get; set; }

        public string Title { get; set; }

        public EveScreen(IntPtr hwnd, string title)
        {
            Hwnd = hwnd;
            Title = title;
            var windowRect = SystemLib.ScreenCapture.GetWindowRect(Hwnd);
            BasePoint = new AiPoint(windowRect.left, windowRect.top);
            Location = new AiPoint(8, 30);
        }

        protected AiPoint BasePoint { get; set; }
         


        public Image bmp { get; set; }

        public AiPoint Location { get; set; }

        public void SaveToFile(string fileName = null)
        {
            if (fileName == null) fileName = @"D:\" + Title + ".png";
            bmp.Save(fileName, ImageFormat.Png);            
        }

        public void Capture()
        {
            bmp = SystemLib.ScreenCapture.CaptureWindow(Hwnd, Location.X, Location.Y);
        }
    }
}