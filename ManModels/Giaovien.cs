using System;
using System.Collections.Generic;

namespace QuanLyAgile.ManModels
{
    public partial class Giaovien
    {
        public string Magv { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public string? Tennd { get; set; }
        public string? Matkhau { get; set; }
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
