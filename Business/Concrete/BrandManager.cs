using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandService _brandService;
        public BrandManager(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public List<Brand> GetAll()
        {
            return _brandService.GetAll();
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandService.Get(b=>b.BranId==id);
        }
    }
}
