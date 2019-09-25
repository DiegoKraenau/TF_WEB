using System;
using System.Collections.Generic;
using System.Linq;
using Hospital.Repositoy.dbcontext;

namespace RapiSolverWeb.Models.repository.implement
{
    public class ServiceCategoryRepository : IServiceCategoryRepository
    {


        private ApplicationDbContext context;

        public ServiceCategoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ServiceCategory Get(int id)
        {
            var result = new ServiceCategory();
            try
            {
                result = context.serviceCategory.Single(x => x.IdCategory == id);
                
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<ServiceCategory> GetAll()
        {
            var result = new List<ServiceCategory>();
            try
            {
                result = context.serviceCategory.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(ServiceCategory entity)
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

        public bool Update(ServiceCategory entity)
        {
             ServiceCategory categoria = new ServiceCategory {
                IdCategory = entity.IdCategory,
                Name = entity.Name,
                
            };
            try {
                context.serviceCategory.Add (categoria);
                context.SaveChanges ();
                var categoryId = categoria.IdCategory;
                foreach (var item in entity.services) {
                    Servicio detalle = new Servicio {
                        CategoryId=categoryId,
                      
                    };
                    context.servicio.Add (detalle);
                }
                context.SaveChanges ();
            } catch (Exception ) {
                return false;
            }
            return true;
        }
    }
}