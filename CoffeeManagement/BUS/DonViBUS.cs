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
    public class DonViBUS
    {
        private DonViDAL bdal;
        public DonViBUS()
        {
            bdal = new DonViDAL();
        }
        public bool them(DonViDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(DonViDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(DonViDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<DonViDTO> select()
        {
            return bdal.select();
        }

        public List<DonViDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }

        public DataTable loadDuLieuDonViTinh()
        {
            return bdal.loadDuLieuDonViTinh();
        }

        public DataTable SelectByKeyWordDV(string sKeyword)
        {
            return bdal.selectByKeyWordDV(sKeyword);
        }
    }
}
