using BUS;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class QLBC_ADD_K : Form
    {

        BaoCaoBUS bus = new BaoCaoBUS();
        DataTable dt = new DataTable();

        public QLBC_ADD_K()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_month_onValueChanged(object sender, EventArgs e)
        {
            if ((dgv_ct.DataSource as DataTable)!=null&&(dgv_ct.DataSource as DataTable).Rows.Count > 0)
            {
                dt.Rows.Clear();
                (dgv_ct.DataSource as DataTable).Rows.Clear();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadDuLieuKho(date_month.Value.Month, date_month.Value.Year);
                dgv_ct.DataSource = dt;
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không có thông tin trong tháng này");
            }));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if ((dgv_ct.DataSource as DataTable).Rows.Count > 0)
            {
                DateTime date = DateTime.Now;
                inBaoCao inHD = new inBaoCao("BÁO CÁO KHO",
                    (Application.OpenForms[1] as frmGui).NV.TenNV1,
                    date,
                    "");
                GridControl control = new GridControl();
                control.DataSource = (dgv_ct.DataSource as DataTable);
                inHD.GridControl = control;
                ReportPrintTool printTool = new ReportPrintTool(inHD);
                bool kq = bus.them(new DTO.BaoCaoDTO()
                {
                    MaNV1 = (Application.OpenForms[1] as frmGui).NV.MaNV1,
                    Loai1 = "Doanh thu",
                    ThoiGian1 = date
                });
                printTool.ShowPreviewDialog();
                (dgv_ct.DataSource as DataTable).Rows.Clear();

            }
            else
                MessageBox.Show("Chưa có thông tin");
        }
    }
}
