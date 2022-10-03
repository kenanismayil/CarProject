using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _modelDal;
        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public IResult Add(Model model)
        {

            if (model.ModelYear < 2000 && model.ModelYear >= 2023)
            {
                return new ErrorResult(Messages.ModelYearInvalid);
            }

            _modelDal.Add(model);
            return new SuccessResult(Messages.ModelAdded);
        }

        public IResult Delete(Model model)
        {
            _modelDal.Delete(model);
            return new SuccessResult(Messages.ModelDeleted);
        }

        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccessResult(Messages.ModelUpdated);
        }

        public IDataResult<List<Model>> GetAll()
        {
            var result = _modelDal.GetAll();
            return new SuccessDataResult<List<Model>>(result, Messages.ModelsListed);
        }

        public IDataResult<Model> GetById(int modelId)
        {
            var result = _modelDal.Get(m => m.Id == modelId);
            return new SuccessDataResult<Model>(result);
        }


    }
}
