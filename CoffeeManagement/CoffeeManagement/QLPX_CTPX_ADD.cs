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
    public partial class QLPX_CTPX_ADD : Form
    {
        DataTable dt = new DataTable();
        NguyenLieuBUS bus = new NguyenLieuBUS();

        List<NguyenLieuDTO> list = new List<NguyenLieuDTO>();
        
        public QLPX_CTPX_ADD()
        {
            InitializeComponent();
        }

        private void QLPX_CTPX_ADD_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bunifuMetroTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("vào");
        }
        public void loadData()
        {
            list = bus.select();
            var bindingList = new BindingList<NguyenLieuDTO>(list);
            var source = new BindingSource(bindingList, null);
            dgv_data.DataSource = source;
            dgv_data.Columns.RemoveAt(dgv_data.ColumnCount - 1);
        }
    }
}
