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

        private void QLDV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadDuLieuDonViTinh();
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
                dt = bus.SelectByKeyWordDV(tb_name.Text);
                if (dt.Rows.Count > 0)
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[0],new QLDV_ADD());
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_name_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.SelectByKeyWordDV(tb_name.Text);
                if (dt.Rows.Count > 0)
                    bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }));
        }
    }
}
