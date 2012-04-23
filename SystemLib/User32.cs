namespace SystemLib
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// Helper class containing User32 API functions
    /// </summary>
    public class User32
    {
        public const int GW_HWNDNEXT = 2;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        // For Windows Mobile, replace user32.dll with coredll.dll
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Find window by Caption only. Note you must pass IntPtr.Zero as the first parameter.

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);


        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(
            IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

        [DllImport("user32", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(int Hwnd, int wMsg, int wParam, int lParam);

        public const int WM_CLOSE = 0x10;

         
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        public static string GetText(IntPtr hWnd)
        {
            // Allocate correct string length first
            int length = GetWindowTextLength(hWnd);
            StringBuilder sb = new StringBuilder(length + 1);
            GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ShowWindowAsync(IntPtr windowHandle, SW nCmdShow);

        public enum SW : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_MAX = 10
        }
        public enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        //[Flags]
        public enum ClickType
        {
            click = 0,
            rightClick = 1,
            doubleClick = 2,
            SendKeys = 3
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Win32 function: Get foreground window handle (hwnd)
        /// </summary>
        [DllImport("User32.dll")]
        public static extern int GetForegroundWindow();

        /// <summary>
        /// Win 32 function: Get window thread process id
        /// </summary>
        /// <param name="window">Window handle</param>
        /// <param name="processId">Process id</param>
        /// <returns>Thread id</returns>
        [DllImport("user32.dll")]
        internal static extern int GetWindowThreadProcessId(
            int window, int processId);

        /// <summary>
        /// Win32 function: Attaches input to a thread for controlling windows
        /// </summary>
        [DllImport("User32.dll")]
        internal static extern int AttachThreadInput(
            int idAttach, int idAttachTo, int fAttach);


        /// <summary>
        /// Win32 function: Checks if a window is iconic (on the task bar)
        /// </summary>
        [DllImport("User32.dll")]
        internal static extern int IsIconic(int hWnd);
        /// <summary>
        /// Win32 function: Show window with nCmdShow parameters.
        /// </summary>
        [DllImport("User32.dll")]
        internal static extern int ShowWindow(int hWnd, int nCmdShow);

    }
}