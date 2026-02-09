using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Data
{
    public class QuanLyTuyen
    {
        public int ID { get; set; }
        public string? DiemDi { get; set; }
        public string? DiemDen { get; set; }

        public virtual ObservableCollectionListSource<QuanLyChuyenDi> ChuyenDi { get; } = new();
    }
}
