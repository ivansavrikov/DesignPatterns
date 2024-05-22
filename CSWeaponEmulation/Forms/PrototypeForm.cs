using Patterns.Core.Prototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns
{
    public partial class PrototypeForm : Form
    {
        public PrototypeForm()
        {
            InitializeComponent();
        }

        private void BtnCreateMirage_Click(object sender, EventArgs e)
        {
            MapFactory.CreateMap("Mirage");
        }
    }
}
