using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Team6.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseManager = new HashSet<Employee>();
            Leaves = new HashSet<Leave>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int? ManagerId { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
    }
}
