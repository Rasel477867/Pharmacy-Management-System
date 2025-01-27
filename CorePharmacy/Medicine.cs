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

            // Foreign Key to DosageForm entity
        //    public int DosageFormId { get; set; }  // Reference to the DosageForm entity (e.g., Tablet, Syrup)
            public string? DosageForm { get; set; }  // Navigation property to DosageForm entity

            // Additional properties for the medicine package
            public int Quantity { get; set; }  // Number of units in the package (e.g., 10 tablets, 100 ml)
            public string? Unit { get; set; }  // The unit of measurement (e.g., tablets, ml, strips)

            // New property for Packaging Type
            public string? PackagingType { get; set; }  // E.g., Box, Bottle, Strip, Vial, etc.

            // Optional: Price or cost-related field (if required)
            public decimal Price { get; set; }  // Price of the medicine (optional, if you need to manage it)

            // Optional: A description field for additional info about the medicine
            public string? Description { get; set; }  // (e.g., "Used for fever and pain relief")

            // Optional: Expiry Date for medicine
            public DateTime ExpiryDate { get; set; }  // To track when the medicine expires
        

    }
}
