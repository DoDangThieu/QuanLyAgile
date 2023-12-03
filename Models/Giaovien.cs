using System;
using System.Collections.Generic;

namespace QuanLyAgile.Models
{
    public partial class Giaovien
    {
        public string Magv { get; set; } = null!;
        public string Makhoa { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public string Tennd { get; set; } = null!;
        public string Matkhau { get; set; } = null!;
        public string? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Quequan { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public int? Level { get; set; }

        public virtual Khoa MakhoaNavigation { get; set; } = null!;
    }
}
