using BUS;
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
    public partial class ORDER : Form
    {
        ImageList imageList = new ImageList();
        SanPhamBUS busSP = new SanPhamBUS();
        DataTable dtSP = new DataTable();
        public ORDER()
        {
            InitializeComponent();
            imageList.ImageSize = new Size(80, 80);
        }
        private void ORDER_Load(object sender, EventArgs e)
        {
            
        }

        public void loadSP(string key)
        {
            listSP.LargeImageList = imageList;
            this.Invoke(new MethodInvoker(delegate
            {
                dtSP = busSP.loadToDataTable();
                if (dtSP.Rows.Count > 0)
                {
                    int i = 0;
                    foreach (DataRow row in dtSP.Rows)
                    {
                        Image image = Image.FromFile(row[3].ToString());
                        imageList.Images.Add(image);
                        ListViewItem item = new ListViewItem();
                        item.Text = row[1].ToString();
                        item.ImageIndex = i; i++;
                        listSP.Items.Add(item);
                    }
                }
            }));
        }

        public void loadListImage()
        {            
            
            for (int i = 0; i < 10; i++)
            {
                Image image = Image.FromFile("C:\\Users\\LQTPL\\Pictures\\Saved Pictures\\Thanh-Phong-Tom-Phan-2-Cu-dam-Huy-Diet.png");
                imageList.Images.Add(image);
            }
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa in được");
        }       
    }
}
