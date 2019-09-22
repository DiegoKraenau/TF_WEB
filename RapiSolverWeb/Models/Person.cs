using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapiSolverWeb.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int IdPerson{get;set;}

        [Column("name")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "El nombre debe tener minimo 5 caracteres")]
        public string Name{get;set;}

        [Column("lastname")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "El nombre debe tener minimo 5 caracteres")]
        public string Lastname{get;set;}

        [Column("email")]
        [StringLength(50, MinimumLength = 10)]
        [Required(ErrorMessage = "El correo debe tener minimo 10 caracteres")]
        public string Email{get;set;}

        [Column("phone")]
        [StringLength(10, MinimumLength = 7)]
        [Required(ErrorMessage = "El telefono debe tener minimo 7 digitos")]
        public string Phone{get;set;}

        [Column("age")]
        [StringLength(80, MinimumLength = 18)]
        [Required(ErrorMessage = "La edad minima debe ser 18 años")]
        public int Age{get;set;}

        [Column("password")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "El contraseña debe tener minimo 5 caracteres")]
        public string Password{get;set;}

        [Column("gender")]
        public string Gender{get;set;}
        
        //FALTA LOCATION
    }
}