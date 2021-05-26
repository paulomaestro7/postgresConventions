using Microsoft.EntityFrameworkCore;
using postgresConventions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postgresConventions
{
    public class PostgresContext : DbContext
    {
        public PostgresContext()
        {

        }
        public PostgresContext(DbContextOptions<PostgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<ItemsOrder> ItemsOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql("User ID=postgres;Password=1234@1234!;Host=localhost;Port=5432;Database=postgres;Pooling=true;Connection Lifetime=0;")
            .UseSnakeCaseNamingConvention();
    }
}