using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string MaHD;
        private string MaNV;
        private DateTime NgayLap;
        private float TongTien;

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayLap1 { get => NgayLap; set => NgayLap = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
