using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePharmacy
{
    public class PurchaseMedicine
    {
        public int Id { get; set; }
        public string? MedicineName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string? SKU { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int StockQuantity { get; set; }
        public int PurchaseId { get; set; }
    }
}
