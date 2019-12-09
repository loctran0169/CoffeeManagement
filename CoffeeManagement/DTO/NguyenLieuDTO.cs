using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        private string MaNL;
        private string TenNL;
        private string MaDV;
        private float SoLuongTon;
        private float GiaNhap;
        private float GiaBan;

        public string MaNL1 { get => MaNL; set => MaNL = value; }
        public string TenNL1 { get => TenNL; set => TenNL = value; }
        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public float SoLuongTon1 { get => SoLuongTon; set => SoLuongTon = value; }
        public float GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
        public float GiaBan1 { get => GiaBan; set => GiaBan = value; }
    }
}
