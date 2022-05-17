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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length <= 2)
            {
                return new ErrorResult(Messages.FirstNameInvalid);
            }
            if (user.LastName.Length <= 1)
            {
                return new ErrorResult(Messages.LastNameInvalid);
            }

            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        //public IDataResult<List<User>> GetByUserEmails()
        //{
        //    var data = _userDal.GetAll();
        //    return new SuccessDataResult<List<User>>(data, Messages.EmailsListed);
        //}

        public IDataResult<User> GetById(int id)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<User>(Messages.MaintenanceTime);
            }

            var userId = _userDal.Get(u => u.Id == id);
            return new SuccessDataResult<User>(userId);
            
        }
    }
}
