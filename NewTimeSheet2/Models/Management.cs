using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewTimeSheet2.Models.Entities
{
    public class Management
    {
        public string EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Manager { get; set; }

    }
}
