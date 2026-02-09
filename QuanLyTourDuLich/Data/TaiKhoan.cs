using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Data
{
    internal class TaiKhoan
    {
        public int ID { get; set; }

        public string TenDangNhap { get; set; } = null!;

        public string MatKhau { get; set; } = null!;

        // 0 = Nhân viên, 1 = Quản lý
        public int Quyen { get; set; }
    }
}
