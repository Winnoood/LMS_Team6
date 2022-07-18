using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Team6.Models
{
    public partial class Leave
    {
        public int LeaveId { get; set; }
        public string LeaveDetails { get; set; }
        public int? UseLeave { get; set; }
        public int? NoofDays { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
