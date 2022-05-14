using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            CarManager carManager = new CarManager(new EfCarDal());

            //Car car1 = new Car();
            //car1.CarName = "BMW";
            //car1.BrandId = 1;
            //car1.ColorId = 1;
            //car1.DailyPrice = 500;
            //car1.Description = "X5";

            Car car2 = new Car()
            {
                CarName = "Mercedes Benz",
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 350,
                ModelYear = 2015
            };

            carManager.Add(car2);

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.CarName);
            }





            Console.ReadKey();
        }
    }
}
