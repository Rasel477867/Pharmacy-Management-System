using CorePharmacy;

namespace WebPharmacy.Models
{
    public class MedicineModel:Medicine
    {
        public List<MedicineModel>? MedicineList { get; set; }
    }
}
