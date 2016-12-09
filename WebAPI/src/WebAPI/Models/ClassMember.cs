using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ClassMember
    {
        [Key]
        public int ClassMemberId { get; set; }

        [Required]
        public int? ClassId { get; set; }

        [Required]
        public int StudentId { get; set; }

        // Foreign Key Dependencies
        public ICollection<Grade> Grade;
    }
}