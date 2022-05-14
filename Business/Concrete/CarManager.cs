using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        //Constructor Injection
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.CarName.Length >= 2)
            {
                _carDal.Add(entity);
            }
            else
            {
                Console.WriteLine("ARABA ISMI MINIMUM 2 KARAKTER UZUNLUGUNDA OLMALIDIR!");
            }
        }

        public List<Car> GetAll()
        {
            //Is Kodlari
            //Gerekli yetkiler ve.s

            return _carDal.GetAll();
        }
        public List<Car> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice > 0 && c.DailyPrice < 100);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }
    }
}
