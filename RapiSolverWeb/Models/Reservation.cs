using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapiSolverWeb.Models
{
     [Table("reservation")]
    public class Reservation
    {
         [Key]
        public int IdReservation{get;set;}

        [Column("reservationDate")]
        public string ReservationDate{get;set;}

        [Column("discount")]
        public double Discount{get;set;}

        [Column("price")]
        public double Prince{get;set;}

        public int CustomerId{get;set;}

        public int SupplierId{get;set;}

        public int ServiceId{get;set;}

        public int LocationId{get;set;}

        public Customer Customer{get;set;}

        public Supplier Supplier{get;set;}

        public Servicio Servicio{get;set;}

        public Location Location{get;set;}


    }
}