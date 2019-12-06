﻿using BUS;
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
    public partial class QLNV : Form
    {
        DataTable dt = new DataTable();
        NhanVienBUS bus = new NhanVienBUS();
        public QLNV()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(this,new QLNV_NV("",false));
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(dataGridNhanVien.SelectedRows.Count.ToString());
        }
        private void loadData()
        {
            dt = bus.loadToDataTable();
            if (dt.Rows.Count > 0)
            {
                bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                bunifuDataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("Không có thông tin hóa đơn");
        }

        private void tb_name_nv_OnIconRightClick(object sender, EventArgs e)
        {
            dt = bus.selectByKeyWord(tb_name_nv.Text);
            if (dt.Rows.Count > 0)
            {
                bunifuDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                
            }
            else
            {
                dt.Rows.Clear();
            }
            bunifuDataGridView1.DataSource = dt;
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;       
            new CoffeeManagement.transparentBg1(this, new QLNV_NV(dt.Rows[0][0].ToString(),true));
        }
    }
}
