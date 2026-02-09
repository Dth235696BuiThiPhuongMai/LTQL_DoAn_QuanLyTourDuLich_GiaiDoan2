using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;

namespace QuanLyTourDuLich.Data
{
    internal class QuanLyTourDbContext : DbContext
    {
        public DbSet<QuanLyTuyen> TuyenDuLich { get; set; }
        public DbSet<QuanLyChuyenDi> ChuyenDi { get; set; }
        public DbSet<QuanLyNhanVien> NhanVien { get; set; }
        public DbSet<QuanLyKhachHang> KhachHang { get; set; }
        public DbSet<QuanLyDatVe> DatVe { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLTDLConnection"].ConnectionString);
        }

    }
}
