namespace EveEnv
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using Enumerable = System.Linq.Enumerable;

    public class BaseEveClient
    {
        protected List<string> GetProcessList()
        {
            return
                Enumerable.ToList<string>(
                    (from process in Process.GetProcesses()
                     where process.MainWindowTitle.StartsWith("EVE")
                     select process.MainWindowTitle));
        }
    }
}