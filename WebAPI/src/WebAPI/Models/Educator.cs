using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Educator
    {
        [Key]
        public int EducatorId { get; set; }
        public int FirebaseUid { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public bool Admin { get; set; }

        public int? SchoolId { get; set; }

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

        // Foreign Key Dependencies
        public ICollection<Class> Class;
        public ICollection<GradeBook> GradeBook;

    }
}