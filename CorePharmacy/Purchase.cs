using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePharmacy
{
    public class Purchase
    {
        public int Id { get; set; }
        public string? RequestBy { get; set; }
        public string? PurchaseStore { get; set; }
        public string? Currency { get; set; }
        public string? Priority { get; set; }
        public string? Remarks { get; set; }
        public string? Status { get; set; }
        public DateTime RequiredDate { get; set; }
    }
}
