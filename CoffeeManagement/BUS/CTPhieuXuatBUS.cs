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
    public class CTPhieuXuatBUS
    {
        private CTPhieuXuatDAL bdal;

        public CTPhieuXuatBUS()
        {
            bdal = new CTPhieuXuatDAL();
        }
        public bool them(CTPhieuXuatDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(string lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }
        public DataTable loadDuLieuChiTietPhieuXuat(string hd)
        {
            return bdal.loadDuLieuChiTietPhieuXuat(hd);
        }
        public DataTable loadInfo(string s)
        {
            return bdal.loadInfo(s);
        }

        public DataSet loadCTPhieuXuat(string s)
        {
            return bdal.loadCTPhieuXuat(s);
        }
        public bool updateData(DataTable ds)
        {
            return bdal.updateData(ds);
        }
    }
}
