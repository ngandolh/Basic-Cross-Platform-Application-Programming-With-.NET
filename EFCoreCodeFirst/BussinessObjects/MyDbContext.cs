using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using IConfiguration to get information from json file.
            optionsBuilder.UseSqlServer("Server=LAPTOP-HP6ERQBA\\SQLEXPRESS;Database=DemoProductCategoryXX;Uid=sa;Pwd=12345;");
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Cate1" },
                new Category { CategoryId = 2, CategoryName = "Cate1" });
        }

    }
}
