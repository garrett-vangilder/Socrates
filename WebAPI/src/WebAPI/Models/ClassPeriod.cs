using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ClassPeriod
    {
        [Key]
        public int ClassPeriodId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        public int SchoolId { get; set; }

        // Foreign Key Dependencies
        public ICollection<Class> Class;
    }
}