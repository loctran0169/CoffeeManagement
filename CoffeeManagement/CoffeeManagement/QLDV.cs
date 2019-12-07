using BUS;
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
    public partial class QLDV : Form
    {
        DonViBUS bus = new DonViBUS();
        DataTable dt = new DataTable();
        public QLDV()
        {
            InitializeComponent();
        }



        public void loadData()
        {
            dt = bus.loadDuLieuDonViTinh();
            if (dt.Rows.Count > 0)
            {
                bunifuDataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("Không có thông tin đơn vị");
         
        }

        private void QLDV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            dt = bus.SelectByKeyWordDV(bunifuTextBox1.Text);
            if (dt.Rows.Count > 0)
            {

                bunifuDataGridView1.DataSource = dt;
            }

        }


        //private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int selected = e.RowIndex;
        //    HoaDonDTO hd = new HoaDonDTO();
        //    hd.MaHD1 = dt.Rows[0][0].ToString();
        //    hd.MaNV1 = dt.Rows[0][1].ToString();
        //    hd.NgayLap1 = DateTime.Parse(dt.Rows[0][2].ToString());
        //    hd.TongTien1 = float.Parse(dt.Rows[0][3].ToString());
        //    new CoffeeManagement.transparentBg1(this, new QLHD_CTHD(hd));
        //}

    }
}
