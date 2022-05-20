using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult DeleteAll(Expression<Func<Car, bool>> filter);
        IResult Update(Car car);
    }
}
