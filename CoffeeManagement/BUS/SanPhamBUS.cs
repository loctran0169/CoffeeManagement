﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL bdal;

        public SanPhamBUS()
        {
            bdal = new SanPhamDAL();
        }
        public bool them(SanPhamDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(SanPhamDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(SanPhamDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<SanPhamDTO> select()
        {
            return bdal.select();
        }
     

        public DataTable selectByKeyWord(string sKeyWord)
        {
            return bdal.selectByKeyWord(sKeyWord);
        }

        public DataTable loadToDataTable()
        {
            return bdal.loadDuLieuSanPham();
        }

        public DataTable load1SP(string s)
        {
            return bdal.load1SP(s);
        }

        public DataTable loadToCombobox()
        {
            return bdal.loadToCombobox();
        }
    }
}
