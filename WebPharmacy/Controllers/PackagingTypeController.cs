using CorePharmacy;
using Microsoft.AspNetCore.Mvc;
using WebPharmacy.Models;

namespace WebPharmacy.Controllers
{
    public class PackagingTypeController : Controller
    {
        public IActionResult Index()
        {
            var packaginglist = PackagingTypeList();
            var model = new PackagingTypeModel();
            model.PackagingTypeList = packaginglist;
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PackagingTypeModel entity)
        {
            TempData["SuccessNotify"] = "Packaging Type Add Succesfully";
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var druglist = PackagingTypeList();
            var model = new PackagingTypeModel();
            model = druglist.FirstOrDefault(x => x.Id == id);
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var druglist = PackagingTypeList();
            var model = new PackagingTypeModel();
            model = druglist.FirstOrDefault(x => x.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(PackagingTypeModel entity)
        {
            TempData["SuccessNotify"] = "Packaging Type Update Succesfully";
            return RedirectToAction("Index");
        }
        public static List<PackagingTypeModel> PackagingTypeList()
        {
            var packagingTypes = new List<PackagingTypeModel>
{
    new PackagingTypeModel { Id = 1, Name = "Blister Pack", Description = "A pre-formed plastic packaging for tablets or capsules." },
    new PackagingTypeModel { Id = 2, Name = "Bottle", Description = "Plastic or glass container used for syrups, liquids, or tablets." },
    new PackagingTypeModel { Id = 3, Name = "Strip Pack", Description = "Sealed foil or plastic strips for individual doses." },
    new PackagingTypeModel { Id = 4, Name = "Vial", Description = "Small glass container used for injections or liquid medicines." },
    new PackagingTypeModel { Id = 5, Name = "Ampoule", Description = "Sealed glass container for single-dose injections." },
    new PackagingTypeModel { Id = 6, Name = "Tube", Description = "Flexible packaging for ointments, creams, or gels." },
    new PackagingTypeModel { Id = 7, Name = "Sachet", Description = "Small packet for powders or granules." },
    new PackagingTypeModel { Id = 8, Name = "Jar", Description = "Wide-mouthed container for creams or ointments." },
    new PackagingTypeModel { Id = 9, Name = "Pouch", Description = "Flexible packaging used for liquids or semi-liquids." },
    new PackagingTypeModel { Id = 10, Name = "Cartridge", Description = "Container for medicines used in pen injectors." },
    new PackagingTypeModel { Id = 11, Name = "Dropper Bottle", Description = "Bottle with a dropper for liquid medicines." },
    new PackagingTypeModel { Id = 12, Name = "Spray Bottle", Description = "Bottle designed for medicines administered as sprays." },
    new PackagingTypeModel { Id = 13, Name = "Stick Pack", Description = "Slim, single-serve sachet for powders or granules." },
    new PackagingTypeModel { Id = 14, Name = "Canister", Description = "Metal or plastic container for aerosols or sprays." },
    new PackagingTypeModel { Id = 15, Name = "Carton Box", Description = "Outer packaging for multiple units of medicines." },
    new PackagingTypeModel { Id = 16, Name = "Blister Card", Description = "Cardboard backing with plastic blister for tablets." },
    new PackagingTypeModel { Id = 17, Name = "Syringe", Description = "Pre-filled disposable syringe for injections." },
    new PackagingTypeModel { Id = 18, Name = "Wrap", Description = "Packaging wrap for external medicinal products." },
    new PackagingTypeModel { Id = 19, Name = "Plastic Container", Description = "General-purpose container for tablets or powders." },
    new PackagingTypeModel { Id = 20, Name = "Foil Pouch", Description = "Pouch made of foil for medicines sensitive to moisture." },
    new PackagingTypeModel { Id = 21, Name = "Glass Jar", Description = "Reusable glass container for ointments or creams." },
    new PackagingTypeModel { Id = 22, Name = "Cardboard Tube", Description = "Cylindrical packaging for lozenges or granules." },
    new PackagingTypeModel { Id = 23, Name = "Plastic Tube", Description = "Flexible plastic packaging for creams or gels." },
    new PackagingTypeModel { Id = 24, Name = "Multi-Dose Vial", Description = "Vial for multiple doses of liquid medication." },
    new PackagingTypeModel { Id = 25, Name = "Single-Use Sachet", Description = "Sachet designed for one-time use." },
    new PackagingTypeModel { Id = 26, Name = "Pen Injector", Description = "Pen-shaped device for self-administering injections." },
    new PackagingTypeModel { Id = 27, Name = "Capsule Shell", Description = "Outer shell for encapsulated medicines." },
    new PackagingTypeModel { Id = 28, Name = "Paper Wrap", Description = "Simple paper packaging for powders or tablets." },
    new PackagingTypeModel { Id = 29, Name = "Glass Bottle", Description = "Glass container for syrups, liquids, or suspensions." },
    new PackagingTypeModel { Id = 30, Name = "Plastic Blister", Description = "Plastic blister packaging for tablets or capsules." }
};
            return packagingTypes;
        }
    }
}
