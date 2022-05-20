using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length <= 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult DeleteAll(Expression<Func<Brand, bool>> filter)
        {
            _brandDal.DeleteAll(filter);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result, Messages.BrandsListed);
        }

        public IDataResult<Brand> GetByCarId(int id)
        {
            var data = _brandDal.Get(b => b.Id == id);
            return new SuccessDataResult<Brand>(data);
        }

        public IDataResult<Brand> GetById(int id)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<Brand>(Messages.MaintenanceTime);
            }
            var result = _brandDal.Get(b => b.Id == id);
            return new SuccessDataResult<Brand>(result);
        }
    }
}
