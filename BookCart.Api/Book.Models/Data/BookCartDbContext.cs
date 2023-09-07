using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Models.Data
{
    public class BookCartDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

                var connectionString = configuration.GetConnectionString("DevConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<BookCart>? Books { get; set; }
        public DbSet<Price>? Price { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<CartItems>? CartItems { get; set; }
        public DbSet<Cart>? carts { get; set; }

    }
}
