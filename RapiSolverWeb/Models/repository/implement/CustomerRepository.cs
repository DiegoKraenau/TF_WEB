using System.Collections.Generic;
using System.Linq;
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace RapiSolverWeb.Models.repository.implement
{
    public class CustomerRepository : ICustomerRepository
    {

        private ApplicationDbContext context;

        public CustomerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Customer Get(int id)
        {
           var result = new Customer();
            try
            {
                result = context.customer.Single(x => x.IdCustomer == id);
                
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Customer> GetAll()
        {
            var result = new List<Customer>();
            try
            {
                result = context.customer.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Customer entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Customer entity)
        {
            try
            {
                 var CustomerOrigina = context.customer.Single(
                     x => x.IdCustomer == entity.IdCustomer
                 );

                 CustomerOrigina.IdCustomer=entity.IdCustomer;
                 CustomerOrigina.Age=entity.Age;
                 CustomerOrigina.Email=entity.Email;
                 CustomerOrigina.Gender=entity.Gender;
                 CustomerOrigina.Lastname=entity.Lastname;
                 CustomerOrigina.Name=entity.Name;
                 CustomerOrigina.Password=entity.Password;
                 CustomerOrigina.Phone=entity.Password;
                

                 context.Update(CustomerOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
    }
}