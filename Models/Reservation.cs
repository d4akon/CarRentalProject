using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalProject.Models
{
    public class Reservation
    {
        //TODO finish this model
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateOfRental { get; set; }
        public DateTime DateOfReturn { get; set; }
        public int? RentalTime => (DateOfReturn - DateOfRental).Days;
        public ReservationStatus Status { get; set; }
        
        //public int CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }
        //public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }        
    }

    public enum ReservationStatus
    {
        Unknown,
        [Display(Name = "In Progress")]
        InProgress,
        Finished
    }
}
