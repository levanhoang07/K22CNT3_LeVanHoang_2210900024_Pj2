//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K22CNT3_LEVANHOANG_PROJECT2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GioHangPj2
    {
        public int MaGioHang { get; set; }
        public int MaKH { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public Nullable<System.DateTime> NgayThem { get; set; }
        public Nullable<byte> TrangThai { get; set; }
    
        public virtual KhachHangPj2 KhachHangPj2 { get; set; }
        public virtual SanPhamPj2 SanPhamPj2 { get; set; }
    }
}
