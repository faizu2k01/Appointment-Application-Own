using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Entities
{
    public class Professional
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

        public string Profession { get; set; }

        public string MajorFeild { get; set; }

        public int Experiance { get; set; }

        public string Description { get; set; }
    }
}
