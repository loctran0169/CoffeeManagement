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
    public partial class QLPN : Form
    {
        PhieuNhapBUS bus = new PhieuNhapBUS();
        DataTable dt = new DataTable();
        public QLPN()
        {
            InitializeComponent();
        }

        private void QLPN_Load(object sender, EventArgs e)
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
                    bunifuDataGridView1.DataSource = dt;
                }
            }));

        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[0], new QLPN_CTPN(dt.Rows[e.RowIndex][0].ToString()));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[0], new QLPN_ADD());
        }

        private void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.selectByKeyWord(bunifuTextBox1.Text);
                if (dt.Rows.Count  <1)
                {
                    dt.Clear();
                }
                bunifuDataGridView1.DataSource = dt;
            }));
        }
    }
}
