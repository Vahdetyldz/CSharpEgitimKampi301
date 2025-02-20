using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using System.Collections.Generic;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelet(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != " " && entity.CustomerName.Length >= 3 && entity.CustomerName.Length <= 30 && entity.CustomerCity != null && entity.CustomerSurname != " ")
            {
                _customerDal.Insert(entity);
            }
            else
            {
                //Hata mesajı ver...
            }

        }

        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId!= 0 && entity.CustomerCity.Length>=3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                //Hata mesajı ver...
            }

        }
    }
}
