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
    public class NguyenLieuBUS
    {
        private NguyenLieuDAL bdal;

        public NguyenLieuBUS()
        {
            bdal = new NguyenLieuDAL();
        }
        public bool them(NguyenLieuDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(NguyenLieuDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(NguyenLieuDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<NguyenLieuDTO> select()
        {
            return bdal.select();
        }
        public List<NguyenLieuDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
        public DataTable loadDuLieuNguyenLieu()
        {
            return bdal.loadDuLieuNguyenLieu();
        }
        public DataTable loadDuLieuDonViTinh()
        {
            return bdal.loadDuLieuDonViTinh();
        }
        public DataTable loadToCombobox()
        {
            return bdal.loadToCombobox();
        }
    }
}
