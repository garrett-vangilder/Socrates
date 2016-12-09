using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        [Required]
        public int AssingmentTypeId { get; set; }

        [Required]
        public int TotalPossiblePoints { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        // Foreign Key Dependencies
        public ICollection<Grade> Grades;

    }
}