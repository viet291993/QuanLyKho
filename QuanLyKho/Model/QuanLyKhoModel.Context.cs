﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyKhoEntities : DbContext
    {
        public QuanLyKhoEntities()
            : base("name=QuanLyKhoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<input> inputs { get; set; }
        public virtual DbSet<inputdetail> inputdetails { get; set; }
        public virtual DbSet<output> outputs { get; set; }
        public virtual DbSet<outputdetail> outputdetails { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
