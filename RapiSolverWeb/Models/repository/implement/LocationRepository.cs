using System.Collections.Generic;
using System.Linq;
using Hospital.Repositoy.dbcontext;

namespace RapiSolverWeb.Models.repository.implement
{
    public class LocationRepository : ILocationRepository
    {

        private ApplicationDbContext context;

        public LocationRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Location Get(int id)
        {
            var result = new Location();
            try
            {
                result = context.location.Single(x => x.Idlocation == id);
                
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Location> GetAll()
        {
            var result = new List<Location>();
            try
            {
                result = context.location.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Location entity)
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

        public bool Update(Location entity)
        {
            throw new System.NotImplementedException();
            //FALTA
        }
    }
}