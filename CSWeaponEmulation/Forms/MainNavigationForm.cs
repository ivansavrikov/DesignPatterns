using Patterns.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Patterns
{
    public partial class MainNavigationForm : Form
    {
        public MainNavigationForm()
        {
            InitializeComponent();
            PutTwoFormsToCenterScreen();
        }

        private void PutTwoFormsToCenterScreen()
        {
            var consoleForm = new SingletonConsoleForm();

            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int x = resolution.Width / 2 - this.Width / 2 - consoleForm.Width / 2;
            int y = resolution.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            consoleForm.Location = new Point(x + this.Width, y);
            consoleForm.Show();
        }

        private void BtnNavToAbstractFactory_Click(object sender, EventArgs e)
        {
            var w = new AbstractFactoryForm();
            w.Location = this.Location;
            w.ShowDialog();
        }

        private void BtnNavToMapCreator_Click(object sender, EventArgs e)
        {
            var w = new PrototypeForm();
            w.Location = this.Location;
            w.ShowDialog();
        }

        private void btnNavToAdapter_Click(object sender, EventArgs e)
        {
            var w = new FactoryMethodAndAdapter();
            w.Location = this.Location;
            w.ShowDialog(this);
        }
    }
}