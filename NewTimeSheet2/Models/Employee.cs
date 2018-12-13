using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace NewTimeSheet2.Models
{
    [Table("Employee", Schema = "NewTimeSheet2")]
    public class Employee : IdentityUser
    {
        [Required]
        [DataType(DataType.Text), MaxLength(50)]
        public string EmployeeName { get; set; }

        [Required]
        [DataType(DataType.Text), MaxLength(50)]
        public string firstName {get; set; }

        [Required]
        [DataType(DataType.Text), MaxLength(50)]
        public string lastName { get; set; }

        [DataType(DataType.PhoneNumber), MaxLength(50)]
        public string PhoneNumber { get; set; }
    
        [DataType(DataType.EmailAddress), MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password), MaxLength(200)]
        public string Password { get; set; }

        [Required]
        public bool exempt { get; set; }

        [Required]
        [DataType(DataType.Text), MaxLength(100)]
        public string address { get; set; }

        [DataType(DataType.Currency)]
        public decimal pay { get; set; }//wage by hour
    }
}
