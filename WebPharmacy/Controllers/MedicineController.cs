using Microsoft.AspNetCore.Mvc;
using WebPharmacy.Models;

namespace WebPharmacy.Controllers
{
    public class MedicineController : Controller
    {
        public IActionResult Index()
        {
            var medicineList = MedicineList();
            var model = new MedicineModel();
            model.MedicineList = medicineList;
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MedicineModel entity)
        {
            TempData["SuccessNotify"] = "Medicine  Add Succesfully";
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var druglist = MedicineList();
            var model = new MedicineModel();
            model = druglist.FirstOrDefault(x => x.Id == id);
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var druglist = MedicineList();
            var model = new MedicineModel();
            model = druglist.FirstOrDefault(x => x.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(MedicineModel entity)
        {
            TempData["SuccessNotify"] = "Medicine  Update Succesfully";
            return RedirectToAction("Index");
        }
        public static List<MedicineModel> MedicineList() { 
        var medicines = new List<MedicineModel>
        {
            new MedicineModel { Id = 1, MedicineName = "Paracetamol", GenericName = "Acetaminophen", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 2, MedicineName = "Ibuprofen", GenericName = "Ibuprofen", CompanyName = "Beximco Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 3, MedicineName = "Amoxicillin", GenericName = "Amoxicillin", CompanyName = "Eskayef", DosageForm = "Capsule", Quantity = 6, Unit = "Capsules" },
            new MedicineModel { Id = 4, MedicineName = "Cefixime", GenericName = "Cefixime", CompanyName = "ACI Pharma", DosageForm = "Capsule", Quantity = 8, Unit = "Capsules" },
            new MedicineModel { Id = 5, MedicineName = "Omeprazole", GenericName = "Omeprazole", CompanyName = "Opsonin Pharma", DosageForm = "Capsule", Quantity = 10, Unit = "Capsules" },
            new MedicineModel { Id = 6, MedicineName = "Salbutamol", GenericName = "Albuterol", CompanyName = "ACI Limited", DosageForm = "Inhaler", Quantity = 200, Unit = "Doses" },
            new MedicineModel { Id = 7, MedicineName = "Montelukast", GenericName = "Montelukast Sodium", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 8, MedicineName = "Cough Syrup", GenericName = "Dextromethorphan", CompanyName = "Renata Limited", DosageForm = "Syrup", Quantity = 100, Unit = "ml" },
            new MedicineModel { Id = 9, MedicineName = "Ceftriaxone", GenericName = "Ceftriaxone", CompanyName = "Popular Pharma", DosageForm = "Injection", Quantity = 1, Unit = "Vial" },
            new MedicineModel { Id = 10, MedicineName = "Hydrocortisone", GenericName = "Hydrocortisone", CompanyName = "GlaxoSmithKline", DosageForm = "Cream", Quantity = 15, Unit = "g" },
            new MedicineModel { Id = 11, MedicineName = "Metformin", GenericName = "Metformin Hydrochloride", CompanyName = "Incepta Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 12, MedicineName = "Losartan", GenericName = "Losartan Potassium", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 13, MedicineName = "Atorvastatin", GenericName = "Atorvastatin Calcium", CompanyName = "Renata Limited", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 14, MedicineName = "Pantoprazole", GenericName = "Pantoprazole Sodium", CompanyName = "ACI Limited", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 15, MedicineName = "Omeprazole", GenericName = "Omeprazole", CompanyName = "Beximco Pharma", DosageForm = "Capsule", Quantity = 14, Unit = "Capsules" },
            new MedicineModel { Id = 16, MedicineName = "Cefuroxime", GenericName = "Cefuroxime Axetil", CompanyName = "Eskayef", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 17, MedicineName = "Montelukast", GenericName = "Montelukast Sodium", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 18, MedicineName = "Dexamethasone", GenericName = "Dexamethasone", CompanyName = "Opsonin Pharma", DosageForm = "Injection", Quantity = 1, Unit = "Vial" },
            new MedicineModel { Id = 19, MedicineName = "Levofloxacin", GenericName = "Levofloxacin", CompanyName = "Incepta Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 20, MedicineName = "Azithromycin", GenericName = "Azithromycin", CompanyName = "ACI Limited", DosageForm = "Tablet", Quantity = 6, Unit = "Tablets" },
            new MedicineModel { Id = 21, MedicineName = "Paracetamol", GenericName = "Acetaminophen", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 22, MedicineName = "Ibuprofen", GenericName = "Ibuprofen", CompanyName = "Beximco Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 23, MedicineName = "Hydroxychloroquine", GenericName = "Hydroxychloroquine Sulfate", CompanyName = "Eskayef", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 24, MedicineName = "Cefixime", GenericName = "Cefixime", CompanyName = "Incepta Pharma", DosageForm = "Capsule", Quantity = 8, Unit = "Capsules" },
            new MedicineModel { Id = 25, MedicineName = "Ranitidine", GenericName = "Ranitidine Hydrochloride", CompanyName = "Renata Limited", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 26, MedicineName = "Clarithromycin", GenericName = "Clarithromycin", CompanyName = "ACI Limited", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 27, MedicineName = "Amoxicillin", GenericName = "Amoxicillin", CompanyName = "Eskayef", DosageForm = "Capsule", Quantity = 10, Unit = "Capsules" },
            new MedicineModel { Id = 28, MedicineName = "Salbutamol", GenericName = "Albuterol", CompanyName = "Square Pharma", DosageForm = "Inhaler", Quantity = 200, Unit = "Doses" },
            new MedicineModel { Id = 29, MedicineName = "Cough Syrup", GenericName = "Dextromethorphan", CompanyName = "Renata Limited", DosageForm = "Syrup", Quantity = 100, Unit = "ml" },
            new MedicineModel { Id = 30, MedicineName = "Fexofenadine", GenericName = "Fexofenadine", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 31, MedicineName = "Losartan", GenericName = "Losartan Potassium", CompanyName = "ACI Limited", DosageForm = "Tablet", Quantity = 30, Unit = "Tablets" },
            new MedicineModel { Id = 32, MedicineName = "Hydrocortisone", GenericName = "Hydrocortisone", CompanyName = "GlaxoSmithKline", DosageForm = "Cream", Quantity = 20, Unit = "g" },
            new MedicineModel { Id = 33, MedicineName = "Doxycycline", GenericName = "Doxycycline", CompanyName = "Eskayef", DosageForm = "Capsule", Quantity = 10, Unit = "Capsules" },
            new MedicineModel { Id = 34, MedicineName = "Prednisone", GenericName = "Prednisone", CompanyName = "Incepta Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 35, MedicineName = "Ceftriaxone", GenericName = "Ceftriaxone", CompanyName = "Popular Pharma", DosageForm = "Injection", Quantity = 1, Unit = "Vial" },
            new MedicineModel { Id = 36, MedicineName = "Vitamin C", GenericName = "Ascorbic Acid", CompanyName = "Square Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 37, MedicineName = "Azithromycin", GenericName = "Azithromycin", CompanyName = "Renata Limited", DosageForm = "Tablet", Quantity = 6, Unit = "Tablets" },
            new MedicineModel { Id = 38, MedicineName = "Loratadine", GenericName = "Loratadine", CompanyName = "Square Pharma", DosageForm = "Syrup", Quantity = 60, Unit = "ml" },
            new MedicineModel { Id = 39, MedicineName = "Cefuroxime", GenericName = "Cefuroxime Axetil", CompanyName = "Beximco Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" },
            new MedicineModel { Id = 40, MedicineName = "Ibuprofen", GenericName = "Ibuprofen", CompanyName = "Opsonin Pharma", DosageForm = "Tablet", Quantity = 10, Unit = "Tablets" }
        };
            return medicines;
        }

    }
}
