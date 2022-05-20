using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IDataResult<Brand> GetByCarId(int id);
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult DeleteAll(Expression<Func<Brand, bool>> filter);
    }
}
