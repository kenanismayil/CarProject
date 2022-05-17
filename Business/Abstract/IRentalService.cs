﻿using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByRentalId(int id);
        //IDataResult<List<Rental>> GetRentDates();
        //IDataResult<List<Rental>> GetReturnDates();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
    }
}