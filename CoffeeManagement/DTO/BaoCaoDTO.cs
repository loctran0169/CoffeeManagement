using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoDTO
    {
        private string MaBC;
        private string MaNV;
        private string Loai;
        private DateTime ThoiGian;

        public string MaBC1 { get => MaBC; set => MaBC = value; }
        public string Loai1 { get => Loai; set => Loai = value; }
        public DateTime ThoiGian1 { get => ThoiGian; set => ThoiGian = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
    }
}
