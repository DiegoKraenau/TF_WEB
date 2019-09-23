using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapiSolverWeb.Models
{
    [Table("Location")]
    class Location{

        [Key]
        public int Idlocation{get;set;}

        [Column("country")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre debe tener minimo 3 caracteres")]
        public string Country{get;set;}


        [Column("city")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre debe tener minimo 3 caracteres")]    
        public string City{get;set;}

        [Column("state")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre debe tener minimo 3 caracteres")]
        public string State{get;set;}

        [Column("address")]
        [StringLength(80, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre debe tener minimo 3 caracteres")]
        public string Address{get;set;}



    }



}