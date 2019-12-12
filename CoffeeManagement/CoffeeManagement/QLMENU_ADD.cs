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
        private string userId;
        private string tag;
        private bool chiTiet = true;
        SanPhamBUS bus = new SanPhamBUS();

        public QLMENU_ADD(string _userID, string _tag)
        {
            InitializeComponent();
            this.userId = _userID;
            this.tag = _tag;
            if (tag == "Thêm")
                btn_save.ButtonText = "Lưu";
            else if (tag == "Chi Tiết")
            {
                btn_save.ButtonText = "Sửa";
                loadData();
                //disableAll();
            }
        }
            private void loadData()
            {
                //DataTable dt = bus.load1SP(userId);
                //if (dt != null && dt.Rows.Count > 0)
                //{
                   
                //}
                //else
                //    MessageBox.Show("không có");
            }
        }
}
