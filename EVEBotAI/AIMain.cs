using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EVEBotAI
{
    using System.Diagnostics.CodeAnalysis;

    public class AIMain
    {
        public delegate void OnMessageDelegate(object sender, string message, string message2);

        public class OnStartedArgs
        {
        }

        private static AIMain _instance = null;

        private Thread th;

        private bool Running;

        public event EventHandler OnStarted;

        public event EventHandler OnStoped;

        public event OnMessageDelegate OnMessage;

        public bool IsRun { get; set; }

        public static void InvokeOnMessage(string message, string message2 = "")
        {
            var handler = Instance().OnMessage;
            if (handler != null) handler(Instance(), message, message2);
        }

        public void InvokeOnStoped(EventArgs e)
        {
            EventHandler handler = OnStoped;
            if (handler != null) handler(this, e);
        }

        public void InvokeOnStarted(EventArgs e)
        {
            EventHandler handler = OnStarted;
            if (handler != null) handler(this, e);
        }

        public static AIMain Instance()
        {
            return _instance ?? (_instance = new AIMain());
        }

        public void Run()
        {
            th = new Thread(MainLoop);
            th.Name = "AIMain";
            th.Start();
        }

        public void MainLoop()
        {
            Running = true;
            InvokeOnStarted(EventArgs.Empty);

            while (Running)
            {
                Thread.Sleep(1000);
                try
                {
                    if (this.IsRun) AIProcess.Instance().Run();
                }
                catch (ThreadAbortException)
                {
                    Running = false;
                }
                catch (Exception)
                {
                }
            }
            InvokeOnStoped(EventArgs.Empty);
        }
         
        public void SignalStop()
        {
            th.Abort();
            Running = false;
        }
    }
}