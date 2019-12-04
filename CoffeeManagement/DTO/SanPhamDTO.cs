using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private string MaSP;
        private string TenSP;
        private string HinhAnh;
        private string MaDV;
        private float DonGia;

        public string MaSP1 { get => MaSP; set => MaSP = value; }
        public string TenSP1 { get => TenSP; set => TenSP = value; }
        public string HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }
        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public float DonGia1 { get => DonGia; set => DonGia = value; }
    }
}
