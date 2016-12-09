using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        [Required]
        public string SchoolWebSiteUrl { get; set; }

        // Foreign Key Dependencies
        public ICollection<Educator> Educator;
        public ICollection<Student> Student;
        public ICollection<ClassPeriod> ClassPeriod;




    }
}