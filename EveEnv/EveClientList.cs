using System;
using System.Collections.Generic;
using SystemLib;

namespace EveEnv
{
    public class EveClientList : Dictionary<string, EveClient>
    {
        #region Constructors and Destructors

        public EveClientList()
        {
            this.Update();
        }

        #endregion

        #region Public Methods

        public void Update()
        {

            //var tempHwnd = User32.FindWindow(null, null);
            //while (tempHwnd != IntPtr.Zero)
            //{
            //    var text = User32.GetText(tempHwnd);
            //    if (text.StartsWith("EVE - "))
            //    {
            //        var client = new EveClient(tempHwnd, text);
            //        if (!string.IsNullOrEmpty(client.PilotName) && !this.ContainsKey(client.PilotName))
            //        {
            //            this[client.PilotName] = client;
            //        }
            //    }
            //    tempHwnd = User32.GetWindow(tempHwnd, User32.GetWindow_Cmd.GW_HWNDNEXT);
            //}

            foreach (var window in EnvWindowList.GetWindowByStartsWith("EVE - "))
            {
                var client = new EveClient(window);
                if (!string.IsNullOrEmpty(client.PilotName) && !this.ContainsKey(client.PilotName))
                {
                    this[client.PilotName] = client;
                }
            }
        }

        public List<string> GetWindows()
        {
            var tempHwnd = User32.FindWindow(null, null);
            var list = new List<string>();
            while (tempHwnd != IntPtr.Zero)
            {
                var text = User32.GetText(tempHwnd);
                if (text.StartsWith("EVE - "))
                    list.Add(string.Format("Window Hanlde: {0} - {1}", tempHwnd, text));
                tempHwnd = User32.GetWindow(tempHwnd, User32.GetWindow_Cmd.GW_HWNDNEXT);
            }
            return list;
        }

        #endregion
    }
}