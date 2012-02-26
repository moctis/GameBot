using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveEnv
{
    public class Keyboard
    {
        public Keyboard SendKeys(string keys)
        {
            System.Windows.Forms.SendKeys.Send(keys);
            return this;
        }
    }

    public class Timer
    {
        public void WaitSec(int sec)
        {
            
        }
    }

    public class Env
    {
        private static readonly Lazy<Keyboard> keyboard = new Lazy<Keyboard>();

        private static readonly Lazy<Timer> timer = new Lazy<Timer>();

        public static Keyboard Keyboard
        {
            get
            {
                return keyboard.Value;
            }
        }

        public static Timer Timer
        {
            get
            {
                return timer.Value;
            } 
        }
    }
}
