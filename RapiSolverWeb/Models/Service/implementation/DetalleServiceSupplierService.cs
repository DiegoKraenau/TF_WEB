using System.Collections.Generic;
using RapiSolverWeb.Models.repository;

namespace RapiSolverWeb.Models.Service.implementation
{
    public class DetalleServiceSupplierService : IDetalleServiceSupplierService
    {

        private IDetalleServiceSupplierRepository detalleServiceSupplierRepository;
        public DetalleServiceSupplierService(IDetalleServiceSupplierRepository detalleServiceSupplierRepository)
        {
            this.detalleServiceSupplierRepository = detalleServiceSupplierRepository;
        }

        public bool Delete(int id)
        {
            return detalleServiceSupplierRepository.Delete(id);
        }

        public DetalleServiceSupplier Get(int id)
        {
           return detalleServiceSupplierRepository.Get(id);
        }

        public IEnumerable<DetalleServiceSupplier> GetAll()
        {
           return detalleServiceSupplierRepository.GetAll();
        }

        public bool Save(DetalleServiceSupplier entity)
        {
            return detalleServiceSupplierRepository.Save(entity);
        }

        public bool Update(DetalleServiceSupplier entity)
        {
            return detalleServiceSupplierRepository.Update(entity);
        }
    }
}