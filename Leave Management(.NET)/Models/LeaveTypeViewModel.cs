using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Leave_Management_.NET_.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "LeaveType")]
        [Required]

        public string Name { get; set; }

        [Display(Name =" Default no of days")]
        [Required]
        [Range(1,30, ErrorMessage="Please Enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
