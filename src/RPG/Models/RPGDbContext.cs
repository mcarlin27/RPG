using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace RPG.Models
{
    public class RPGDbContext : IdentityDbContext<ApplicationUser>
    {
        public RPGDbContext() { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerItem> PlayerItems { get; set; }
        public RPGDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>()
                .HasKey(p => p.PlayerId);
            builder.Entity<Item>()
                .HasKey(i => i.ItemId);
            builder.Entity<Location>()
                .HasKey(l => l.LocationId);
            builder.Entity<PlayerItem>()
                .HasKey(pi => pi.InventoryId);
            builder.Entity<PlayerItem>()
                .HasOne(p => p.Player)
                .WithMany(a => a.PlayerItems)
                .HasForeignKey(pi => pi.PlayerId);
            builder.Entity<PlayerItem>()
                .HasOne(p => p.Item)
                .WithMany(i => i.PlayerItems)
                .HasForeignKey(pi => pi.ItemId);

            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RPG;integrated security=True");
        }

    }
}
