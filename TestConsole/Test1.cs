using System;
using System.Threading;
using EveEnv;

namespace TestConsole
{
    internal class Test1
    {
        public void Execute()
        {
            string value = "EVE - ";
            Thread.Sleep(TimeSpan.FromSeconds(10));
            var actual = EnvWindowList.GetWindowByStartsWith(value);
            for (var i = 0; i < 15; i++)
                foreach (var window in actual)
                {                    
                    var ret = window.BringToFront();
                    Console.WriteLine("[{0}] {1}", window.Title , ret ? "Yes" : "No ");                    
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
        }

        public void Execute2()
        {
            string value = " - Notepad";
            Thread.Sleep(TimeSpan.FromSeconds(5));
            var actual = EnvWindowList.GetWindowByEndsWith(value);
            for (var i = 0; i < 5; i++)
                foreach (var window in actual)
                {
                    var ret = window.BringToFront();
                    Console.WriteLine("[{0}] {1}", window.Title, ret ? "Yes" : "No ");
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
        }
    }
}