using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFClassLibr
{
    class DataContext : DbContext
    {
        public DataContext() : base("EFLessonConnectionString") { }

        public DbSet<Categories> Category { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purse> Purses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
