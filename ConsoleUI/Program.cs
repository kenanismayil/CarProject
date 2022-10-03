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

            //Car car = new Car()
            //{
            //    BrandId = 6,
            //    CarName = "Audi Q7",
            //    ColorId = 7,
            //    ModelYear = 2018,
            //    DailyPrice = 350
            //};
            //carManager.Add(car);


            var result1 = carManager.GetAll();
            if (result1.Success == true)
            {
                foreach (var c in result1.Data)
                {
                    Console.WriteLine(c.CarName);
                }
            }
            else
            {
                Console.WriteLine(result1.Message);
            }



            //Color color = new Color()
            //{
            //    ColorName = "Mavi"
            //};
            //colorManager.Add(color);

            //var data = colorManager.GetAll();
            //foreach (var item in data.Data)
            //{
            //    Console.WriteLine(item.ColorName);
            //}


            //Brand brand = new Brand()
            //{
            //    BrandName = "Range Rover"
            //};
            //brandManager.Add(brand);

            //var data = brandManager.GetAll();
            //foreach (var item in data.Data)
            //{
            //    Console.WriteLine(item.BrandName);
            //}

            //var color2 = colorManager.GetAll();

            //foreach (var item in color2.Data)
            //{
            //    if (item.ColorName == "Gri")
            //    {
            //        colorManager.Delete(item);
            //    }

            //}






            //Console.WriteLine("----------------------------------");




            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CarId + "-->" + c.CarName + "-->" + c.BrandName + "-->" + c.ColorName + "-->" + c.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }




            Console.ReadKey();
        }
    }
}
