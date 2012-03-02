using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Instance_OnMessage(object sender, string message, string message2)
        {
            S(() =>
                  {
                      if (message != "") label1.Text = message;
                      if (message2 != "") label2.Text = message2;
                  });
        }

        private void S(Action action)
        {
            Invoke(action);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            AIMain.Instance().SignalStop();
            Application.Exit();

        }

        private void RunStopButton_Click(object sender, EventArgs e)
        {
            AIMain.Instance().IsRun = this.RunStopButton.Text == @"Run";
            this.RunStopButton.Text = this.RunStopButton.Text == @"Run" ? @"Stop" : @"Run";
        }
    }
}
