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
        public NhanVienDTO NV;
        public frmGui(NhanVienDTO _nv)
        {
            InitializeComponent();
            this.NV = _nv.copyOf();
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
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
            changeColor(btn_hoadon);
        }
        
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_nhanvien.Height;
            pnl_leftbar.Top = btn_nhanvien.Top;            
            changeColor(btn_nhanvien);
            Form frm = kiemtraform(typeof(QLNV));
            if (frm == null)
            {
                QLNV forms = new QLNV();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_banhang.Height;
            pnl_leftbar.Top = btn_banhang.Top;
            changeColor(btn_banhang);
            Form frm = kiemtraform(typeof(ORDER));
            if (frm == null)
            {
                ORDER forms = new ORDER();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_douong_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_douong.Height;
            pnl_leftbar.Top = btn_douong.Top;
            changeColor(btn_douong);
            Form frm = kiemtraform(typeof(QLMENU));
            if (frm == null)
            {
                QLMENU forms = new QLMENU();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_nguyenlieu_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_nguyenlieu.Height;
            pnl_leftbar.Top = btn_nguyenlieu.Top;
            changeColor(btn_nguyenlieu);
            Form frm = kiemtraform(typeof(QLK));
            if (frm == null)
            {
                QLK forms = new QLK();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_nhaphang.Height;
            pnl_leftbar.Top = btn_nhaphang.Top;
            changeColor(btn_nhaphang);
            Form frm = kiemtraform(typeof(QLPN));
            if (frm == null)
            {
                QLPN forms = new QLPN();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_xuathang_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_xuathang.Height;
            pnl_leftbar.Top = btn_xuathang.Top;
            changeColor(btn_xuathang);
            Form frm = kiemtraform(typeof(QLPX));
            if (frm == null)
            {
                QLPX forms = new QLPX();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_donvi_Click(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_donvi.Height;
            pnl_leftbar.Top = btn_donvi.Top;
            changeColor(btn_donvi);
            Form frm = kiemtraform(typeof(QLDV));
            if (frm == null)
            {
                QLDV forms = new QLDV();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        public void changeColor(Bunifu.Framework.UI.BunifuFlatButton tb)
        {
            foreach(Control i in drawer.Controls)
            {
                if (i.GetType()==tb.GetType())
                {
                    if ((i as Bunifu.Framework.UI.BunifuFlatButton) == tb)
                        (i as Bunifu.Framework.UI.BunifuFlatButton).Textcolor = Color.FromArgb(26, 188, 156);
                    else
                        (i as Bunifu.Framework.UI.BunifuFlatButton).Textcolor = Color.White;
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (isShow)
            {
                isShow = false;
                drawer.Width = 50;
                drawer.Visible = false;
                tshow.Show(drawer);                           

            }
            else
            {
                isShow = true;
                drawer.Width = 200;
                drawer.Visible = false;
                tshow.ShowSync(drawer);
            }
        }

        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.content.Controls)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void frmGui_Load(object sender, EventArgs e)
        {
            pnl_leftbar.Height = btn_banhang.Height;
            pnl_leftbar.Top = btn_banhang.Top;
            changeColor(btn_banhang);
            Form frm = kiemtraform(typeof(ORDER));
            if (frm == null)
            {
                ORDER forms = new ORDER();
                forms.TopLevel = false;
                content.Controls.Clear();
                content.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}
