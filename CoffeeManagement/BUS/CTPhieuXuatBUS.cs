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

        public bool xoa(CTPhieuXuatDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }
        public DataTable loadDuLieuChiTietPhieuXuat(string hd)
        {
            return bdal.loadDuLieuChiTietPhieuXuat(hd);
        }
    }
}
