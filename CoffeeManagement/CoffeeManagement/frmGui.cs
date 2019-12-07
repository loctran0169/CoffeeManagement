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
    public partial class frmGui : Form
    {
        private bool isShow = true;
        TaiKhoanDTO us = new TaiKhoanDTO();
        public frmGui(TaiKhoanDTO _us)
        {
            InitializeComponent();
            this.us = _us;
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_hoadon.Height;
            pnl_leftbar.Top = btn_hoadon.Top;
            Form frm = kiemtraform(typeof(QLHD));
            if (frm == null)
            {
                QLHD forms = new QLHD();
                forms.TopLevel = false;
                panel3.Controls.Clear();
                panel3.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
            changeColor(btn_hoadon);
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.panel3.Controls)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_nhanvien.Height;
            pnl_leftbar.Top = btn_nhanvien.Top;
            Form frm = kiemtraform(typeof(QLNV));
            if (frm == null)
            {
                QLNV forms = new QLNV();
                forms.TopLevel = false;
                panel3.Controls.Clear();
                panel3.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
            changeColor(btn_nhanvien);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_banhang.Height;
            pnl_leftbar.Top = btn_banhang.Top;
            changeColor(btn_banhang);
        }

        private void btn_douong_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_douong.Height;
            pnl_leftbar.Top = btn_douong.Top;
            changeColor(btn_douong);
        }

        private void btn_nguyenlieu_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_nguyenlieu.Height;
            pnl_leftbar.Top = btn_nguyenlieu.Top;
            changeColor(btn_nguyenlieu);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_nhaphang.Height;
            pnl_leftbar.Top = btn_nhaphang.Top;
            changeColor(btn_nhaphang);
        }

        private void btn_xuathang_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_xuathang.Height;
            pnl_leftbar.Top = btn_xuathang.Top;
            changeColor(btn_xuathang);
        }

        private void btn_donvi_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_donvi.Height;
            pnl_leftbar.Top = btn_donvi.Top;
            changeColor(btn_donvi);
        }
        public void changeColor(Bunifu.Framework.UI.BunifuFlatButton tb)
        {
            foreach(Control i in panel2.Controls)
            {
                if (i.GetType()==tb.GetType())
                {
                    if((i as Bunifu.Framework.UI.BunifuFlatButton)==tb)
                        (i as Bunifu.Framework.UI.BunifuFlatButton).Textcolor = Color.FromArgb(26, 188, 156);
                    else
                        (i as Bunifu.Framework.UI.BunifuFlatButton).Textcolor = Color.White;
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (!isShow)
            {
                isShow = false;
                panel2.Width = 200;
                panel2.Visible = false;
                
                panel_animation.ShowSync(panel2);
                //logo_animation.ShowSync(btn_menu);    
            }
            else
                isShow = true;
                //logo_animation.Hide(btn_menu);
                panel2.Visible = false;
                panel2.Width = 50;
                panel_animation.ShowSync(panel2);
        }


    }
}
