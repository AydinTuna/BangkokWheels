using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace BK.Models
{
    public class Ad
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }
    }
}

