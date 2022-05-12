using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Veri Erisim Islemini yapacak ICarDal interface'i olusturdum.
    public interface ICarDal
    {
        List<Car> GetAll();                         //Tum araba listesini alir.
        List<Car> GetAllByBrandId(int brandId);       //Arabalari markaya gore listeler.
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
