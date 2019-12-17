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
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL bdal;
        public TaiKhoanBUS()
        {
            bdal = new TaiKhoanDAL();
        }
        public bool them(TaiKhoanDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }
        public bool xoa(TaiKhoanDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }
        public bool sua(TaiKhoanDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }
        public bool suamk(TaiKhoanDTO lb)
        {
            bool re = bdal.suamk(lb);
            return re;
        }
        public DataTable loadDuLieuUsers()
        {
            return bdal.loadDuLieuUsers();
        }
        public DataTable dangNhap(TaiKhoanDTO us)
        {
            return bdal.dangNhap(us);
        }
    }
}
