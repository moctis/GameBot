using System.Windows.Forms;

namespace SystemLib
{
    public class Keyboard
    {
        public void Send(string keys)
        {
            SendKeys.Send(keys);
        }
    }
}