using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate <= rental.RentDate)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }

            _rentDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var dataList = _rentDal.GetAll();
            return new SuccessDataResult<List<Rental>>(dataList, Messages.RentalListed);
        }

        public IDataResult<Rental> GetByRentalId(int id)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }

            var rentalId = _rentDal.Get(r => r.Id == id);
            return new SuccessDataResult<Rental>(rentalId);
        }


        public IDataResult<List<DateTime>> GetRentDates()
        {
            List<DateTime> dateTimes = new List<DateTime>();

            var rentals = _rentDal.GetAll();

            foreach (var item in rentals)
            {
                DateTime date = item.RentDate;
                dateTimes.Add(date);
            }
            return new SuccessDataResult<List<DateTime>>(dateTimes);
        }

        public IDataResult<List<DateTime>> GetReturnDates()
        {
            List<DateTime> dateReturns = new List<DateTime>();

            var rentals = _rentDal.GetAll();
            foreach (var item in rentals)
            {
                DateTime data = item.RentDate;
                dateReturns.Add(data);
            }

            return new SuccessDataResult<List<DateTime>>(dateReturns);      
        }
    }
}
