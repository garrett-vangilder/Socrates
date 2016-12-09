using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class AssingmentType
    {
        [Key]
        public int AssingmentTypeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int GradeBookId { get; set; }

        [Required]
        public int PercentageOutOf100 { get; set; }

        // Foreign Key Dependencies
        public ICollection<Assignment> Assingment;


    }
}