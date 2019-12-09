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
    public partial class QLPX_CTPX : Form
    {
        private string mapx;
        DataTable dt = new DataTable();
        CTPhieuXuatBUS bus = new CTPhieuXuatBUS();
        public QLPX_CTPX(string _mapx)
        {
            InitializeComponent();
            this.mapx = _mapx;
        }

        private void QLPX_CTPX_Load(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadDuLieuChiTietPhieuXuat(mapx);
                if (dt.Rows.Count > 0)
                {
                    bunifuDataGridView1.DataSource = dt;
                }
            }));
        }
    }
}
