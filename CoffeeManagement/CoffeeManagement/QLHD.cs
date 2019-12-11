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
    public partial class QLHD : Form
    {
        HoaDonBUS bus = new HoaDonBUS();
        DataTable dt = new DataTable();
        public QLHD()
        {
            if (Program.IsInDesignMode())
                return;
            InitializeComponent();
        }

        private void QLHD_Load(object sender, EventArgs e)
        {     
            loadData();
        }
        public void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadToDataTable();
                if (dt.Rows.Count > 0)
                {
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    bunifuDataGridView1.DataSource = dt;
                }
            }));
        }

        private void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.selectByKeyWord(bunifuTextBox1.Text);
                if (dt.Rows.Count > 0)
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }));       
        }

        private void dataLeft_onValueChanged(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadToDataTable(dataLeft.Value.Date, dateRight.Value.Date);
                if (dt.Rows.Count > 0)
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }));
        }

        private void dateRight_onValueChanged(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadToDataTable(dataLeft.Value.Date, dateRight.Value.Date);
                if (dt.Rows.Count > 0)
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }));
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD1 = dt.Rows[0][0].ToString();
            hd.MaNV1 = dt.Rows[0][1].ToString();
            hd.NgayLap1 = DateTime.Parse(dt.Rows[0][2].ToString());
            hd.TongTien1 = float.Parse(dt.Rows[0][3].ToString());
            new CoffeeManagement.transparentBg1(Application.OpenForms[0], new QLHD_CTHD(hd));
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }
    }
}
