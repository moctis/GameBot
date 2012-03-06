using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemLib
{
    public class WindowsHelper
    {
        	public const int
			SwShow = 5,
			SwRestore = 9;

        /// <summary>
		/// Helper function to force a window into foreground, will
		/// even work if our process is not the same as the other windows.
		/// We will try to get the others thread input process and
		/// attach it to our thread for setting the window to the foreground.
		/// </summary>
		public static bool ForceForegroundWindow(int hWnd)
		{
			int foregroundWnd = User32.GetForegroundWindow();
			// Do nothing if already in foreground.
			if (hWnd == foregroundWnd)
				return true;

			// First need to get the thread responsible for this window,
			// and the thread for the foreground window.
			int ret = 0,
				threadID1 = User32.GetWindowThreadProcessId(foregroundWnd, 0),
				threadID2 = User32.GetWindowThreadProcessId(hWnd, 0);

			// By sharing input state, threads share their concept of
			// the active window.
			if (threadID1 != threadID2)
			{
				User32.AttachThreadInput(threadID1, threadID2, 1);//true
				ret = User32.SetForegroundWindow((IntPtr)hWnd);
				User32.AttachThreadInput(threadID1, threadID2, 0);//false
			} // if (threadID1)
			else
				ret = User32.SetForegroundWindow((IntPtr)hWnd);

			// Restore and repaint
			if (User32.IsIconic(hWnd) != 0)
				User32.ShowWindow(hWnd, SwRestore);
			else
				User32.ShowWindow(hWnd, SwShow);

			// Succeeded
			return ret != 0;
		} // ForceForegroundWindow(hWnd) 
    }
}
