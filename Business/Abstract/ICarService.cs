using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByDailyPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        void Add(Car entity);
        void Delete(Car entity);
    }
}
