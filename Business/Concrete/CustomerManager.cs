using Business.Abstract;
using Business.Constants;
using Core.Ultilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer user)
        {
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.CustomerId == id));
        }

        public IResult Update(Customer user)
        {
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
