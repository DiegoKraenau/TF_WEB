using System.Collections.Generic;

namespace RapiSolverWeb.Models.ViewModel
{
    public class SupplierViewModel
    {
      
        public int IdSupplier{get;set;}


        public string Name{get;set;}

    
        public string Lastname{get;set;}

      
        public string Email{get;set;}

        public string Phone{get;set;}

       
        public int Age{get;set;}

        public string Password{get;set;}

        
        public string Gender{get;set;}

     
        public string NameCompany{get;set;}

        public int LocationId{get;set;}

        public string NombreLocation{get;set;}

        public virtual IEnumerable<DetalleServiceSupplier> DetalleServicios{get;set;}
    }
}