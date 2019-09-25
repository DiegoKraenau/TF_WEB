using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapiSolverWeb.Models
{
    [Table("servicio")]
    public class Servicio
    {
        [Key]
        public int IdServicio{get;set;}

        [Column("name")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "El nombre debe tener minimo 5 caracteres")]
        public string Name{get;set;}

        [Column("description")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "El nombre debe tener minimo 5 caracteres")]
        public string Description{get;set;}

        [Column("cost")]
        public string Cost{get;set;}

        public ServiceCategory Category{get;set;}

        public virtual List<DetalleServiceSupplier> lista{get;set;}


        
    }
}