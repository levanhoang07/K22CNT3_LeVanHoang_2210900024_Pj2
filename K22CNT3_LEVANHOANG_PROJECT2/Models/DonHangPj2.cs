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
    
    public partial class DonHangPj2
    {
        public int MaDonHang { get; set; }
        public int MaKH { get; set; }
        public Nullable<System.DateTime> NgayDatHang { get; set; }
        public decimal TongTien { get; set; }
        public Nullable<byte> TrangThai { get; set; }
    
        public virtual KhachHangPj2 KhachHangPj2 { get; set; }
    }
}
