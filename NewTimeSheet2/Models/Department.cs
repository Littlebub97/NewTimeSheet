using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheet.Models.Entities
{
    [Table("Department", Schema = "TimeSheet")]
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
