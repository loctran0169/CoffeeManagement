using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string MaNV;
        private string TenNV;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private string MaTK;
        private string GhiChu;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string MaTK1 { get => MaTK; set => MaTK = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    }
}
