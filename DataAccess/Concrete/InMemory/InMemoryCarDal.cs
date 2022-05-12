using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=100, CarName="Opel Astra", ColorId = 0, DailyPrice=355.000, ModelYear=2017, Description = "Opel Astra - 78.000km"},
                new Car{Id=2, BrandId=101, CarName="Honda Civic", ColorId = 1, DailyPrice=73.500, ModelYear=1994, Description = "Honda Civic - 232.500km"},
                new Car{Id=3, BrandId=101, CarName="Renault Clio", ColorId = 2, DailyPrice=136.500, ModelYear=2007, Description = "Renault Clio - 225.000km"},
                new Car{Id=4, BrandId=102, CarName="Mercedes Benz C-200", ColorId = 3, DailyPrice=913.000, ModelYear=2016, Description = "Mercedes Benz C-200 - 83.200km"},
                new Car{Id=5, BrandId=103, CarName="Volswagen Golf", ColorId = 4, DailyPrice=347.500, ModelYear=2016, Description = "Volswagen Golf - 190.000km"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Linq kullanilmali.
            Car carTodDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carTodDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            //Update Operations
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
