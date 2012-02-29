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
            var aiMain = AIMain.Instance();
            aiMain.OnMessage += Instance_OnMessage;
        }

        private void Instance_OnMessage(object sender, string message)
        {
            Console.WriteLine(message);
        }
    }
}
