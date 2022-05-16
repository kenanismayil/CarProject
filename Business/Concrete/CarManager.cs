using Business.Abstract;
using Core.Utilities;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length <= 2)
            {
                return new ErrorResult("->EXCEPTION:ARABA ISMI MINIMUM 2 KARAKTER UZUNLUGUNDA OLMALIDIR!!!");

            }

            _carDal.Add(car);
            return new SuccessResult("Urun Eklendi");
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

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }

        public Car GetByCarId(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }
    }
}
