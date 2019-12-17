using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanQuyenBUS
    {
        private PhanQuyenDAL qhDAL;
        public PhanQuyenBUS()
        {
            qhDAL = new PhanQuyenDAL();

        }
        public DataTable loadDuLieuQuyenHan()
        {
            DataTable k = new DataTable();
            k = qhDAL.loadDuLieuQuyenHan();
            return k;

        }
    }
}
