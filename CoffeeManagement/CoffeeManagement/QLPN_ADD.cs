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
    public partial class QLPN_ADD : Form
    {
        DataTable dtCbb = new DataTable();
        NguyenLieuBUS busSp = new NguyenLieuBUS();
        List<string> list = new List<string>();

        PhieuNhapBUS busPX = new PhieuNhapBUS();
        CTPhieuNhapBUS busCT = new CTPhieuNhapBUS();

        private bool flagThem = true;
        private bool daLap = false;
        private int indexRow = -1;
        private float tongtien = 0;
        private string mapn;
        private DateTime timeNow;
        DataTable dt = new DataTable();
        public QLPN_ADD()
        {
            InitializeComponent();
        }

        private void QLPN_ADD_Load(object sender, EventArgs e)
        {
            tb_name.Text = ((frmGui)Application.OpenForms[0]).NV.TenNV1;
            initDataTable();
            dgv_ct.DataSource = dt;
            loadSP();
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
                column.ColumnName = "gianhap";
                dt.Columns.Add(column);
                //
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "thanhtien";
                dt.Columns.Add(column);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flagThem && !daLap)
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
            else if (!flagThem && !daLap)
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
        public void tongTien()
        {
            float sum = 0;
            foreach (DataRow row in (dgv_ct.DataSource as DataTable).Rows)
            {
                sum += float.Parse(row[5].ToString());
            }
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyGroupSeparator = ".";
            nfi.CurrencyDecimalSeparator = ",";
            nfi.CurrencySymbol = "";
            tb_price.Text = Convert.ToDecimal(sum).ToString("C2", nfi);
            tongtien = sum;
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

        private void btn_lappn_Click(object sender, EventArgs e)
        {
            if (!daLap)
            {
                if ((dgv_ct.DataSource as DataTable) == null || (dgv_ct.DataSource as DataTable).Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có nguyên liệu xuất");
                    return;
                }
                try
                {
                    timeNow = DateTime.Now;
                    if (busPX.them(new DTO.PhieuNhapDTO()
                    {
                        MaNV1 = (Application.OpenForms[0] as frmGui).NV.MaNV1,
                        NgayLap1 = timeNow,
                        NgayNhap1 = date_ngayxuat.Value.Date,
                        DiaChi1 = tb_diachi.Text,
                        TinhTrang1 = "False",
                        TongTien1 = tongtien
                    }) == true)
                    {
                        DataTable dtMaPX = busPX.loadMaPX(timeNow);
                        if (dtMaPX != null && dtMaPX.Rows.Count == 1)
                        {
                            mapn = dtMaPX.Rows[0][0].ToString();
                            try
                            {
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
                                if (busCT.updateData(temp))
                                {
                                    MessageBox.Show("Lập phiếu xuất thành công");
                                    daLap = true;
                                }
                                else
                                {
                                    busPX.xoa(new DTO.PhieuNhapDTO() { MaNV1 = mapn });
                                    MessageBox.Show("Lập phiếu xuất thất bai");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi thêm chi tiết " + ex.Message);
                            }
                        }
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                    else
                        MessageBox.Show("Lập phiếu xuất thất bại");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm phiếu xuất " + ex.Message);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn lập phiếu xuất mới", "Phiếu xuất đã được lập", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clearData();
                    daLap = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        public void clearData()
        {
            tb_diachi.Text = "";
            date_ngayxuat.Value = DateTime.Now;
            dt.Rows.Clear();
            dgv_ct.DataSource = dt;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa in dc");
        }
    }
}
