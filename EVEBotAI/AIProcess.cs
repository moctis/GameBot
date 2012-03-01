using System;
using System.Text;
using System.Threading;
using SystemLib;
using EveEnv;

namespace EVEBotAI
{
    internal class AIProcess
    {
        private static AIProcess _instance;

        public static AIProcess Instance()
        {
            return _instance ?? (_instance = new AIProcess());
        }



        public void Run()
        {
            DetectEveProcess.Instance().Run();
            LoopActiveProcess.Instance().Run();
        }
    }
    internal class LoopActiveProcess : BaseProcess
    {
        private static LoopActiveProcess _instance;
        public int index = 0;
        private const int DELAY = 10;

        protected override bool ProcessRun()
        {
            foreach (var client in Env.EveClients)
            {
                var process = client.Value.Process;
                AIMain.InvokeOnMessage(client.Key);
                User32.SetForegroundWindow(process.MainWindowHandle);
                Thread.Sleep(TimeSpan.FromSeconds(DELAY));
            }
            return true;
        }

        protected override void SetInterval()
        {
            Interval = TimeSpan.FromSeconds(DELAY * Env.EveClients.Count);
        }

        public static LoopActiveProcess Instance()
        {
            return _instance ?? (_instance = new LoopActiveProcess());
        }
    }
    internal class DetectEveProcess : BaseProcess
    {
        private static DetectEveProcess _instance;

        protected override bool ProcessRun()
        {
            var builder = new StringBuilder();

            Env.EveClients.Update();
            foreach (var eveClient in Env.EveClients)
            {
                builder.AppendFormat("{0} | ", eveClient.Value.PilotName);
            }
            AIMain.InvokeOnMessage(builder.ToString());
            return true;
        }

        protected override void SetInterval()
        {
            Interval = TimeSpan.FromSeconds(30);
        }

        public static DetectEveProcess Instance()
        {
            return _instance ?? (_instance = new DetectEveProcess());
        }
    }

    internal abstract class BaseProcess
    {
        public DateTime NextRun = DateTime.Now;
        public TimeSpan Interval = TimeSpan.FromSeconds(10);
        public bool Run()
        {
            if (DateTime.Now < NextRun) return false;
            NextRun = NextRun.Add(Interval);
            return ProcessRun();
        }

        protected abstract bool ProcessRun();
        protected abstract void SetInterval();
    }
}