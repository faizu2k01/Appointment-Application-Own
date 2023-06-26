using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace infrastructure.Entities
{
    public  class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }

        public ICollection<AppointmentWith> AppointmentWiths { get; set; }
    }
}
