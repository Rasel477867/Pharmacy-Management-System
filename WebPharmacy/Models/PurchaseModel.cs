using CorePharmacy;

namespace WebPharmacy.Models
{
    public class PurchaseModel:Purchase
    {
        public List<PurchaseModel>? PurchaseList { get; set; }
        public List<PurchaseMedicine>? PurchaseMedicineList { get; set; }
    }
}
