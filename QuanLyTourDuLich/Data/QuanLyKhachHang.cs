using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Data
{
    public class QuanLyKhachHang
    {
        public int ID { get; set; }           
        public string? HoTen { get; set; }     
        public string? DienThoai { get; set; } 
        public string? DiaChi { get; set; }    
        public string? Email { get; set; }
        public string?  GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }


        public virtual ObservableCollectionListSource<QuanLyDatVe> DatVe { get; } = new();
    }
}
