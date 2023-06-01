using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BK.Models
{
    public class CarSpecification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? SpecificationName { get; set; }
    }
}

