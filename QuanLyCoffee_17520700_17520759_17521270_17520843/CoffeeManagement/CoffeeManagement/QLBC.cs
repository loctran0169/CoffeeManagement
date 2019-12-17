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
    public partial class QLBC : Form
    {
        DataTable dt = new DataTable();
        BaoCaoBUS bus = new BaoCaoBUS();
        public QLBC()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[1], new QLBC_ADD_DT());
        }

        private void QLBC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadBaoCaoAll();
                if (dt.Rows.Count <= 0)
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            new transparentBg1(Application.OpenForms[1], new QLBC_ADD_K());
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            (dgv_ct.DataSource as DataTable).Rows.Clear();
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadBaoCao("Kho");
                if (dt.Rows.Count <= 0)
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            (dgv_ct.DataSource as DataTable).Rows.Clear();
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadBaoCao("Doanh thu");
                if (dt.Rows.Count <= 0)
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }

        private void tb_search_OnIconRightClick(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            (dgv_ct.DataSource as DataTable).Rows.Clear();
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.selectByKeyWordDV(tb_search.Text);
                if (dt.Rows.Count <= 0)
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }
    }
}
