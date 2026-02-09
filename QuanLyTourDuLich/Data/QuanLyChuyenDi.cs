using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Data
{
    public class QuanLyChuyenDi
    {
        public int ID { get; set; }              
        public int TuyenDuLichID { get; set; } 
        public DateTime GioKhoiHanh { get; set; }

        public virtual QuanLyTuyen TuyenDuLich { get; set; } = null!;
        public virtual ObservableCollectionListSource<QuanLyDatVe> DatVe { get; } = new();
    }
}
