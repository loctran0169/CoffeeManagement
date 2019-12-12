using BUS;
using DAL;
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
    public partial class QLNV_NV : Form
    {
        private string userId;
        private string tag;
        private bool chiTiet = true;
        NhanVienBUS bus = new NhanVienBUS();
        public QLNV_NV(string _userID, string _tag)
        {
            InitializeComponent();
            this.userId = _userID;
            this.tag = _tag;
            if (tag == "Thêm")
                btn_action.ButtonText = "Lưu";
            else if (tag == "Chi Tiết")
            {
                btn_action.ButtonText = "Sửa";
                loadData();
                disableAll();
            }
        }

        private bool checkData()
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
                tb_name.Focus();
                return false;
            }
            else if (date_birth.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh");
                return false;

            }
            else if (tb_email.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email");
                tb_email.Focus();
                return false;
            }
            else if (tb_sdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                tb_sdt.Focus();
                return false;
            }
            else if (tb_diachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                tb_diachi.Focus();
                return false;
            }
            return true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (tag == "Thêm")
            {
                if (checkData() == false) return;
                NhanVienDTO nv = new NhanVienDTO();
                nv.TenNV1 = tb_name.Text;
                if (cb_nam.Checked == true)
                    nv.GioiTinh1 = "Nam";
                else
                    nv.GioiTinh1 = "Nữ";
                nv.NgaySinh1 = date_birth.Value.Date;
                nv.Email1 = tb_email.Text;
                nv.SDT1 = tb_sdt.Text;
                nv.DiaChi1 = tb_diachi.Text;
                nv.GhiChu1 = tb_ghichu.Text;
                bool kq = bus.them(nv);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                    return;
                }
            }
            else if(tag=="Chi Tiết")
            {
                if (chiTiet)
                {
                    btn_action.ButtonText = "Lưu";
                    enableAll();
                    chiTiet = false;
                }
                else
                {
                    if (checkData() == false) return;
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNV1 = userId;
                    nv.TenNV1 = tb_name.Text;
                    if (cb_nam.Checked == true)
                        nv.GioiTinh1 = "Nam";
                    else
                        nv.GioiTinh1 = "Nữ";
                    nv.NgaySinh1 = date_birth.Value.Date;
                    nv.Email1 = tb_email.Text;
                    nv.SDT1 = tb_sdt.Text;
                    nv.DiaChi1 = tb_diachi.Text;
                    nv.GhiChu1 = tb_ghichu.Text;
                    bool kq = bus.sua(nv);
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        disableAll();
                        btn_action.ButtonText = "Sửa";
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
        private void loadData()
        {
            DataTable dt = bus.loadOneNhanVien(userId);
            if (dt != null && dt.Rows.Count > 0)
            {
                tb_name.Text = dt.Rows[0][2].ToString();
                if (dt.Rows[0][4].ToString() == "Nam")
                {
                    cb_nam.Checked = true;
                    cb_nu.Checked = false;
                }
                else
                {
                    cb_nam.Checked = false;
                    cb_nu.Checked = true;
                }
                date_birth.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                tb_diachi.Text = dt.Rows[0][5].ToString();
                tb_sdt.Text = dt.Rows[0][6].ToString();
                tb_email.Text = dt.Rows[0][7].ToString();
            }
            else
                MessageBox.Show("không có");
        }

        public void enableAll()
        {
            tb_name.Enabled = true;
            tb_diachi.Enabled = true;
            tb_email.Enabled = true;
            tb_ghichu.Enabled = true;
            tb_sdt.Enabled = true;
            cb_nam.Enabled = true;
            cb_nu.Enabled = true;
            date_birth.Enabled = true;
        }

        public void disableAll()
        {
            tb_name.Enabled = false;
            tb_diachi.Enabled = false;
            tb_email.Enabled = false;
            tb_ghichu.Enabled = false;
            tb_sdt.Enabled = false;
            cb_nam.Enabled = false;
            cb_nu.Enabled = false;
            date_birth.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
