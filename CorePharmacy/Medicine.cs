using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePharmacy
{
    public class Medicine
    {
        
            public int Id { get; set; }  // Unique identifier for the medicine
            public string? MedicineName { get; set; }  // The name of the medicine (e.g., Paracetamol)
            public string? GenericName { get; set; }  // The generic name (e.g., Acetaminophen)
            public string? CompanyName { get; set; }  // The manufacturing company (e.g., XYZ Pharma)
            public string? DosageForm { get; set; }  // Navigation property to DosageForm entity
            public int Quantity { get; set; }  // Number of units in the package (e.g., 10 tablets, 100 ml)
            public string? Unit { get; set; }  // The unit of measurement (e.g., tablets, ml, strips)
            public string? PackagingType { get; set; }  // E.g., Box, Bottle, Strip, Vial, etc.

    }
}
