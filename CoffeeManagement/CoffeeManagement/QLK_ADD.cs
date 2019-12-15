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
    public partial class QLK_ADD : Form
    {
        NguyenLieuBUS bus = new NguyenLieuBUS();
        DonViBUS busDV = new DonViBUS();

        DataTable dtDV = new DataTable();
        List<String> list = new List<string>();

        private string MaNL;
        private string tag;
        private bool chiTiet = true;
        public QLK_ADD(string _id, string _tag)
        {
            InitializeComponent();
            this.MaNL = _id;
            this.tag = _tag;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLK_ADD_Load(object sender, EventArgs e)
        {
            loadDV();
            if (tag == "Thêm")
            {
                btnAdd.ButtonText = "Lưu";
            }
            else
            {
                btnAdd.ButtonText = "Sửa";
                loadData();
                disableAll();
            }           
        }
        public void enableAll()
        {
            tb_name.Enabled = true;
            cbb_dv.Enabled = true;
            tb_giaban.Enabled = true;
            tb_gianhap.Enabled = true;
            tb_soluong.Enabled = true;
        }
        public void disableAll()
        {
            tb_name.Enabled = false;
            cbb_dv.Enabled = false;
            tb_giaban.Enabled = false;
            tb_gianhap.Enabled = false;
            tb_soluong.Enabled = false;
        }
        public void loadDV()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dtDV = busDV.loadDuLieuDonViTinh();
                if (dtDV.Rows.Count > 0)
                {
                    list = dtDV.AsEnumerable()
                    .Select(r => r.Field<string>("MaDV"))
                    .ToList();
                    foreach(DataRow row in dtDV.Rows)
                    {
                        cbb_dv.Items.Add("  "+row[1]);
                    }
                }
            }));           
        }
        public void loadData()
        {
            DataTable dt = bus.loadNL(MaNL);

            if (dt != null && dt.Rows.Count > 0)
            {
                tb_name.Text = dt.Rows[0][2].ToString();
                cbb_dv.SelectedIndex = list.IndexOf(dt.Rows[0][3].ToString());
                tb_gianhap.Text = dt.Rows[0][5].ToString();
                tb_giaban.Text = dt.Rows[0][6].ToString();                
                tb_soluong.Text = dt.Rows[0][4].ToString();
            }
            else
                MessageBox.Show("không có");
        }
        public bool checkData()
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nguyên liệu");
                tb_name.Focus();
                return false;
            }
            else if (cbb_dv.SelectedIndex==-1)
            {
                MessageBox.Show("Chưa chọn đơn vị");
                return false;
            }
            else if (tb_gianhap.Text == "")
            {
                MessageBox.Show("Chưa nhập giá nhập");
                tb_gianhap.Focus();
                return false;
            }
            else if (tb_giaban.Text == "")
            {
                MessageBox.Show("Chưa nhập giá bán");
                tb_giaban.Focus();
                return false;
            }
            else if (tb_soluong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng");
                tb_soluong.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tag == "Thêm")
            {
                if (!checkData()) return;
                bool kq = bus.them(new DTO.NguyenLieuDTO() {
                    TenNL1 = tb_name.Text,
                    MaDV1 = list[cbb_dv.SelectedIndex],
                    GiaNhap1=float.Parse(tb_gianhap.Text),
                    GiaBan1 =float.Parse(tb_giaban.Text),
                    SoLuongTon1=float.Parse(tb_soluong.Text)
                });
                if (kq)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
            {
                if (chiTiet)
                {
                    btnAdd.ButtonText = "Lưu";
                    enableAll();
                    chiTiet = false;
                }
                else
                {
                    if (!checkData()) return;
                    bool kq = bus.sua(new DTO.NguyenLieuDTO()
                    {
                        MaNL1 = MaNL,
                        TenNL1 = tb_name.Text,
                        MaDV1 = list[cbb_dv.SelectedIndex],
                        GiaNhap1 = float.Parse(tb_gianhap.Text),
                        GiaBan1 = float.Parse(tb_giaban.Text),
                        SoLuongTon1 = float.Parse(tb_soluong.Text)
                    });
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        disableAll();
                        btnAdd.ButtonText = "Sửa";
                        chiTiet = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                        return;
                    }
                }
            }
        }
    }
}
