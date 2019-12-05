using DTO;
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
    public partial class frmGui : Form
    {
        TaiKhoanDTO us = new TaiKhoanDTO();
        public frmGui(TaiKhoanDTO _us)
        {
            InitializeComponent();
            this.us = _us;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
