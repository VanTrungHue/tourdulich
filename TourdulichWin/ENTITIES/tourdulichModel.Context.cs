﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTITIES
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tourdulichEntities : DbContext
    {
        public tourdulichEntities()
            : base("name=tourdulichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chitietdiemthamquan> chitietdiemthamquans { get; set; }
        public virtual DbSet<chitietdoandulich> chitietdoanduliches { get; set; }
        public virtual DbSet<chitietthanhtoan> chitietthanhtoans { get; set; }
        public virtual DbSet<diadiem> diadiems { get; set; }
        public virtual DbSet<doandulich> doanduliches { get; set; }
        public virtual DbSet<giatour> giatours { get; set; }
        public virtual DbSet<gioitinh> gioitinhs { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<loaihinhdulich> loaihinhduliches { get; set; }
        public virtual DbSet<loaiphieu> loaiphieux { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<nhiemvu> nhiemvus { get; set; }
        public virtual DbSet<phancong> phancongs { get; set; }
        public virtual DbSet<phieuthanhtoan> phieuthanhtoans { get; set; }
        public virtual DbSet<tinhthanh> tinhthanhs { get; set; }
        public virtual DbSet<tour> tours { get; set; }
    }
}
