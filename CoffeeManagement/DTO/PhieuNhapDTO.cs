﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string MaPN;
        private string MaNV;
        private DateTime NgayNhap;
        private string TinhTrang;
        private float TongTien;

        public string MaPN1 { get => MaPN; set => MaPN = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
    }
}


