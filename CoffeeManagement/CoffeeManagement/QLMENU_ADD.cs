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
    public partial class QLMENU_ADD : Form
    {
        private string menuId;
        private string tag;
        private bool chiTiet = true;
        SanPhamBUS bus = new SanPhamBUS();

        public QLMENU_ADD(string _menuID, string _tag)
        {
            InitializeComponent();
            this.menuId = _menuID;
            this.tag = _tag;
            if (tag == "Thêm")
                btn_save.ButtonText = "Lưu";
            else if (tag == "Chi Tiết")
            {
                btn_save.ButtonText = "Sửa";
                loadData();
                disabledForm();
            }
        }

        private void loadData()
        {
            DataTable dt = bus.load1SP(menuId);
            if (dt != null && dt.Rows.Count > 0)
            {
                tb_name_SP.Text = dt.Rows[0][1].ToString();
                tb_price_SP.Text = dt.Rows[0][3].ToString();
                tb_unit_SP.Text = dt.Rows[0][2].ToString();
                // tb_note_SP.Text = dt.Rows[0][4].ToString();
            }
            else
                MessageBox.Show("không có");
        }

        private bool checkInfor()
        {
            if (tb_name_SP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                tb_name_SP.Focus();
                return false;
            }
            else if (tb_price_SP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm");
                tb_price_SP.Focus();
                return false;
            }
            else if (tb_unit_SP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị của sản phẩm");
                tb_unit_SP.Focus();
                return false;
            }
           
            else if (tb_note_SP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ghi chú sản phẩm");
                tb_note_SP.Focus();
                return false;
            }
            return true;
        }

        public void enabledForm()
        {
            tb_name_SP.Enabled = true;
            tb_price_SP.Enabled = true;
            tb_unit_SP.Enabled = true;
            tb_note_SP.Enabled = true;
        }

        public void disabledForm()
        {
            tb_name_SP.Enabled = false;
            tb_price_SP.Enabled = false;
            tb_unit_SP.Enabled = false;
            tb_note_SP.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tag == "Thêm")
            {
                if (checkInfor() == false)
                    return;
                SanPhamDTO sp = new SanPhamDTO();
                sp.TenSP1 = tb_name_SP.Text;
                sp.DonGia1 = float.Parse(tb_price_SP.Text);
                sp.MaDV1 = tb_unit_SP.Text;
                sp.GhiChu1 = tb_note_SP.Text;
                MessageBox.Show(tb_unit_SP.Text);
                bool kq = bus.them(sp);
                if (kq == true)
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công! Vui lòng thử lại.");
                    return;
                }
            }
            else if (tag == "Chi tiết")
                if (chiTiet)
                {
                    btn_save.ButtonText = "Lưu";
                    enabledForm();
                    chiTiet = false;
                }
                else
                {
                    if (checkInfor() == false) return;
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSP1 = menuId;
                    sp.TenSP1 = tb_name_SP.Text;
                    sp.DonGia1 = float.Parse(tb_price_SP.Text);
                    sp.TenDV1 = tb_unit_SP.Text;
                    sp.GhiChu1 = tb_note_SP.Text;
                    bool kq = bus.sua(sp);
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa thông tin sản phẩm thành công");
                        disabledForm();
                        btn_save.ButtonText = "Sửa";
                        chiTiet = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm không thành công");
                        return;
                    }
                }
        }

        private void btn_back_SP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}