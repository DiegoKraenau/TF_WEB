using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapiSolverWeb.Models
{
    [Table("serviceCategory")]
    public class ServiceCategory
    {
        [Key]
        public int IdCategory{get;set;}

        [Column("name")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "El nombre debe tener minimo 5 caracteres")]
        public string Name{get;set;}

        public virtual List<Servicio> services{get;set;}



    }
}