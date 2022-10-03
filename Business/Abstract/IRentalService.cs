using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetByRentalId(int rentalId);
        IDataResult<List<Rental>> GetAllRentalCars();
        IDataResult<List<Rental>> GetNotRentalCars();    
        IDataResult<List<Rental>> GetRentalCars();    
        IDataResult<List<RentalDetailDto>> GetRentalCarDetails();    

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
