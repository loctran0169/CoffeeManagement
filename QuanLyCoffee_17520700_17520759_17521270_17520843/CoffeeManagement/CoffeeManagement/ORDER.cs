using BUS;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class ORDER : Form
    {
        ImageList imageList = new ImageList();
        SanPhamBUS busSP = new SanPhamBUS();
        HoaDonBUS busHD = new HoaDonBUS();
        CTHoaDonBUS busCT = new CTHoaDonBUS();

        DataTable dtSP = new DataTable();
        DataTable dt = new DataTable();

        List<string> list = new List<string>();
        List<string> listMaSP = new List<string>();
        bool isFirstLoad = false;
        DateTime timeNow;
        float tongtien;
        string mahd;

        public bool isPaid;
        public ORDER()
        {
            InitializeComponent();
            imageList.ImageSize = new Size(80, 80);
            tb_name.Text = (Application.OpenForms[1] as frmGui).NV.TenNV1;
        }

        private void ORDER_Load(object sender, EventArgs e)
        {
            initDataTable();
            dgv_ct.DataSource = dt;
            loadSP("");
        }

        public void loadSP(string key)
        {
            listSP.Items.Clear();
            imageList.Images.Clear();

            listSP.LargeImageList = imageList;
            this.Invoke(new MethodInvoker(delegate
            {
                if (key == "")
                    dtSP = busSP.loadToDataTable();
                else
                    dtSP = busSP.selectByKeyWord(key);
                if (dtSP.Rows.Count > 0)
                {
                    int i = 0;
                    foreach (DataRow row in dtSP.Rows)
                    {
                        
                        Image image = byteArrayToImage(row[3] as Byte[]);
                        imageList.Images.Add(image);
                        ListViewItem item = new ListViewItem();
                        item.ForeColor = Color.Blue;
                        item.Text = row[1].ToString();
                        item.ImageIndex = i; i++;
                        listSP.Items.Add(item);
                    }
                }
            }));
        }

        public void loadListImage()
        {            
            
            for (int i = 0; i < 10; i++)
            {
                Image image = Image.FromFile("C:\\Users\\LQTPL\\Pictures\\Saved Pictures\\Thanh-Phong-Tom-Phan-2-Cu-dam-Huy-Diet.png");
                imageList.Images.Add(image);
            }           
        }

        public void initDataTable()
        {
            DataColumn column;
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "tensp";
                dt.Columns.Add(column);              
                //soluong
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "soluong";
                dt.Columns.Add(column);
                //dongia
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "giaban";
                dt.Columns.Add(column);
                //thanhtien
                column = new DataColumn();
                column.DataType = Type.GetType("System.Single");
                column.ColumnName = "thanhtien";
                dt.Columns.Add(column);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa in được");
        }

        private void tb_search_sp_OnIconRightClick(object sender, EventArgs e)
        {
            loadSP(tb_search_sp.Text);
        }

        private void listSP_Click(object sender, EventArgs e)
        {
            int index = listSP.SelectedItems[0].Index;
            list = (dgv_ct.DataSource as DataTable).AsEnumerable()
                        .Select(r => r.Field<string>("tensp"))
                        .ToList();            
            if (list.Contains(dtSP.Rows[index][1].ToString()))
            {
                MessageBox.Show("Đã có danh sách");
                return;
            }
            try
            {
                DataRow row = (dgv_ct.DataSource as DataTable).NewRow();
                row[0] = dtSP.Rows[index][1].ToString();
                row[1] = 1;
                row[2] = dtSP.Rows[index][4].ToString();
                row[3] = dtSP.Rows[index][4].ToString();
                listMaSP.Add(dtSP.Rows[index][0].ToString());
                (dgv_ct.DataSource as DataTable).Rows.Add(row);
                tongTien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_ct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_ct.Columns["delete"].Index)
            {
                (dgv_ct.DataSource as DataTable).Rows.RemoveAt(e.RowIndex);
                listMaSP.RemoveAt(e.RowIndex);
                tongTien();
                return;
            }
            else if (e.ColumnIndex == dgv_ct.Columns["plus"].Index)
            {
                int value = int.Parse((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][1].ToString());
                (dgv_ct.DataSource as DataTable).Rows[e.RowIndex][1] = value+1;
                (dgv_ct.DataSource as DataTable).Rows[e.RowIndex][3] = 
                    (float.Parse((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][1].ToString()) * float.Parse((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][2].ToString()));
                tongTien();
                return;
            }
            else if (e.ColumnIndex == dgv_ct.Columns["minus"].Index)
            {
                int value = int.Parse((dgv_ct.DataSource as DataTable).Rows[e.RowIndex][1].ToString());
                if (value == 1)
                    return;
                (dgv_ct.DataSource as DataTable).Rows[e.RowIndex][1] =  value-1;
                tongTien();
                return;
            }
        }

        public void tongTien()
        {
            float sum = 0;
            foreach (DataRow row in (dgv_ct.DataSource as DataTable).Rows)
            {
                sum += float.Parse(row[3].ToString());
            }
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyGroupSeparator = ".";
            nfi.CurrencyDecimalSeparator = ",";
            nfi.CurrencySymbol = "";
            tb_price.Text = Convert.ToDecimal(sum).ToString("C0", nfi);
            tongtien = sum;
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            if (isPaid == true)
            {
                MessageBox.Show("Chưa in hóa đơn");
                return;
            }
            if ((dgv_ct.DataSource as DataTable) == null || (dgv_ct.DataSource as DataTable).Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm");
                return;
            }
            try
            {
                timeNow = DateTime.Now;
                if (busHD.them(new DTO.HoaDonDTO()
                {
                    MaNV1 = (Application.OpenForms[1] as frmGui).NV.MaNV1,
                    NgayLap1 = timeNow,
                    TongTien1 = tongtien
                }) == true)
                {
                    DataTable dtMaHD = busHD.loadMaHD();
                    if (dtMaHD != null && dtMaHD.Rows.Count == 1)
                    {
                        mahd = dtMaHD.Rows[0][0].ToString();
                        try
                        {
                            DataTable temp = new DataTable("cthoadon");
                            DataColumn column;
                            DataRow dataRow;
                            //mapx
                            {
                                column = new DataColumn();
                                column.DataType = Type.GetType("System.String");
                                column.ColumnName = "mahd";
                                temp.Columns.Add(column);
                                //manl
                                column = new DataColumn();
                                column.DataType = Type.GetType("System.String");
                                column.ColumnName = "masp";
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
                            int i = 0;
                            foreach (DataRow row in (dgv_ct.DataSource as DataTable).Rows)
                            {
                                dataRow = temp.NewRow();
                                dataRow["mahd"] = mahd;
                                dataRow["masp"] = listMaSP[i];
                                dataRow["soluong"] = row[1];
                                dataRow["dongia"] = row[2];
                                temp.Rows.Add(dataRow);
                                i++;
                            }

                            if (busCT.updateData(temp))
                            {
                                isPaid = true;
                                MessageBox.Show("Lập hóa đơn thành công");
                            }
                            else
                            {
                                busHD.xoa(new DTO.HoaDonDTO() { MaHD1 = mahd });
                                MessageBox.Show("Lập hóa đơn thất bai");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi thêm hóa đơn " + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_nhan_OnValueChanged(object sender, EventArgs e)
        {
            if (tb_nhan.Text != "" && (float.Parse(tb_nhan.Text) > tongtien))
            {
                float tien = float.Parse(tb_nhan.Text) - tongtien;
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.CurrencyGroupSeparator = ".";
                nfi.CurrencyDecimalSeparator = ",";
                nfi.CurrencySymbol = "";
                tb_tienthoi.Text = Convert.ToDecimal(tien).ToString("C0", nfi);
            }
            else
                tb_tienthoi.Text = "";
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            if (isPaid)
            {
                DateTime date = DateTime.Now;
                inHoaDon inHD = new inHoaDon(tb_price.Text,
                    date.ToLongDateString(),
                    mahd,
                    tb_name.Text);
                GridControl control = new GridControl();
                control.DataSource = (dgv_ct.DataSource as DataTable);
                inHD.GridControl = control;
                ReportPrintTool printTool = new ReportPrintTool(inHD);
                printTool.ShowPreviewDialog();
                (dgv_ct.DataSource as DataTable).Rows.Clear();
                isPaid = false;
            }
            else
                MessageBox.Show("Chưa lập hóa đơn");
        }

        private void tb_nhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
