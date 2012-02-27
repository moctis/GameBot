// sss
namespace EveEnv
{
    #region

    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    #endregion

    public class BaseEveClient
    {
        #region Methods

        protected List<string> GetProcessList()
        {
            return
                (from process in Process.GetProcesses()
                 where process.MainWindowTitle.StartsWith("EVE")
                 select process.MainWindowTitle).ToList();
        }

        #endregion
    }
}