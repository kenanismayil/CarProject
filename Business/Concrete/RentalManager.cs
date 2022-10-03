using Business.Abstract;
using Business.Constants;
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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            //Ilgili arabanin kiralanabilmesi icin veritabaina eriserek ekranda tikladigim arabanin id"si ile esleme yapilir.
            //Arabanin kiralanabilmesi icin arabanin teslim edilmesi gerekir.
            //Ayni zamanda araba teslim edilmemisse, ReturnDate null"dir.
            var rentalCar = _rentDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            //rentalCar bos degilse, yani kiralanmaya uygun degilse error mesaji verilir.
            if (rentalCar != null)
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

        public IResult Update(Rental rental)
        {
            _rentDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }


        public IDataResult<List<Rental>> GetAllRentalCars()
        {
            var result = _rentDal.GetAll();
            return new SuccessDataResult<List<Rental>>(result, Messages.RentalListed);
        }

        public IDataResult<Rental> GetByRentalId(int rentalId)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }

            var result = _rentDal.Get(r => r.Id == rentalId);
            return new SuccessDataResult<Rental>(result);
        }

        //Kural: Arabayi geri iade edilmemisse, ReturnDate null'dur. 
        //Kiralayamadigimiz arabalarin listesini verir. (ps: Teslim edilmeyen arabalar kiralanamaz)
        public IDataResult<List<Rental>> GetNotRentalCars()
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(r=>r.ReturnDate == null));         //teslim edilmeyen arabalar
        }

        //Kiralayabilecegimiz arabalarin listesini verir. 
        public IDataResult<List<Rental>> GetRentalCars()
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(r => r.ReturnDate != null));     //teslim edilen arabalar
        }

        //Kiralanmiş arabalarin detayini getirir.
        public IDataResult<List<RentalDetailDto>> GetRentalCarDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentDal.GetRentalDetailDto());
        }

    }
}
