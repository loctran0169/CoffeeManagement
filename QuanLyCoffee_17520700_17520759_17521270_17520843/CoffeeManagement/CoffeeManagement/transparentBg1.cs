using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class transparentBg1 : Form
    {
        Form _child = null;

        public transparentBg1(Form parent, Form child)
        {
            InitializeComponent();
            _child = child;

            this.Location = parent.Location;
            this.Size = parent.Size;
            this.ShowDialog();
        }
        public transparentBg1(Form child)
        {
            InitializeComponent();
            _child = child;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }


        private void transparentForm_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formLauncher.Stop();
            _child.ShowDialog();
            this.Close();
        }
    }
}
