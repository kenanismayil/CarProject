using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                return new ErrorResult(Messages.CarNameInvalid);
            }


            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarsUpdated);

        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            var list = _carDal.GetAll();
            return new SuccessDataResult<List<Car>>(list, Messages.CarsListed);   //default success or unsuccess
        }
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            var result = _carDal.GetAll(c => c.DailyPrice > 0 && c.DailyPrice < 100);
            return new SuccessDataResult<List<Car>>(result);
        }


        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            var carDetails = _carDal.GetCarDetails();            
            return new SuccessDataResult<List<CarDetailsDto>>(carDetails);
        }

        public IDataResult<Car> GetCarsByBrandId(int brandId)
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<Car>(Messages.MaintenanceTime);
            }

            var result = _carDal.Get(c => c.BrandId == brandId);
            return new SuccessDataResult<Car>(result);
        }

        public IResult DeleteAll(Expression<Func<Car, bool>> filter)
        {
            _carDal.DeleteAll(filter);
            return new SuccessResult(Messages.CarDeleted);
        }



        public IDataResult<Car> GetCarsByColorId(int colorId)
        {
            var result = _carDal.Get(c => c.ColorId == colorId);
            return new SuccessDataResult<Car>(result);
        }
    }
}
