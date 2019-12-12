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
    public class CTPhieuNhapBUS
    {
        private CTPhieuNhapDAL bdal;

        public CTPhieuNhapBUS()
        {
            bdal = new CTPhieuNhapDAL();
        }
        public bool them(CTPhieuNhapDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(string lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }
        public DataTable loadDuLieuChiTietPhieuNhap(string hd)
        {
            return bdal.loadDuLieuChiTietPhieuNhap(hd);
        }
        public DataTable loadInfo(string s)
        {
            return bdal.loadInfo(s);
        }

        public DataSet loadCTphieunhap(string s)
        {
            return bdal.loadctphieunhap(s);
        }
        public bool updateData(DataTable ds)
        {
            return bdal.updateData(ds);
        }
    }
}
