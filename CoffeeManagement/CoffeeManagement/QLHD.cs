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
            dt = bus.loadToDataTable();
            if (dt.Rows.Count > 0)
            {
                bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                bunifuDataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("Không có thông tin hóa đơn");
        }

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("vào");
            }          
        }

        private void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            dt = bus.selectByKeyWord(bunifuTextBox1.Text);
            if (dt.Rows.Count > 0)
            {
                bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                bunifuDataGridView1.DataSource = dt;
            }
        }

        private void dataLeft_onValueChanged(object sender, EventArgs e)
        {
            dt = bus.loadToDataTable(dataLeft.Value.Date, dateRight.Value.Date);
            if (dt != null && dt.Rows.Count > 0)
            {
                bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                bunifuDataGridView1.DataSource = dt;
            }
            else
            {
                dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }
        }

        private void dateRight_onValueChanged(object sender, EventArgs e)
        {
            dt = bus.loadToDataTable(dataLeft.Value.Date,dateRight.Value.Date);
            if (dt != null && dt.Rows.Count > 0)
            {
                bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                bunifuDataGridView1.DataSource = dt;
            }
            else
            {
                dt.Rows.Clear();
                bunifuDataGridView1.DataSource = dt;
            }
        }
    }
}
