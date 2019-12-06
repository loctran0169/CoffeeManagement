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
        TaiKhoanDTO us = new TaiKhoanDTO();
        public frmGui(TaiKhoanDTO _us)
        {
            InitializeComponent();
            this.us = _us;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form frm = kiemtraform(typeof(QLHD));
            if (frm == null)
            {
                QLHD forms = new QLHD();
                forms.TopLevel = false;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(forms);
                forms.Dock = DockStyle.Fill;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.mainPanel.Controls)
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
            Form frm = kiemtraform(typeof(QLNV));
            if (frm == null)
            {
                QLNV forms = new QLNV();
                forms.TopLevel = false;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(forms);
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
            
        }
    }
}
