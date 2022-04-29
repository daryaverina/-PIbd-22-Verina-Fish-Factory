﻿using FishFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
namespace FishFactoryDatabaseImplement
{
    public class FishFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CM2EFFR\SQLEXPRESS;Initial Catalog=FishFactoryDatabaseName;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Canned> Canneds { set; get; }
        public virtual DbSet<CannedComponent> CannedComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
    }
}
