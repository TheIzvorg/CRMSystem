﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRMSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CRMSystemEntities : DbContext
    {
        public CRMSystemEntities()
            : base("name=CRMSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<PaymentHistory> PaymentHistory { get; set; }
    }
}
