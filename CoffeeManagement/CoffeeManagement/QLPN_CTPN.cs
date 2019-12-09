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
    public partial class QLPN_CTPN : Form
    {
        private string mapn;
        public QLPN_CTPN(string _mapn)
        {
            InitializeComponent();
            this.mapn = _mapn;
        }

        private void QLPN_CTPN_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {

        }
    }
}
