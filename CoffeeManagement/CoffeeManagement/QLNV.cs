using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class QLNV : Form
    {
        DataTable dt = new DataTable();
        NhanVienBUS bus = new NhanVienBUS();
        public QLNV()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(this,new QLNV_NV("","Thêm"));
        }

        private void QLNV_Load(object sender, EventArgs e)
        {         
            loadData();
        }

        private void loadData()
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

        private void tb_name_nv_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.selectByKeyWord(tb_name_nv.Text);
                if (dt.Rows.Count > 0)
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }));
           
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[0], new QLNV_NV(dt.Rows[e.RowIndex][0].ToString(),"Chi Tiết"));
        }
    }
}
