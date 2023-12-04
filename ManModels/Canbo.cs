using System;
using System.Collections.Generic;

namespace QuanLyAgile.ManModels
{
    public partial class Canbo
    {
        public Canbo()
        {
            Sinhviens = new HashSet<Sinhvien>();
        }

        public string Macb { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public string Tendn { get; set; } = null!;
        public string Matkhau { get; set; } = null!;
        public string? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Quequan { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public int? Level { get; set; }

        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
