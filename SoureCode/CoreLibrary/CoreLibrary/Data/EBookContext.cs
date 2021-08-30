using CoreLibrary.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Data
{
    public class EBookContext : IdentityDbContext<User>
    {
        public EBookContext(DbContextOptions<EBookContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Interaction>().HasKey(e => new { e.BookId, e.UserId });
            builder.Entity<Basket>().HasKey(b => new { b.BookId, b.UserId });
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<Basket> Baskets { get; set; }

    }
}
