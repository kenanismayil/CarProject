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
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(result, Messages.UsersListed);
        }

        public IDataResult<List<String>> GetByUserEmails()
        {
            List<String> emails = new List<string>();
            var users = _userDal.GetAll();

            foreach (var item in users)
            {
                String data = item.Email;
                emails.Add(data);
            }
            return new SuccessDataResult<List<String>>(emails, Messages.EmailsListed);
        }

        public IDataResult<User> GetById(int userId)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<User>(Messages.MaintenanceTime);
            }

            var result = _userDal.Get(u => u.Id == userId);
            return new SuccessDataResult<User>(result);      
        }


    }
}
