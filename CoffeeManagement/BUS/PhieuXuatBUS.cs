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
    public class PhieuXuatBUS
    {
        private PhieuXuatDAL bdal;

        public PhieuXuatBUS()
        {
            bdal = new PhieuXuatDAL();
        }

        public bool them(PhieuXuatDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(PhieuXuatDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(PhieuXuatDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public DataTable selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }

        public DataTable loadToDataTable()
        {
            return bdal.loadToDataTable();
        }
    }
}
