using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [Required]
        public int AssingmentId { get; set; }

        [Required]
        public int ClassMemberId { get; set; }

        [Required]
        public int PointsEarned { get; set; }

    }
}