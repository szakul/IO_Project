﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportCenterManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseConnection : DbContext
    {
        public DatabaseConnection()
            : base("name=DatabaseConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<accounts> accounts { get; set; }
        public DbSet<admins> admins { get; set; }
        public DbSet<cashiers> cashiers { get; set; }
        public DbSet<clients> clients { get; set; }
        public DbSet<coaches> coaches { get; set; }
        public DbSet<employees> employees { get; set; }
        public DbSet<events> events { get; set; }
        public DbSet<facilities> facilities { get; set; }
        public DbSet<price_lists> price_lists { get; set; }
        public DbSet<reservations> reservations { get; set; }
        public DbSet<sales> sales { get; set; }
        public DbSet<schedules> schedules { get; set; }
        public DbSet<services> services { get; set; }
        public DbSet<subscriptions> subscriptions { get; set; }
        public DbSet<tickets> tickets { get; set; }
        public DbSet<trainings> trainings { get; set; }
    }
}
