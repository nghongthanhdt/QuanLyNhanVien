using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Models
{
    public class NguoiDung
    {
        public int MaNguoiDung;
        public string HoTen;
        public string TenDangNhap;
        public string MatKhau;
        public string MaKhoa;
        public string TenKhoa;
        public List<ChucNang> ListChucNang;
    }

    public class ChucNang
    {
        public string MaChucNang;
        public string TenChucNang;
    }
}
