using System;
using System.ComponentModel.DataAnnotations;
namespace candy.Models
{
    public class Candy
    {
        [Key]
        public int CandyId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Name of Candy :")]
        public string Name { get; set; }

        [Required]
        [Range(0,6)]
        [Display(Name = "Sweetness :")]
        public string Sweetness { get; set; }

        [Required]
        [Range(0,5000)]
        [Display(Name = "Calories :")]
        public int Calories { get; set; }

        [Required]
        [Display(Name = "Description :")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}