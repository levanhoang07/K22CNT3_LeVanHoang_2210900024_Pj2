﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class K22CNT3_LEVANHOANG_PROJECT2Entities : DbContext
    {
        public K22CNT3_LEVANHOANG_PROJECT2Entities()
            : base("name=K22CNT3_LEVANHOANG_PROJECT2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHangPj2> ChiTietDonHangPj2 { get; set; }
        public virtual DbSet<DonHangPj2> DonHangPj2 { get; set; }
        public virtual DbSet<GioHangPj2> GioHangPj2 { get; set; }
        public virtual DbSet<KhachHangPj2> KhachHangPj2 { get; set; }
        public virtual DbSet<QuanTriPj2> QuanTriPj2 { get; set; }
        public virtual DbSet<SanPhamPj2> SanPhamPj2 { get; set; }
    }
}
