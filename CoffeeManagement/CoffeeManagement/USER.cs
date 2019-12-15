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
    public partial class USER : Form
    {
        NhanVienBUS bus = new NhanVienBUS();
        public USER()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void USER_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                DataTable  dt = bus.loadNhanViewDangNhap((Application.OpenForms[1] as frmGui).NV.MaTK1);
                if (dt.Rows.Count > 0)
                {
                    tb_name.Text = dt.Rows[0][2].ToString();
                    tb_date.Text = DateTime.Parse(dt.Rows[0][3].ToString()).ToString("dd/MM/yyyy");
                    tb_sex.Text = dt.Rows[0][4].ToString();
                    tb_diachi.Text = dt.Rows[0][5].ToString();
                    tb_sdt.Text = dt.Rows[0][6].ToString();
                    tb_email.Text = dt.Rows[0][7].ToString();
                    tb_note.Text = dt.Rows[0][9].ToString();
                }
            }));
        }
    }
}
