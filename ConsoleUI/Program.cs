﻿using Business.Concrete;
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
            ColorManager colorManager = new ColorManager(new EfColorDal());



            Car car1 = new Car()
            {
                BrandId = 2,
                CarName = "Audi Q7",
                ColorId = 3,
                ModelYear = 2015,
                DailyPrice = 250
            };
            //carManager.Add(car1);

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.CarName);
            }

            Console.WriteLine("----------------------------------");

            Brand brand = new Brand()
            {
                BrandName = "Mercedes"
            };
            //brandManager.Add(brand);

            Color color = new Color()
            {
                ColorName = "Gri"
            };
            //colorManager.Add(color);



            foreach (var c in carManager.GetProductDetails())
            {
                Console.WriteLine(c.CarId + "-->" + c.CarName + "-->" + c.BrandName + "-->" + c.ColorName + "-->" + c.DailyPrice);
            }


            Console.ReadKey();
        }
    }
}
