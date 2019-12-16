using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace CoffeeManagement
{
    public partial class inNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public inNhapXuat(string _price, string _date,string _tag, string _name, string diachi)
        {
            InitializeComponent();
            price.Text = _price;
            date.Text = _date;
            tag.Text = _tag;
            lb_name.Text = _name;
            lb_dc.Text = diachi;
        }

        public GridControl control;
        public GridControl GridControl
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
                print.PrintableComponent = control;
            }
        }
    }
}
