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
    public partial class QLNV_NV : Form
    {
        private string userId;
        private bool isDetails;
        public QLNV_NV(string _userID,bool _isDetails)
        {
            InitializeComponent();
            this.userId = _userID;this.isDetails = _isDetails;
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
