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
        DonViBUS dvBus = new DonViBUS();
        SanPhamBUS bus = new SanPhamBUS();
        DataTable dvt = new DataTable();
        List<string> list = new List<string>();
        string fileName = "";
        public QLMENU_ADD(string _menuID, string _tag)
        {
            InitializeComponent();
            this.menuId = _menuID;
            this.tag = _tag;            
        }

        public void loadDV()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                dvt = dvBus.loadDuLieuDonViTinh();
                if (dvt.Rows.Count > 0)
                {
                    list = dvt.AsEnumerable()
                    .Select(r => r.Field<string>("madv"))
                    .ToList();
                    foreach (DataRow row in dvt.Rows)
                    {
                        cb_unit_SP.Items.Add("  " + row[1]);
                    }
                }
            }));
        }

        private void loadData()
        {
            DataTable dt = bus.load1SP(menuId);
            if (dt != null && dt.Rows.Count > 0)
            {
                tb_name_SP.Text = dt.Rows[0][2].ToString();
                cb_unit_SP.SelectedIndex = 2;
                tb_price_SP.Text = dt.Rows[0][5].ToString();
                tb_note_SP.Text = dt.Rows[0][6].ToString();
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
            else if (cb_unit_SP.SelectedIndex==-1)
            {
                MessageBox.Show("Vui lòng nhập đơn vị của sản phẩm");
                return false;
            }
           else if(fileName=="")
            {
                MessageBox.Show("Vui lòng chọn ảnh sản phẩm");
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
            cb_unit_SP.Enabled = true;
            tb_note_SP.Enabled = true;
            btn_img.Enabled = true;
        }

        public void disabledForm()
        {
            tb_name_SP.Enabled = false;
            tb_price_SP.Enabled = false;
            cb_unit_SP.Enabled = false;
            tb_note_SP.Enabled = false;
            btn_img.Enabled = false;
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
                sp.MaDV1 = list[cb_unit_SP.SelectedIndex];
                sp.HinhAnh1 = fileName;
                sp.GhiChu1 = tb_note_SP.Text;           
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
            else if (tag == "Chi Tiết")
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
                    sp.MaDV1 = list[cb_unit_SP.SelectedIndex];
                    sp.HinhAnh1 = fileName;
                    sp.GhiChu1 = tb_note_SP.Text;
                    bool kq = bus.sua(sp);
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa thông tin sản phẩm thành công");
                        disabledForm();
                        btn_save.ButtonText = "Sửa";
                        chiTiet = true;
                        this.Close();
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
            MessageBox.Show(Application.OpenForms.Count.ToString());
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_unit_SP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QLMENU_ADD_Load(object sender, EventArgs e)
        {
            loadDV();
            if (tag == "Thêm")
                btn_save.ButtonText = "Lưu";
            else if (tag == "Chi Tiết")
            {
                btn_save.ButtonText = "Sửa";
                loadData();
                disabledForm();
            }
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = open.FileName;
            }
        }

        private void tb_price_SP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}