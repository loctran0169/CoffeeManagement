using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace CoffeeManagement
{
    public partial class inBaoCao : DevExpress.XtraReports.UI.XtraReport
    {
        public inBaoCao(string _tag,string _name,DateTime date, string _price)
        {
            InitializeComponent();
            lb_tennv.Text = _name;
            lb_tag.Text = _tag;
            lb_date.Text = date.ToString("MM/yyyy");
            price.Text = _price;
            if (_tag == "BÁO CÁO KHO")
            {
                price.Visible = false;
                lb_sum.Visible = false;
            }
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
