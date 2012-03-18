using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SystemLib;

namespace EveEnv
{
    public class EnvWindowList
    {
        public static List<EnvWindow> GetWindowByEndsWith(string value)
        {
            var list = GetWindows();
            var list2 = new List<EnvWindow>();
            list2.AddRange(list.Where(w => w.Title.EndsWith(value)));
            foreach (var w in list2)
                w.Title = w.Title.Remove(w.Title.Length - value.Length, value.Length);
            return list2;
        }

        public static List<EnvWindow> GetWindowByStartsWith(string value)
        {
            var list = GetWindows();
            var list2 = new List<EnvWindow>();
            list2.AddRange(list.Where(w => w.Title.StartsWith(value)));
            foreach (var w in list2)
                w.Title = w.Title.Remove(0, value.Length);

            return list2;
        }

        public static List<EnvWindow> GetWindows()
        {
            var tempHwnd = User32.FindWindow(null, null);
            var list = new List<EnvWindow>();
            while (tempHwnd != IntPtr.Zero)
            {
                var text = User32.GetText(tempHwnd);
                var win = new EnvWindow(tempHwnd, text);
                list.Add(win);
                tempHwnd = User32.GetWindow(tempHwnd, User32.GetWindow_Cmd.GW_HWNDNEXT);
            }
            return list;
        }
    }
}