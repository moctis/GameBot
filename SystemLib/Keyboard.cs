using System.Windows.Forms;

namespace SystemLib
{
    public class Keyboard
    {
        public static void Send(string keys)
        {
            SendKeys.Send(keys);
        }
    }
}