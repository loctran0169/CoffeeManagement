using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatDTO
    {
        private string MaPX;
        private string MaNV;
        private DateTime NgayXuat;
        private string DiaChi;
        private string TinhTrang;
        private float TongTien;

        public string MaPX1 { get => MaPX; set => MaPX = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayXuat1 { get => NgayXuat; set => NgayXuat = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
