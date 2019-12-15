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
    public partial class QLK : Form
    {
        DataTable dt = new DataTable();
        NguyenLieuBUS bus = new NguyenLieuBUS();
        public QLK()
        {
            InitializeComponent();
        }

        private void QLK_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.loadDuLieuNguyenLieu();
                if (dt.Rows.Count > 0)
                {
                    dgv_ct.DataSource = dt;
                }
            }));
        }

        private void tb_name_OnIconRightClick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = bus.selectByKeyWord(tb_name.Text);
                if (dt.Rows.Count > 0)
                    dgv_ct.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                else
                    dt.Rows.Clear();
                dgv_ct.DataSource = dt;
            }));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new transparentBg1(Application.OpenForms[0], new QLK_ADD("", "Thêm"));
        }

        private void dgv_ct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_ct.Columns["delete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Nguyên liệu này sẽ biến mất", "Xóa nguyên liệu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {                  
                    bool kq= bus.xoa(new DTO.NguyenLieuDTO() { MaNL1 = (dgv_ct.DataSource as DataTable).Rows[e.RowIndex][0].ToString() });
                    if (kq)
                    {
                        MessageBox.Show("Xóa thành công");
                        (dgv_ct.DataSource as DataTable).Rows.RemoveAt(e.RowIndex);
                    }
                    else
                        MessageBox.Show("Nguyên liệu đang được sử dụng không thể xóa");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                return;
            }
            else
            {
                new transparentBg1(Application.OpenForms[0], new QLK_ADD((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][0].ToString(), "Chi Tiết"));
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa in được");
        }
    }
}
