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
    
    public partial class SanPhamPj2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPhamPj2()
        {
            this.ChiTietDonHangPj2 = new HashSet<ChiTietDonHangPj2>();
            this.GioHangPj2 = new HashSet<GioHangPj2>();
        }
    
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<byte> TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHangPj2> ChiTietDonHangPj2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHangPj2> GioHangPj2 { get; set; }
    }
}
