// Hello 
namespace EveEnv
{
    #region

    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    #endregion

    public class Env
    {
        #region Constants and Fields

        public static EveClientList EveClients = new EveClientList();

        #endregion
    }

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
            var list = from process in Process.GetProcesses()
                       where process.MainWindowTitle.StartsWith("EVE")
                       select process;

            foreach (var p in list)
            {
                var client = new EveClient(p);
                if (!this.ContainsKey(client.PilotName)) this[client.PilotName] = client;
            }
        }

        #endregion
    }
}