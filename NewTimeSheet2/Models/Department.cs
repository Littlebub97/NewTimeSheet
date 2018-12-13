using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewTimeSheet2.Models
{
    [Table("Department", Schema = "NewTimeSheet2")]
    public class Department 
    {       

            [Required]
            [DataType(DataType.Text), MaxLength(50)]
            public string DepartmentName { get; set; }

            [Required]
            [DataType(DataType.Text), MaxLength(50), Display(Name = "Roles")]
            public string Role { get; set; }


    }
}
