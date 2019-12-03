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
        public QLNV()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new CoffeeManagement.transparentBg1(this, new QLNV_NV());
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            dataGridNhanVien.Rows.Clear();
            for(int i=0;i<10;i++)
                dataGridNhanVien.Rows.Add(new object[]{"asdasd","asdasd","asdasd","adasd","adasd","asdasd" });
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridNhanVien.SelectedRows.Count.ToString());
        }
    }
}
