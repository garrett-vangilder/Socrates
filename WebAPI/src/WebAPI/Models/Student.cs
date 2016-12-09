using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public int FirebaseUid { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]
        public int SchoolId { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string GuardianFirstName { get; set; }

        [Required]
        public string GuardianLastName { get; set; }

        [Required]
        public long GuardianPhoneNumber { get; set; }

        [Required]
        public string GuardianEmailAddress { get; set; }

        // Foreign Key Dependencies
        public ICollection<ClassMember> ClassMember;


    }
}