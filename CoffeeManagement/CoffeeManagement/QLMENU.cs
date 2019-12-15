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
    public partial class QLMENU : Form
    {
        SanPhamBUS bus = new SanPhamBUS();
        DataTable dt = new DataTable();
        public QLMENU()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadToDataTable();
                if (dt.Rows.Count > 0)
                {
                    // bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dataGridSP.DataSource = dt;
                }
            }));
        }

        private void btn_search_menu_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.selectByKeyWord(btn_search_menu.Text);
                if (dt.Rows.Count == 0)                
                    dt.Rows.Clear();
                dataGridSP.DataSource = dt;
            }));
        }

        private void dataGridSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //new CoffeeManagement.transparentBg1(this, new QLMENU_ADD(dt.Rows[e.RowIndex][0].ToString(), "Chi Tiết"));
        }

        private void QLMENU_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[0], new QLMENU_ADD("", "Thêm"));
        }
    }
}
