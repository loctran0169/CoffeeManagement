using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class QLPX_ADD : Form
    {
        DataTable dtCbb = new DataTable();
        NguyenLieuBUS busSp = new NguyenLieuBUS();
        List<string> list = new List<string>();

        private bool flagThem = true;
        private int indexRow = -1;
        DataTable dt = new DataTable();
        public QLPX_ADD()
        {
            InitializeComponent();
        }

        private void QLPX_ADD_Load(object sender, EventArgs e)
        {
            tb_name.Text = ((frmGui)Application.OpenForms[0]).tennv;
            initDataTable();
            dgv_ct.DataSource = dt;
            loadSP();
        }

        public void loadSP()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dtCbb = busSp.loadToCombobox();
                if (dtCbb.Rows.Count > 0)
                {
                    foreach (DataRow row in dtCbb.Rows)
                        cbb.Items.Add(row[1]);
                }
            }));
        }

        public void initDataTable()
        {
            DataColumn column;
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "manl";
                dt.Columns.Add(column);
                //manl
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "tennl";
                dt.Columns.Add(column);
                //soluong
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "tendv";
                dt.Columns.Add(column);
                //
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "soluong";
                dt.Columns.Add(column);
                //dongia
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "dongia";
                dt.Columns.Add(column);
                //
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "thanhtien";
                dt.Columns.Add(column);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flagThem)
            {
                int index = cbb.SelectedIndex;
                if (index != -1)
                {
                    if ((dgv_ct.DataSource as DataTable) != null)
                    {
                        list = (dgv_ct.DataSource as DataTable).AsEnumerable()
                            .Select(r => r.Field<string>("manl"))
                            .ToList();
                        if (list.Contains(dtCbb.Rows[index][0]))
                        {
                            MessageBox.Show("Đã có trong danh sách");
                            emptyAdd();
                            return;
                        }
                    }
                    else if (tb_soluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng");
                        return;
                    }
                    DataRow row = (dgv_ct.DataSource as DataTable).NewRow();
                    row[0] = dtCbb.Rows[index][0];
                    row[1] = dtCbb.Rows[index][1];
                    row[2] = dtCbb.Rows[index][3];
                    row[3] = float.Parse(tb_soluong.Text);
                    row[4] = dtCbb.Rows[index][6];
                    row[5] = float.Parse(tb_soluong.Text) * float.Parse(dtCbb.Rows[index][6].ToString());
                    (dgv_ct.DataSource as DataTable).Rows.Add(row);
                    tongTien();
                    cbb.SelectedIndex = -1;
                    tb_soluong.Text = "";
                }
                else
                    MessageBox.Show("Bạn chưa chọn guyên liệu cần thêm");
            }
            else
            {
                DataGridViewRow newDataRow = dgv_ct.Rows[indexRow];
                newDataRow.Cells[4].Value = tb_soluong.Text;
                newDataRow.Cells[6].Value = float.Parse(newDataRow.Cells[4].Value.ToString()) * float.Parse(newDataRow.Cells[5].Value.ToString());
                tongTien();
                emptyAdd();
                btnAdd.ButtonText = "Thêm";
                flagThem = true;
                cbb.Enabled = true;
            }
        }
        public void emptyAdd()
        {
            cbb.SelectedIndex = -1;
            tb_soluong.Text = "";
        }
        public float tongTien()
        {
            float sum = 0;
            foreach (DataRow row in (dgv_ct.DataSource as DataTable).Rows)
            {
                sum += float.Parse(row[5].ToString());
            }
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyGroupSeparator = ".";
            nfi.CurrencyDecimalSeparator = ",";
            tb_price.Text = sum.ToString("",nfi);
            return sum;
        }

        private void dgv_ct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgv_ct.NewRowIndex || e.RowIndex < 0)
                return;

            //kiểm tra xem bấm xóa ko
            if (e.ColumnIndex == dgv_ct.Columns["delete"].Index)
            {
                (dgv_ct.DataSource as DataTable).Rows.RemoveAt(e.RowIndex);
                tongTien();
                btnAdd.ButtonText = "Thêm";
                cbb.Enabled = true;
                flagThem = true;
                emptyAdd();
                return;
            }
            else
            {
                btnAdd.ButtonText = "Sửa";
                flagThem = false;
                indexRow = e.RowIndex;
                cbb.SelectedIndex = cbb.FindString((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][1].ToString());
                tb_soluong.Text = (dgv_ct.DataSource as DataTable).Rows[e.RowIndex][3].ToString();
                cbb.Enabled = false;
            }
        }
    }
}
