using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string MaTK;
        private string TaiKhoan;
        private string MatKhau;
        private string MaPQ;
        private string GhiChu;

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(string maTK, string taiKhoan, string matKhau, string maPQ, string ghiChu)
        {
            MaTK = maTK;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            MaPQ = maPQ;
            GhiChu = ghiChu;
        }

        public string MaTK1 { get => MaTK; set => MaTK = value; }
        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string MaPQ1 { get => MaPQ; set => MaPQ = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    }
}
