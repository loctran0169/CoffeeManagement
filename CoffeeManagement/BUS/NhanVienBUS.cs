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
    public class NhanVienBUS
    {
        private NhanVienDAL nvDAL;
        public NhanVienBUS()
        {
            nvDAL = new NhanVienDAL();
        }
        public DataTable loadDuLieuNhanVien()
        {
            DataTable k = new DataTable();
            k = nvDAL.loadDuLieuNhanVien();
            return k;

        }
        public DataTable loadToDataTable()
        {
            return nvDAL.loadDuLieuNhanVien();
        }
        public DataTable loadDuLieuNhanVienTuMaUsers(string Manv)
        {
            DataTable k = new DataTable();
            k = nvDAL.loadDuLieuNhanVienTuMaUsers(Manv);
            return k;

        }
        public bool them(NhanVienDTO nvDTO)
        {
            bool re = nvDAL.them(nvDTO);

            return re;
        }
        public bool sua(NhanVienDTO nvDTO)
        {
            bool re = nvDAL.sua(nvDTO);

            return re;
        }
        public bool xoa(NhanVienDTO nvDTO)
        {
            bool re = nvDAL.xoa(nvDTO);

            return re;
        }
        public DataTable selectByKeyWord(string s)
        {
            return nvDAL.selectByKeyWord(s);
        }
        public DataTable loadOneNhanVien(string s)
        {
            return nvDAL.loadOneNhanVien(s);
        }
        public DataTable loadNhanViewDangNhap(string s)
        {
            return nvDAL.loadNhanViewDangNhap(s);
        }
    }
}
