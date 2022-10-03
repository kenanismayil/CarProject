using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDto()
        {
            using (CarContext context = new CarContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id  
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join model in context.Models
                             on car.ModelId equals model.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rental.Id,
                                 CarId = rental.CarId,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 ModelYear = model.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 CustomerFrstName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 CarRentDate = rental.RentDate,
                                 CarReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
