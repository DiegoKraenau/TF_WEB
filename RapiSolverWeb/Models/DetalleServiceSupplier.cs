using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapiSolverWeb.Models
{
    [Table("detailServiceSupplier")]
    public class DetalleServiceSupplier
    {
        
        [Key]
        public int IdDetalleServiceSupplier{get;set;}

      //  public int ServiceId{get;set;}
        public Servicio ServicioDetail{get;set;}

     //   public int SupplierId{get;set;}
        public Supplier SupplierDetail{get;set;}

        


    }
}