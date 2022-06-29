using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.DTO_s;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomer _customer;
        public CustomerManager(ICustomer customer)
        {
            _customer = customer;
        }
        public IResult Add(Customer customer)
        {
            _customer.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customer.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customer.Getall());
        }

        public IResult Update(Customer customer)
        {
            _customer.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
