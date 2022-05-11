using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();                         //Tum araba listesini alir.
        List<Car> GetAllBrandId(int brandId);       //Arabalari markaya gore listeler.
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
