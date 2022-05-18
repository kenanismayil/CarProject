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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length <= 2)
            {
                return new ErrorResult(Messages.CompanyNameInvalid);
            }

            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var data = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(data);
        }

        public IDataResult<Customer> GetByCustomerId(int id)
        {
            var customerId = _customerDal.Get(c => c.Id == id);
            return new SuccessDataResult<Customer>(customerId);
        }

        public IDataResult<List<String>> GetCompanyNames()
        {
            List<String> companyNames = new List<string>();
            var customers = _customerDal.GetAll();

            foreach (var item in customers)
            {
                String data = item.CompanyName;
                companyNames.Add(data);
            }
            return new SuccessDataResult<List<String>>(companyNames, Messages.CompanyNamesListed);
        }
    }
}
