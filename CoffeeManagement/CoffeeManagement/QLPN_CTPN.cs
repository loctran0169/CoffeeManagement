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
    public partial class QLPN_CTPN : Form
    {

        private string mapn;
        private bool cancel = true;
        private int indexRow = -1;
        private bool flagThem = true;

        DataTable dt = new DataTable();
        DataTable dtInfo = new DataTable();
        CTPhieuNhapBUS busCT = new CTPhieuNhapBUS();

        DataTable dtCbb = new DataTable();
        NguyenLieuBUS busSp = new NguyenLieuBUS();
        List<string> list = new List<string>();

        PhieuNhapBUS busXuat = new PhieuNhapBUS();
        public QLPN_CTPN(string _mapn)
        {
            InitializeComponent();
            this.mapn = _mapn;
        }

        private void QLPN_CTPN_Load(object sender, EventArgs e)
        {
            dgv_ct.AutoGenerateColumns = true;
            loadData();
            loadInfo();
            loadSP();
            disableAll();
            bunifuImageButton1.Visible = true;
            btn_confirm.Visible = false;
            showEdit.Hide(panelEdit);
        }
        private void loadData()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dt = busCT.loadDuLieuChiTietPhieuNhap(mapn);
                dataToView();
            }));
        }

        public void dataToView()
        {
            if (dt.Rows.Count > 0)
            {
                DataTable temp = dt.Copy();
                dgv_ct.DataSource = temp;
            }
        }

        public void loadInfo()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dtInfo = busCT.loadInfo(mapn);
                if (dt.Rows.Count > 0)
                {
                    infoToView();
                }
            }));
        }

        public void infoToView()
        {
            tb_mapx.Text = dtInfo.Rows[0][0].ToString();
            tb_name.Text = dtInfo.Rows[0][1].ToString();
            date_ngayxuat.Value = DateTime.Parse(dtInfo.Rows[0][2].ToString());
            tb_diachi.Text = dtInfo.Rows[0][3].ToString();
            tb_price.Text = dtInfo.Rows[0][4].ToString();
            if (dtInfo.Rows[0][5].ToString() == "False")
            {
                cb_tt.Checked = false;
            }
            else
            {
                //btnEdit.Visible = false;
                cb_tt.Checked = true;
            }
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

        public void enableAll()
        {
            date_ngayxuat.Enabled = true;
            tb_diachi.Enabled = true;
            cb_tt.Enabled = true;
        }

        public void disableAll()
        {
            date_ngayxuat.Enabled = false;
            tb_diachi.Enabled = false;
            cb_tt.Enabled = false;
        }

        public float tongTien()
        {
            float sum = 0;
            foreach (DataRow row in (dgv_ct.DataSource as DataTable).Rows)
            {
                sum += float.Parse(row[5].ToString());
            }
            tb_price.Text = sum.ToString();
            return sum;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cancel == true)
            {
                cancel = false;
                btn_confirm.Visible = true;
                btnEdit.Image = Properties.Resources.cancel;
                showEdit.ShowSync(panelEdit);
                enableAll();
            }
            else
            {
                showEdit.Hide(panelEdit);
                cancel = true;
                btn_confirm.Visible = false;
                btnEdit.Image = Properties.Resources.pencil_tron;
                infoToView();
                dgv_ct.DataSource = dt;
                disableAll();
            }
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
        public void emptyAdd()
        {
            cbb.SelectedIndex = -1;
            tb_soluong.Text = "";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            showEdit.Hide(panelEdit);
            dgv_ct.EndEdit();
            DataTable temp = new DataTable("ctphieunhap");
            DataColumn column;
            DataRow dataRow;
            //mapx
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "mapn";
                temp.Columns.Add(column);
                //manl
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "manl";
                temp.Columns.Add(column);
                //soluong
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "soluong";
                temp.Columns.Add(column);
                //dongia
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "dongia";
                temp.Columns.Add(column);
            }
            foreach (DataRow row in (dgv_ct.DataSource as DataTable).Rows)
            {

                dataRow = temp.NewRow();
                dataRow["mapn"] = mapn;
                dataRow["manl"] = row[0];
                dataRow["soluong"] = row[3];
                dataRow["dongia"] = row[4];
                temp.Rows.Add(dataRow);
            }

            if (busCT.xoa(mapn))
            {
                if (busCT.updateData(temp)
                    && busXuat.sua(new DTO.PhieuNhapDTO()
                    {
                        MaPN1 = mapn,
                        NgayNhap1 = date_ngayxuat.Value.Date,
                        DiaChi1 = tb_diachi.Text,
                        TinhTrang1 = cb_tt.Checked.ToString(),
                        TongTien1 = float.Parse(tb_price.Text)
                    }))
                {
                    //dt.Rows.Clear();
                    dt = (dgv_ct.DataSource as DataTable);
                    MessageBox.Show("updated thành công");
                }
                else
                    MessageBox.Show("updated thất bại");
                btn_confirm.Visible = false;
                btnEdit.Image = Properties.Resources.pencil_tron;
                disableAll();
                dgv_ct.Columns[4].ReadOnly = true;
                cancel = true;
            }
            else
                MessageBox.Show("updated thất bại");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flagThem)
            {
                int index = cbb.SelectedIndex;
                if (index != -1)
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
    }
}
