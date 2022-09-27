using Microsoft.AspNetCore.Identity;

namespace Leave_Management_.NET_.Data
{
    public class Employee :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
