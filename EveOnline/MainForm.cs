using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EVEBotAI;

namespace EveOnline
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AIMain.Instance.OnMessage += new AIMain.OnMessageDelegate(Instance_OnMessage);
        }

        void Instance_OnMessage(object sender, string message)
        {
            Console.WriteLine(message);
        }
    }
}
