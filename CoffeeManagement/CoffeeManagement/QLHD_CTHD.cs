using DTO;
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
    public partial class QLHD_CTHD : Form
    {
        HoaDonDTO hd = new HoaDonDTO();
        CTHoaDonBUS bus = new CTHoaDonBUS();
        DataTable dt = new DataTable();
        public QLHD_CTHD(HoaDonDTO hs)
        {
            InitializeComponent();
            this.hd = hs;
            tb_mahd_ct.Text = hs.MaHD1;
            tb_nv_cthd.Text = hs.MaNV1;
            tb_tien_cthd.Text = hs.TongTien1.ToString()+"Đ";
            bunifuTextBox2.Text = hs.NgayLap1.ToString("dd-MM-yyyy");           
        }

        private void QLHD_CTHD_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadData(hd.MaHD1);
                if (dt.Rows.Count > 0)
                {
                    bunifuDataGridView1.DataSource = dt;
                }
            }));
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
