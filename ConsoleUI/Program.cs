using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Color color = new Color()
            //{
            //    ColorName = "Gri"
            //};
            //colorManager.Add(color);


            var colors = colorManager.GetAll();

            foreach (var item in colors)
            {
                Console.WriteLine(item.ColorName);
            }





            //Console.WriteLine("----------------------------------");

            //Brand brand = new Brand()
            //{
            //    BrandName = "Mercedes"
            //};
            //brandManager.Add(brand);

            



            //Car car1 = new Car()
            //{
            //    BrandId = 1,
            //    CarName = "BMW",
            //    ColorId = 10,
            //    ModelYear = 2014,
            //    DailyPrice = 150
            //};
            //carManager.Add(car1);


            //var result1 = carManager.GetAll();
            //if (result1.Success==true)
            //{
            //    foreach (var c in result1.Data)
            //    {
            //        Console.WriteLine(c.CarName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result1.Message);
            //}

            

            


            //var result = carManager.GetCarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var c in result.Data)
            //    {
            //        Console.WriteLine(c.CarId + "-->" + c.CarName + "-->" + c.BrandName + "-->" + c.ColorName + "-->" + c.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            


            Console.ReadKey();
        }
    }
}
