﻿using System;
using System.Text;
using EveEnv;

namespace EVEBotAI
{
    internal class AIProcess
    {
        private static AIProcess _instance;

        public static AIProcess Instance
        {
            get { return _instance ?? (_instance = new AIProcess()); }
        }

        public BaseProcess DetectEveProcess = new DetectEveProcess();

        public void Run()
        {
            DetectEveProcess.Run();
        }
    }

    internal class DetectEveProcess : BaseProcess
    { 
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