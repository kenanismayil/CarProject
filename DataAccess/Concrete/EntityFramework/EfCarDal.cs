using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                //CarDetails tablosundaki kolonlar select new CarDetailsDto içinde belirttim ve bunları join yaptım.
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join m in context.Models
                             on c.ModelId equals m.Id
                             join col in context.Colors
                             on c.Id equals col.Id
                             select new CarDetailsDto
                             {
                                 CarId = c.Id, CarName = c.CarName, DailyPrice = c.DailyPrice,
                                 BrandId = b.Id, BrandName = b.BrandName,
                                 ModelId = m.Id,
                                 ModelYear = m.ModelYear,
                                 ColorName = col.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
