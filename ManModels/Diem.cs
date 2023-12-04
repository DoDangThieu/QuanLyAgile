using System;
using System.Collections.Generic;

namespace QuanLyAgile.ManModels
{
    public partial class Diem
    {
        public string Masv { get; set; } = null!;
        public double Diem1 { get; set; }
        public int Lanthi { get; set; }
        public DateTime? Ngaythi { get; set; }
        public DateTime? Ngaynhapdiem { get; set; }
        public string? Mamon { get; set; }
        public string? Magv { get; set; }

        public virtual Giaovien? MagvNavigation { get; set; }
        public virtual Monhoc? MamonNavigation { get; set; }
        public virtual Sinhvien MasvNavigation { get; set; } = null!;
    }
}
