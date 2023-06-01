using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BK.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int ProductionYear { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public string Transmission { get; set; }
        [Required]
        public double Mileage { get; set; }
        [Required]
        [Range(1, 9999999)]
        public double SalePrice { get; set; }
        [ValidateNever]
        public string Images { get; set; }

        public int CarSpecificationId { get; set; }
        [ForeignKey("CarSpecificationId")]
        [ValidateNever]
        public CarSpecification CarSpecification { get; set; }
    }
}

