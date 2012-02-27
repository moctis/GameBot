using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EveEnv
{
    public class Env
    {
        public static EveClientList EveClients = new EveClientList();
            
    }

    public class EveClientList :  Dictionary<string, EveClient>
    {
        public EveClientList()
        {
            Update();
        }

        public void Update()
        {
            var list = from process in Process.GetProcesses()
                       where process.MainWindowTitle.StartsWith("EVE")
                       select process;

            foreach (var p in list)
            {
                var client = new EveClient(p);
                if (!ContainsKey(client.PilotName))
                    this[client.PilotName] = client;
            }
        }
    }
}