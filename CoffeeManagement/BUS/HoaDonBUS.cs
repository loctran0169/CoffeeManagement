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
    public class HoaDonBUS
    {
        private HoaDonDAL bdal;

        public HoaDonBUS()
        {
            bdal = new HoaDonDAL();
        }
        public bool them(HoaDonDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(HoaDonDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(HoaDonDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<HoaDonDTO> select()
        {
            return bdal.select();
        }
        public DataTable selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
        public DataTable loadToDataTable()
        {
            return bdal.loadToDataTable();
        }
        public DataTable loadToDataTable(DateTime a, DateTime b)
        {
            return bdal.loadToDataTable(a,b);
        }
        public DataTable loadMaHD()
        {
            return bdal.loadMaHD();
        }
        
    }
}
