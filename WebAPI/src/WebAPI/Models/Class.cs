using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ClassPeriodId { get; set; }

        [Required]
        public int EducatorId { get; set; }

        public string Subject { get; set; }

        // Foreign Key Dependencies
        public ICollection<ClassMember> ClassMember;
        public ICollection<GradeBook> GradeBook;
    }
}