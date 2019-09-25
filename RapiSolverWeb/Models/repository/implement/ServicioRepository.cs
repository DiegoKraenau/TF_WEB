using System;
using System.Collections.Generic;
using System.Linq;
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;
using RapiSolverWeb.Models.ViewModel;

namespace RapiSolverWeb.Models.repository.implement
{
    public class ServicioRepository : IServicioRepository

    {

        private ApplicationDbContext context;

        public ServicioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Servicio Get(int id)
        {
            var result = new Servicio();
            try
            {
                result = context.servicio.Single(x => x.IdServicio == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<ServiceViewModel> GetAll()
        {
            var orden = context.servicio
                .Include (o => o.Category)
                .OrderByDescending (o => o.IdServicio)
                .Take (10)
                .ToList ();

           
            return orden.Select (o => new ServiceViewModel {
                    IdServicio = o.IdServicio,
                    Name = o.Name,
                    Description=o.Description,
                    Cost=o.Cost,
                    IdCategory=o.Category.IdCategory,
                    NameCategory=o.Category.Name
            });
        }

        public bool Save(Servicio entity)
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

        public bool Update(Servicio entity)
        {
            Servicio servicioC = new Servicio {
                IdServicio = entity.IdServicio,
                Name = entity.Name,
                Description = entity.Description,
                Cost = entity.Cost,
            };
            try {
                context.servicio.Add (servicioC);
                context.SaveChanges ();
                var servicioId = servicioC.IdServicio;
                foreach (var item in entity.DetalleSupplier) {
                    DetalleServiceSupplier detalle = new DetalleServiceSupplier {
                       // SupplierId =item.SupplierId ,
                        //ServiceId = servicioId,
                      
                    };
                    context.detalleServiceSupplier.Add (detalle);
                }
                context.SaveChanges ();
            } catch (Exception ) {
                return false;
            }
            return true;
        }

        IEnumerable<Servicio> IRepository<Servicio>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}