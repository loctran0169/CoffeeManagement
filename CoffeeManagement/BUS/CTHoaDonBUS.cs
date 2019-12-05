using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHoaDonBUS
    {
        private CTHoaDonDAL bdal;
        public CTHoaDonBUS()
        {
            bdal = new CTHoaDonDAL();
        }
        public bool them(CTHoaDonDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(CTHoaDonDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }
        public DataTable loadData(string hd)
        {
            return bdal.loadDuLieuChiTietHoaHon(hd);
        }
    }
}
