﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EVEBotAI;

namespace EveOnline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var form = new MainForm();
            //AIMain.Instance().Run();            
            //Application.Run(form);
            Application.Run(new LocationConfig());
        }
    }
}
