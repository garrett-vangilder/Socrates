using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class GradeBook
    {
        [Key]
        public int GradeBookId { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        public int EducatorId { get; set; }

        // Foreign Key Dependencies
        public ICollection<AssingmentType> AssingmentType;

    }
}