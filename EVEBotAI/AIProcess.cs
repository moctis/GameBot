using System;
using System.Text;
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
        }
    }

    internal class DetectEveProcess : BaseProcess
    {
        private static DetectEveProcess _instance;

        protected override bool ProcessRun()
        {
            var builder = new StringBuilder();
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