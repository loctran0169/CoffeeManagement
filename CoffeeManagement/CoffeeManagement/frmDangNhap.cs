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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk.Text) || string.IsNullOrEmpty(txt_mk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                TaiKhoanDTO us = new TaiKhoanDTO();
                us.TaiKhoan1 = txt_tk.Text;
                us.MatKhau1 = txt_mk.Text;
                if (txt_tk.Text == "1" && txt_mk.Text == "1")
                {
                    MessageBox.Show("Tài khoản mật khẩu bị từ chối");
                    return;
                }
                TaiKhoanBUS bus = new TaiKhoanBUS();
                DataTable k = bus.dangNhap(us);
                if (k.Rows.Count > 0)
                {
                    //gán các thông tin của người đăng nhập cho user
                    us.MaTK1 = k.Rows[0][1].ToString();
                    NhanVienBUS busNV = new NhanVienBUS();
                    DataTable nv = busNV.loadNhanViewDangNhap(us.MaTK1);
                    if (nv != null)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        frmGui f = new frmGui(new NhanVienDTO() {
                            MaNV1 = nv.Rows[0][1].ToString(),
                            TenNV1 = nv.Rows[0][2].ToString(),
                            NgaySinh1 = DateTime.Parse(nv.Rows[0][3].ToString()),
                            GioiTinh1 = nv.Rows[0][4].ToString(),
                            DiaChi1= nv.Rows[0][5].ToString(),
                            SDT1= nv.Rows[0][6].ToString(),
                            Email1= nv.Rows[0][7].ToString(),
                            MaTK1=us.MaTK1,
                            GhiChu1= nv.Rows[0][9].ToString()
                        });
                        this.Hide();
                        f.ShowDialog();//hiển thị form chính 
                    }                   
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
