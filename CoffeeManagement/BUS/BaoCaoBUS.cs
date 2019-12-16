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
    public class BaoCaoBUS
    {
        private BaoCaoDAL bdal;

        public BaoCaoBUS()
        {
            bdal = new BaoCaoDAL();
        }
        public DataTable loadDuLieuDoanhThu(int month, int year)
        {
            return bdal.loadDuLieuDoanhThu(month,year);
        }

        public DataTable loadDuLieuKho(int month, int year)
        {
            return bdal.loadDuLieuKho(month, year);
        }

        public bool them(BaoCaoDTO bc)
        {
            return bdal.them(bc);
        }
        public DataTable loadBaoCao(string bc)
        {
            return bdal.loadBaoCao(bc);
        }

        public DataTable loadBaoCaoAll()
        {
            return bdal.loadBaoCaoAll();
        }
        public DataTable selectByKeyWordDV(string s)
        {
            return bdal.selectByKeyWordDV(s);
        }
    }
}
