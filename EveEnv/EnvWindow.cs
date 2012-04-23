using System;
using System.Drawing;
using System.Threading;
using SystemLib;

namespace EveEnv
{
    public class EnvWindow
    {
        public IntPtr Hwnd { get; set; }
        public string Title { get; set; }

        public EnvWindow(IntPtr hwnd, string title)
        {
            Hwnd = hwnd;
            Title = title;
        }

        public bool BringToFront()
        {
            int window;
            User32.SetForegroundWindow(Hwnd);
            Thread.Sleep(100);
            window = User32.GetForegroundWindow();
            return (window == (int) Hwnd);
        }

        public User32.RECT GetWindowRect(IntPtr hwnd)
        {
            return ScreenCapture.GetWindowRect(hwnd);
        }

        public Image CaptureWindow()
        {
            return ScreenCapture.CaptureWindow(Hwnd);
        }
    }
}