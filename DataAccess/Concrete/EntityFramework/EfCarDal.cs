using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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
        public List<ProductDetailDto> GetProductDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from col in context.Colors
                             join c in context.Cars                            
                             on col.Id equals c.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new ProductDetailDto
                             {
                                 CarId = c.Id,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = col.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
