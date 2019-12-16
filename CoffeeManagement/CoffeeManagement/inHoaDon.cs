using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
namespace CoffeeManagement
{
    public partial class inHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public inHoaDon(string _price, string _date,string _mahd,string _name)
        {
            InitializeComponent();
            price.Text = _price;
            date.Text = _date;
            lb_mahd.Text = _mahd;
            lb_tennv.Text = _name;
           
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
