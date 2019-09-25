using System.Collections.Generic;

namespace RapiSolverWeb.Models.ViewModel
{
    public class ServiceViewModel
    {
      
        public int IdServicio{get;set;}

        
        public string Name{get;set;}
        public string Description{get;set;}

     
        public string Cost{get;set;}

        public int IdCategory{get;set;}

        public string NameCategory{get;set;}

        public virtual IEnumerable<DetalleServiceSupplier> lista{get;set;}


    }
}