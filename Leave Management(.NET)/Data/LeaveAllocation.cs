using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Leave_Management_.NET_.Data
{
    public class LeaveAllocation: BaseClass
    {
        public int NoofDays { get; set; }

        [ForeignKey("LeaveTypeId")]

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
    }
}
