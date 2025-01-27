using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePharmacy
{
    public class Company
    {
        public int Id { get; set; } // Primary key
        public string? Name { get; set; } // Company name
        public string? Address { get; set; } // Company address
        public string? ContactNumber { get; set; } // Phone number
        public string? Email { get; set; } // Official email
        public string?  Website { get; set; } // Website link (optional)
    }
}
