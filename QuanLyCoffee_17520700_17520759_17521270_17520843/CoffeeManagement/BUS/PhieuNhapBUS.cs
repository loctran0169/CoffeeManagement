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
    public class PhieuNhapBUS
    {
        private PhieuNhapDAL bdal;

        public PhieuNhapBUS()
        {
            bdal = new PhieuNhapDAL();
        }

        public bool them(PhieuNhapDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(PhieuNhapDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(PhieuNhapDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public DataTable loadMaPX(DateTime date)
        {
            return bdal.loadMaPX(date);
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
