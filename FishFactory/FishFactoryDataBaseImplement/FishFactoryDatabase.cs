using FishFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
namespace FishFactoryDatabaseImplement
{
    public class FishFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CM2EFFR\SQLEXPRESS;Initial Catalog=FishFactoryDatabaseName2;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Property(m => m.ImplementerId).IsRequired(false);
            modelBuilder.Entity<MessageInfo>().Property(p => p.ClientId).IsRequired(false);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Canned> Canneds { set; get; }
        public virtual DbSet<CannedComponent> CannedComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Implementer> Implementers { get; set; }
        public virtual DbSet<MessageInfo> Messages { get; set; }
    }
}
