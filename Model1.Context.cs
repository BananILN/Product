﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Products
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class productEntities : DbContext
    {
        public productEntities()
            : base("name=productEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<PatnerProduct> PatnerProduct { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
    }
}
