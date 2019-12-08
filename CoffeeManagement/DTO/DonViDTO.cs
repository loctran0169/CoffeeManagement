using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonViDTO
    {
        private string MaDV;
        private string TenDV;
        private string GhiChu;

        public DonViDTO()
        {
        }

        public DonViDTO(string tenDV, string ghiChu)
        {
            TenDV = tenDV;
            GhiChu = ghiChu;
        }

        public DonViDTO(string maDV, string tenDV, string ghiChu)
        {
            MaDV = maDV;
            TenDV = tenDV;
            GhiChu = ghiChu;
        }

        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public string TenDV1 { get => TenDV; set => TenDV = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    }
}
