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
    public partial class QLDV_ADD : Form
    {
        DonViBUS bus = new DonViBUS();
        private string MaDV;
        private string tag;
        private bool chiTiet = true;
        public QLDV_ADD(string _id,string _tag)
        {
            InitializeComponent();
            this.MaDV = _id;
            this.tag = _tag;
        }

        private void QLDV_ADD_Load(object sender, EventArgs e)
        {
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
            tb_note.Enabled = true;
        }

        public void disableAll()
        {
            tb_name.Enabled = false;
            tb_note.Enabled = false;
        }

        public void loadData()
        {
            DataTable dt = bus.loadDV(MaDV);
            if (dt != null && dt.Rows.Count > 0)
            {
                tb_name.Text = dt.Rows[0][2].ToString();
                tb_note.Text = dt.Rows[0][3].ToString();
            }
            else
                MessageBox.Show("không có");
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {           
            if (tag == "Thêm")
            {
                if (!checkData()) return;
                bool kq = bus.them(new DTO.DonViDTO(tb_name.Text, tb_note.Text));
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
                    DonViDTO dv = new DonViDTO()
                    {
                        MaDV1 = MaDV,
                        TenDV1 = tb_name.Text,
                        GhiChu1 = tb_note.Text
                    };
                    bool kq = bus.sua(dv);
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
        public bool checkData()
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đơn vị");
                tb_name.Focus();
            }
            return true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
