using CorePharmacy;

namespace WebPharmacy.Models
{
    public class PackagingTypeModel:PackagingType
    {
        public List<PackagingTypeModel> ?PackagingTypeList {  get; set; }
    }
}
