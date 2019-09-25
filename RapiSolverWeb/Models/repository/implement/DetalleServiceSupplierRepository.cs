using System.Collections.Generic;
using System.Linq;
using Hospital.Repositoy.dbcontext;

namespace RapiSolverWeb.Models.repository.implement
{
    public class DetalleServiceSupplierRepository : IDetalleServiceSupplierRepository
    {

        private ApplicationDbContext context;

        public DetalleServiceSupplierRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public DetalleServiceSupplier Get(int id)
        {
             var result = new DetalleServiceSupplier();
            try
            {
                result = context.detalleServiceSupplier.Single(x => x.IdDetalleServiceSupplier == id);
                
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<DetalleServiceSupplier> GetAll()
        {
            var result = new List<DetalleServiceSupplier>();
            try
            {
                result = context.detalleServiceSupplier.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(DetalleServiceSupplier entity)
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

        public bool Update(DetalleServiceSupplier entity)
        {
            throw new System.NotImplementedException();
            //FALTA
        }
    }
}