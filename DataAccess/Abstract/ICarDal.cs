﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Veri Erisim Islemini yapacak ICarDal interface'i olusturdum.
    public interface ICarDal:IEntityRepository<Car>
    {
        
    }
}
