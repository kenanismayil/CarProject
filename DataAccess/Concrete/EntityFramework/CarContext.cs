using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarRental;Trusted_Connection=True");
        }

        public DbSet<Car> Cars { get; set; }         //Product nesnemi Veritabanindaki Cars tablosuna bagladim.
        public DbSet<Brand> Brands { get; set; }     //Category nesnemi Veritabanindaki Brands tablosuna bagladim.
        public DbSet<Color> Colors { get; set; }     //Customer nesnemi Veritabanindaki Colors tablosuna bagladim.
    }

}
