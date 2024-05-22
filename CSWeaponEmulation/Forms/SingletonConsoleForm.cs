using Patterns.Core;
using System;
using System.Windows.Forms;

namespace Patterns
{
    public partial class SingletonConsoleForm : Form
    {
        public SingletonConsoleForm()
        {
            InitializeComponent();
            Logger.Instance.LogAdded += AddLogInConsole;
        }

        public void AddLogInConsole(string log)
        {
            rtbConsole.AppendText(Environment.NewLine + "\t" + log);
            rtbConsole.ScrollToCaret();
        }

        private void ConsoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}