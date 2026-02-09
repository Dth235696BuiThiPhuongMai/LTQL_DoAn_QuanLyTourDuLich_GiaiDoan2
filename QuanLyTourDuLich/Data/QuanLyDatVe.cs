using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Data
{
    public class QuanLyDatVe
    {
        public int ID { get; set; }            

        public int ChuyenDiID { get; set; }    
        public int KhachHangID { get; set; }   
        public int NhanVienID { get; set; }    
        public int SoLuongVe { get; set; }     
        public int TongTien { get; set; }      
        public DateTime NgayDat { get; set; }

        public virtual QuanLyChuyenDi ChuyenDi { get; set; } = null!;
        public virtual QuanLyKhachHang KhachHang { get; set; } = null!;
        public virtual QuanLyNhanVien NhanVien { get; set; } = null!;
    
}
}
