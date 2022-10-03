using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarRental;Trusted_Connection=True");
        }

        public DbSet<Car> Cars { get; set; }                //Car nesnemi Veritabanindaki Cars tablosuna bagladim.
        public DbSet<Brand> Brands { get; set; }            //Brand nesnemi Veritabanindaki Brands tablosuna bagladim.
        public DbSet<Model> Models { get; set; }            //Model nesnemi Veritabanindaki Colors tablosuna bagladim.
        public DbSet<Color> Colors { get; set; }            //Color nesnemi Veritabanindaki Colors tablosuna bagladim.
        public DbSet<User> Users { get; set; }              //User nesnemi Veritabanindaki Colors tablosuna bagladim.
        public DbSet<Customer> Customers { get; set; }      //Customer nesnemi Veritabanindaki Colors tablosuna bagladim.
        public DbSet<Rental> Rentals { get; set; }          //Rental nesnemi Veritabanindaki Colors tablosuna bagladim.
    }

}
