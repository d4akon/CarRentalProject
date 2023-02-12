using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarRentalProject.Models;

public class Car
{
    [Key]
    public int Id { get; set; }
    [Required]
    public CarTypes Type { get; set; }
    [StringLength(50)]
    [Required]
    public string Brand { get; set; }
    [StringLength(50)]
    [Required]
    public string Model { get; set; }
    [StringLength(50)]
    [Required]
    public string Color { get; set; }
    [Url]
    public string ImageUrl { get; set; }
}

public enum CarTypes
{
    Coupe,
    Crossover,
    Hatchback,
    Pickup,
    Sedan,
    [Display(Name = "Sports Car")]
    SportsCar,
    SUV
}