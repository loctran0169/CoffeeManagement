using BUS;
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
    public partial class QLDV_ADD : Form
    {
        DonViBUS bus = new DonViBUS();
        public QLDV_ADD()
        {
            InitializeComponent();
        }

        private void QLDV_ADD_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;
            bool kq = bus.them(new DTO.DonViDTO(tb_name.Text, tb_note.Text));
            if (kq) { 
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }
        public bool checkData()
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đơn vị");
                tb_name.Focus();
            }
            return true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
