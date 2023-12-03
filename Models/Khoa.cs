using System;
using System.Collections.Generic;

namespace QuanLyAgile.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            Giaoviens = new HashSet<Giaovien>();
            Sinhviens = new HashSet<Sinhvien>();
        }

        public string Makhoa { get; set; } = null!;
        public string Tenkhoa { get; set; } = null!;

        public virtual ICollection<Giaovien> Giaoviens { get; set; }
        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
