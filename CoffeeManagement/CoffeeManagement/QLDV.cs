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
                    dgv_ct.DataSource = dt;
                }
            }));         
        }
    
        private void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.SelectByKeyWordDV(tb_name.Text);
                if (dt.Rows.Count > 0)
                    dgv_ct.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(Application.OpenForms[1],new QLDV_ADD("","Thêm"));
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_name_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.SelectByKeyWordDV(tb_name.Text);
                if (dt.Rows.Count <= 0)
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }

        private void dgv_ct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_ct.Columns["delete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Đơn vị này sẽ biến mất", "Xóa đơn vị", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool kq = bus.xoa(new DonViDTO() { MaDV1 = (dgv_ct.DataSource as DataTable).Rows[e.RowIndex][e.ColumnIndex].ToString() });
                    if (kq)
                    {
                        MessageBox.Show("Xóa thành công");
                        (dgv_ct.DataSource as DataTable).Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Nguyên liệu đang được sử dụng không thể xóa");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                
                return;
            }
            else
            {
                new transparentBg1(Application.OpenForms[1],new QLDV_ADD((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][0].ToString(),"Chi Tiết"));
            }
        }

        private void tb_name_TextChange(object sender, EventArgs e)
        {

        }
    }
}
