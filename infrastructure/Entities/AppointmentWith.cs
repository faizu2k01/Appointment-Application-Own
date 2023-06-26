using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;

namespace infrastructure.Entities
{
    public class AppointmentWith
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string  Email { get; set; }

        public long PhoneNumber { get; set; }

        public DateTime AppointmentTime { get; set; }

        public string AppointmentCause { get; set; }

        public string AppointmentWithProfessionType { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }

        public AppUser User { get; set; }
    }
}
