using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace SystemLib
{
    public static class Mouse
    {
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */

        public static void MoveTo(int x, int y)
        {
            User32.SetCursorPos(x, y);
        }

        public static void Click()
        {
            User32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            User32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void Click(int x, int y)
        {
            MoveTo(x, y);
            Thread.Sleep(100);
            Click();
        }

        public static void Click(this Point p)
        {
            Click(p.X, p.Y);
        }

        public static void DoubleClick()
        {
            User32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            User32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(100);
            User32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            User32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); 
        }

        public static void RightCLick()
        {
            User32.mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            User32.mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0); 
        }

        public static void DragDrop(Point p1, Point p2, int delay)
        {
            Thread.Sleep(100);
            MoveTo(p1);
            Thread.Sleep(delay);
            User32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(100);
            MoveTo(p2);
            Thread.Sleep(delay);
            User32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private static void MoveTo(Point p)
        {
            MoveTo(p.X, p.Y);
        }
    }
}
