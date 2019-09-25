using System.Collections.Generic;
using System.Linq;
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;
using RapiSolverWeb.Models.ViewModel;

namespace RapiSolverWeb.Models.repository.implement
{
    public class SupplierRepository : ISupplierRepository
    {

        private ApplicationDbContext context;

        public SupplierRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Supplier Get(int id)
        {
             var result = new Supplier();
            try
            {
                result = context.supplier.Single(x => x.IdSupplier == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<SupplierViewModel> GetAll()
        {
            var orden = context.supplier
                .Include (o => o.location)
                .OrderByDescending (o => o.IdSupplier)
                .Take (10)
                .ToList ();

           
            return orden.Select (o => new SupplierViewModel {
                 IdSupplier = o.IdSupplier,
                    Name = o.Name,
                    LocationId=o.location.Idlocation,
                    NombreLocation=o.location.City,
                    Age=o.Age,
                    Lastname=o.Lastname,
                    Phone=o.Phone,
                    Email=o.Email,
                    Gender=o.Gender,
                    Password=o.Password,
                    NameCompany=o.NameCompany
            });
        }

        public bool Save(Supplier entity)
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

        public bool Update(Supplier entity)
        {
            try
            {
                 var SupplirOrigina = context.supplier.Single(
                     x => x.IdSupplier == entity.IdSupplier
                 );

                 SupplirOrigina.IdSupplier=entity.IdSupplier;
                 SupplirOrigina.Name=entity.Name;
                 SupplirOrigina.Lastname=entity.Lastname;
                 SupplirOrigina.Password=entity.Password;
                 SupplirOrigina.Phone=entity.Phone;
                 SupplirOrigina.Gender=entity.Gender;
                 SupplirOrigina.NameCompany=entity.NameCompany;

                //ESTOY EN DUDA
                 SupplirOrigina.location.Idlocation=entity.location.Idlocation;
                 SupplirOrigina.location.Address=entity.location.Address;
                 SupplirOrigina.location.City=entity.location.City;
                 SupplirOrigina.location.Country=entity.location.Country;
                 SupplirOrigina.location.State=entity.location.State;
                 
                 

                 context.Update(SupplirOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        IEnumerable<Supplier> IRepository<Supplier>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}