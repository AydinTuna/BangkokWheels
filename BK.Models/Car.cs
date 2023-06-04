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
        public string Type { get; set; }
        [Required]
        [DisplayName("Production Year")]
        public int ProductionYear { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [DisplayName("Fuel Type")]
        public string FuelType { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public string Transmission { get; set; }
        [Required]
        public double Mileage { get; set; }
        [Required]
        [Range(1, 9999999)]
        [DisplayName("Sale Price")]
        public double SalePrice { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [DisplayName("Car Specification")]
        public int CarSpecificationId { get; set; }
        [ForeignKey("CarSpecificationId")]
        [ValidateNever]
        public CarSpecification CarSpecification { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        [ValidateNever]
        public Brand Brand { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        [DisplayName("Ad Title")]
        public string AdTitle { get; set; }
        [Required]
        [DisplayName("Ad Description")]
        public string AdDescription { get; set; }

        public string OwnerId { get; set; }
        [ValidateNever]
        public ApplicationUser Owner { get; set; }
    }
}

