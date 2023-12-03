using System;
using System.Collections.Generic;

namespace QuanLyAgile.Models
{
    public partial class Sinhvien
    {
        public string Masv { get; set; } = null!;
        public string Tensv { get; set; } = null!;
        public string Tennd { get; set; } = null!;
        public string Matkhau { get; set; } = null!;
        public string? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Quequan { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Macb { get; set; }
        public string? Malop { get; set; }
        public string? Makhoa { get; set; }
        public string? Muc { get; set; }

        public virtual Canbo? MacbNavigation { get; set; }
        public virtual Khoa? MakhoaNavigation { get; set; }
        public virtual Lop? MalopNavigation { get; set; }
    }
}
