using System.Collections.Generic;
using RapiSolverWeb.Models.repository;

namespace RapiSolverWeb.Models.Service.implementation
{
    public class CustomerService : ICustomerService
    {

        private ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Customer Get(int id)
        {
            return customerRepository.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public bool Save(Customer entity)
        {
           return customerRepository.Save(entity);
        }

        public bool Update(Customer entity)
        {
            return customerRepository.Update(entity);
        }
    }
}