using CorePharmacy;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebPharmacy.Models;

namespace WebPharmacy.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            var purchaseList = PurchaseList();
            var model = new PurchaseModel();
            model.PurchaseList = purchaseList;
            return View(model);
        }
        //public IActionResult Add()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Add(CompanyModel entity)
        //{
        //    TempData["SuccessNotify"] = "PurchaseModel Add Succesfully";
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Details(int id)
        //{
        //    var druglist = PurchaseList();
        //    var model = new CompanyModel();
        //    model = druglist.FirstOrDefault(x => x.Id == id);
        //    return View(model);
        //}
        //public IActionResult Edit(int id)
        //{
        //    var druglist = PurchaseList();
        //    var model = new CompanyModel();
        //    model = druglist.FirstOrDefault(x => x.Id == id);
        //    return View(model);
        //}
        //[HttpPost]
        //public IActionResult Edit(CompanyModel entity)
        //{
        //    TempData["SuccessNotify"] = "PurchaseModel Update Succesfully";
        //    return RedirectToAction("Index");
        //}
        public static List<PurchaseModel> PurchaseList()
        {
            List<PurchaseModel> purchases = new List<PurchaseModel>
{
    new PurchaseModel { Id = 1, RequestBy = "Rasel", PurchaseStore = "Store A", Currency = "USD", Priority = "High", Remarks = "Urgent", Status = "Pending", RequiredDate = DateTime.Now.AddDays(3) },
    new PurchaseModel { Id = 2, RequestBy = "Rahim", PurchaseStore = "Store B", Currency = "EUR", Priority = "Medium", Remarks = "Normal Request", Status = "Approved", RequiredDate = DateTime.Now.AddDays(5) },
    new PurchaseModel { Id = 3, RequestBy = "Karim", PurchaseStore = "Store C", Currency = "USD", Priority = "Low", Remarks = "Routine Check", Status = "Pending", RequiredDate = DateTime.Now.AddDays(7) },
    new PurchaseModel { Id = 4, RequestBy = "Sakib", PurchaseStore = "Store D", Currency = "EUR", Priority = "High", Remarks = "Emergency", Status = "Pending", RequiredDate = DateTime.Now.AddDays(2) },
    new PurchaseModel { Id = 5, RequestBy = "Mamun", PurchaseStore = "Store A", Currency = "USD", Priority = "Medium", Remarks = "Restock Needed", Status = "Approved", RequiredDate = DateTime.Now.AddDays(6) },
    new PurchaseModel { Id = 6, RequestBy = "Hasan", PurchaseStore = "Store B", Currency = "EUR", Priority = "High", Remarks = "Urgent Request", Status = "Pending", RequiredDate = DateTime.Now.AddDays(1) },
    new PurchaseModel { Id = 7, RequestBy = "Faruk", PurchaseStore = "Store C", Currency = "USD", Priority = "Low", Remarks = "General Order", Status = "Approved", RequiredDate = DateTime.Now.AddDays(4) },
    new PurchaseModel { Id = 8, RequestBy = "Imran", PurchaseStore = "Store D", Currency = "EUR", Priority = "High", Remarks = "Critical Need", Status = "Pending", RequiredDate = DateTime.Now.AddDays(3) },
    new PurchaseModel { Id = 9, RequestBy = "Jamil", PurchaseStore = "Store A", Currency = "USD", Priority = "Medium", Remarks = "Stock Refill", Status = "Approved", RequiredDate = DateTime.Now.AddDays(8) },
    new PurchaseModel { Id = 10, RequestBy = "Shuvo", PurchaseStore = "Store B", Currency = "EUR", Priority = "High", Remarks = "Rush Order", Status = "Pending", RequiredDate = DateTime.Now.AddDays(2) },
    new PurchaseModel { Id = 11, RequestBy = "Bashar", PurchaseStore = "Store C", Currency = "USD", Priority = "Low", Remarks = "Scheduled Order", Status = "Approved", RequiredDate = DateTime.Now.AddDays(7) },
    new PurchaseModel { Id = 12, RequestBy = "Nayeem", PurchaseStore = "Store D", Currency = "EUR", Priority = "Medium", Remarks = "Weekly PurchaseModel", Status = "Pending", RequiredDate = DateTime.Now.AddDays(5) },
    new PurchaseModel { Id = 13, RequestBy = "Arafat", PurchaseStore = "Store A", Currency = "USD", Priority = "High", Remarks = "Critical Restock", Status = "Approved", RequiredDate = DateTime.Now.AddDays(6) },
    new PurchaseModel { Id = 14, RequestBy = "Tariq", PurchaseStore = "Store B", Currency = "EUR", Priority = "Low", Remarks = "Routine Order", Status = "Pending", RequiredDate = DateTime.Now.AddDays(3) },
    new PurchaseModel { Id = 15, RequestBy = "Zahid", PurchaseStore = "Store C", Currency = "USD", Priority = "Medium", Remarks = "Replenishment", Status = "Approved", RequiredDate = DateTime.Now.AddDays(4) },
    new PurchaseModel { Id = 16, RequestBy = "Noman", PurchaseStore = "Store D", Currency = "EUR", Priority = "High", Remarks = "Emergency Supply", Status = "Pending", RequiredDate = DateTime.Now.AddDays(2) },
    new PurchaseModel { Id = 17, RequestBy = "Saif", PurchaseStore = "Store A", Currency = "USD", Priority = "Low", Remarks = "Planned Restock", Status = "Approved", RequiredDate = DateTime.Now.AddDays(9) },
    new PurchaseModel { Id = 18, RequestBy = "Rafiq", PurchaseStore = "Store B", Currency = "EUR", Priority = "Medium", Remarks = "Additional Order", Status = "Pending", RequiredDate = DateTime.Now.AddDays(6) },
    new PurchaseModel { Id = 19, RequestBy = "Sohail", PurchaseStore = "Store C", Currency = "USD", Priority = "High", Remarks = "Critical Stock", Status = "Approved", RequiredDate = DateTime.Now.AddDays(3) },
    new PurchaseModel { Id = 20, RequestBy = "Adnan", PurchaseStore = "Store D", Currency = "EUR", Priority = "Medium", Remarks = "On-Demand PurchaseModel", Status = "Pending", RequiredDate = DateTime.Now.AddDays(5) }
};
            return purchases;
        }
        public static List<PurchaseMedicine> PurchaseMedicineList()
        {
            List<PurchaseMedicine> purchaseMedicines = new List<PurchaseMedicine>
{
    // ✅ Purchase 1-5-এর Medicine আগের মতোই আছে...

    // ✅ Purchase 6-এর জন্য Medicine
    new PurchaseMedicine { Id = 12, MedicineName = "Aspirin", PurchasePrice = 9.5m, SellingPrice = 14m, SKU = "MED-012", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 55, PurchaseId = 6 },
    new PurchaseMedicine { Id = 13, MedicineName = "Atorvastatin", PurchasePrice = 28m, SellingPrice = 40m, SKU = "MED-013", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 25, PurchaseId = 6 },
    new PurchaseMedicine { Id = 14, MedicineName = "Clopidogrel", PurchasePrice = 22m, SellingPrice = 35m, SKU = "MED-014", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 30, PurchaseId = 6 },

    // ✅ Purchase 7-এর জন্য Medicine
    new PurchaseMedicine { Id = 15, MedicineName = "Furosemide", PurchasePrice = 15m, SellingPrice = 24m, SKU = "MED-015", ExpiryDate = DateTime.Now.AddMonths(10), StockQuantity = 60, PurchaseId = 7 },
    new PurchaseMedicine { Id = 16, MedicineName = "Lisinopril", PurchasePrice = 18m, SellingPrice = 27m, SKU = "MED-016", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 45, PurchaseId = 7 },

    // ✅ Purchase 8-এর জন্য Medicine
    new PurchaseMedicine { Id = 17, MedicineName = "Metoprolol", PurchasePrice = 26m, SellingPrice = 37m, SKU = "MED-017", ExpiryDate = DateTime.Now.AddMonths(16), StockQuantity = 35, PurchaseId = 8 },
    new PurchaseMedicine { Id = 18, MedicineName = "Carvedilol", PurchasePrice = 12m, SellingPrice = 19m, SKU = "MED-018", ExpiryDate = DateTime.Now.AddMonths(22), StockQuantity = 25, PurchaseId = 8 },

    // ✅ Purchase 9-এর জন্য Medicine
    new PurchaseMedicine { Id = 19, MedicineName = "Pantoprazole", PurchasePrice = 10m, SellingPrice = 15m, SKU = "MED-019", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 50, PurchaseId = 9 },
    new PurchaseMedicine { Id = 20, MedicineName = "Esomeprazole", PurchasePrice = 14m, SellingPrice = 21m, SKU = "MED-020", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 40, PurchaseId = 9 },

    // ✅ Purchase 10-এর জন্য Medicine
    new PurchaseMedicine { Id = 21, MedicineName = "Simvastatin", PurchasePrice = 25m, SellingPrice = 38m, SKU = "MED-021", ExpiryDate = DateTime.Now.AddMonths(14), StockQuantity = 30, PurchaseId = 10 },
    new PurchaseMedicine { Id = 22, MedicineName = "Rosuvastatin", PurchasePrice = 30m, SellingPrice = 45m, SKU = "MED-022", ExpiryDate = DateTime.Now.AddMonths(24), StockQuantity = 20, PurchaseId = 10 },

    // ✅ Purchase 11-এর জন্য Medicine
    new PurchaseMedicine { Id = 23, MedicineName = "Fluoxetine", PurchasePrice = 19m, SellingPrice = 28m, SKU = "MED-023", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 40, PurchaseId = 11 },
    new PurchaseMedicine { Id = 24, MedicineName = "Sertraline", PurchasePrice = 17m, SellingPrice = 25m, SKU = "MED-024", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 45, PurchaseId = 11 },

    // ✅ Purchase 12-এর জন্য Medicine
    new PurchaseMedicine { Id = 25, MedicineName = "Amlodipine", PurchasePrice = 22m, SellingPrice = 32m, SKU = "MED-025", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 50, PurchaseId = 12 },
    new PurchaseMedicine { Id = 26, MedicineName = "Hydrochlorothiazide", PurchasePrice = 10m, SellingPrice = 15m, SKU = "MED-026", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 30, PurchaseId = 12 },
    // ✅ Purchase 13-এর জন্য Medicine
new PurchaseMedicine { Id = 27, MedicineName = "Fluconazole", PurchasePrice = 16m, SellingPrice = 24m, SKU = "MED-027", ExpiryDate = DateTime.Now.AddMonths(15), StockQuantity = 40, PurchaseId = 13 },
new PurchaseMedicine { Id = 28, MedicineName = "Clarithromycin", PurchasePrice = 22m, SellingPrice = 33m, SKU = "MED-028", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 35, PurchaseId = 13 },
new PurchaseMedicine { Id = 29, MedicineName = "Levofloxacin", PurchasePrice = 25m, SellingPrice = 38m, SKU = "MED-029", ExpiryDate = DateTime.Now.AddMonths(22), StockQuantity = 30, PurchaseId = 13 },

// ✅ Purchase 14-এর জন্য Medicine
new PurchaseMedicine { Id = 30, MedicineName = "Prednisone", PurchasePrice = 18m, SellingPrice = 27m, SKU = "MED-030", ExpiryDate = DateTime.Now.AddMonths(14), StockQuantity = 45, PurchaseId = 14 },
new PurchaseMedicine { Id = 31, MedicineName = "Hydroxychloroquine", PurchasePrice = 28m, SellingPrice = 42m, SKU = "MED-031", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 25, PurchaseId = 14 },

// ✅ Purchase 15-এর জন্য Medicine
new PurchaseMedicine { Id = 32, MedicineName = "Warfarin", PurchasePrice = 14m, SellingPrice = 22m, SKU = "MED-032", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 50, PurchaseId = 15 },
new PurchaseMedicine { Id = 33, MedicineName = "Apixaban", PurchasePrice = 32m, SellingPrice = 48m, SKU = "MED-033", ExpiryDate = DateTime.Now.AddMonths(24), StockQuantity = 20, PurchaseId = 15 },
new PurchaseMedicine { Id = 34, MedicineName = "Rivaroxaban", PurchasePrice = 30m, SellingPrice = 45m, SKU = "MED-034", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 30, PurchaseId = 15 },

// ✅ Purchase 16-এর জন্য Medicine
new PurchaseMedicine { Id = 35, MedicineName = "Dabigatran", PurchasePrice = 27m, SellingPrice = 40m, SKU = "MED-035", ExpiryDate = DateTime.Now.AddMonths(16), StockQuantity = 35, PurchaseId = 16 },
new PurchaseMedicine { Id = 36, MedicineName = "Clonazepam", PurchasePrice = 19m, SellingPrice = 28m, SKU = "MED-036", ExpiryDate = DateTime.Now.AddMonths(14), StockQuantity = 40, PurchaseId = 16 },

// ✅ Purchase 17-এর জন্য Medicine
new PurchaseMedicine { Id = 37, MedicineName = "Diazepam", PurchasePrice = 10m, SellingPrice = 15m, SKU = "MED-037", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 50, PurchaseId = 17 },
new PurchaseMedicine { Id = 38, MedicineName = "Lorazepam", PurchasePrice = 14m, SellingPrice = 21m, SKU = "MED-038", ExpiryDate = DateTime.Now.AddMonths(22), StockQuantity = 30, PurchaseId = 17 },
new PurchaseMedicine { Id = 39, MedicineName = "Alprazolam", PurchasePrice = 16m, SellingPrice = 24m, SKU = "MED-039", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 35, PurchaseId = 17 },

// ✅ Purchase 18-এর জন্য Medicine
new PurchaseMedicine { Id = 40, MedicineName = "Pregabalin", PurchasePrice = 20m, SellingPrice = 30m, SKU = "MED-040", ExpiryDate = DateTime.Now.AddMonths(24), StockQuantity = 25, PurchaseId = 18 },
new PurchaseMedicine { Id = 41, MedicineName = "Gabapentin", PurchasePrice = 22m, SellingPrice = 33m, SKU = "MED-041", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 30, PurchaseId = 18 },

// ✅ Purchase 19-এর জন্য Medicine
new PurchaseMedicine { Id = 42, MedicineName = "Topiramate", PurchasePrice = 19m, SellingPrice = 28m, SKU = "MED-042", ExpiryDate = DateTime.Now.AddMonths(16), StockQuantity = 40, PurchaseId = 19 },
new PurchaseMedicine { Id = 43, MedicineName = "Valproic Acid", PurchasePrice = 25m, SellingPrice = 38m, SKU = "MED-043", ExpiryDate = DateTime.Now.AddMonths(14), StockQuantity = 35, PurchaseId = 19 },
new PurchaseMedicine { Id = 44, MedicineName = "Lamotrigine", PurchasePrice = 27m, SellingPrice = 40m, SKU = "MED-044", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 30, PurchaseId = 19 },

// ✅ Purchase 20-এর জন্য Medicine
new PurchaseMedicine { Id = 45, MedicineName = "Quetiapine", PurchasePrice = 23m, SellingPrice = 35m, SKU = "MED-045", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 40, PurchaseId = 20 },
new PurchaseMedicine { Id = 46, MedicineName = "Olanzapine", PurchasePrice = 28m, SellingPrice = 42m, SKU = "MED-046", ExpiryDate = DateTime.Now.AddMonths(16), StockQuantity = 35, PurchaseId = 20 },
new PurchaseMedicine { Id = 47, MedicineName = "Risperidone", PurchasePrice = 22m, SellingPrice = 33m, SKU = "MED-047", ExpiryDate = DateTime.Now.AddMonths(24), StockQuantity = 30, PurchaseId = 20 },
new PurchaseMedicine { Id = 12, MedicineName = "Aspirin", PurchasePrice = 9.5m, SellingPrice = 14m, SKU = "MED-012", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 55, PurchaseId = 6 },
    new PurchaseMedicine { Id = 13, MedicineName = "Atorvastatin", PurchasePrice = 28m, SellingPrice = 40m, SKU = "MED-013", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 25, PurchaseId = 6 },
    new PurchaseMedicine { Id = 14, MedicineName = "Clopidogrel", PurchasePrice = 22m, SellingPrice = 35m, SKU = "MED-014", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 30, PurchaseId = 6 },

    // ✅ Purchase 7-এর জন্য Medicine
    new PurchaseMedicine { Id = 15, MedicineName = "Furosemide", PurchasePrice = 15m, SellingPrice = 24m, SKU = "MED-015", ExpiryDate = DateTime.Now.AddMonths(10), StockQuantity = 60, PurchaseId = 7 },
    new PurchaseMedicine { Id = 16, MedicineName = "Lisinopril", PurchasePrice = 18m, SellingPrice = 27m, SKU = "MED-016", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 45, PurchaseId = 7 },

    // ✅ Purchase 8-এর জন্য Medicine
    new PurchaseMedicine { Id = 17, MedicineName = "Metoprolol", PurchasePrice = 26m, SellingPrice = 37m, SKU = "MED-017", ExpiryDate = DateTime.Now.AddMonths(16), StockQuantity = 35, PurchaseId = 8 },
    new PurchaseMedicine { Id = 18, MedicineName = "Carvedilol", PurchasePrice = 12m, SellingPrice = 19m, SKU = "MED-018", ExpiryDate = DateTime.Now.AddMonths(22), StockQuantity = 25, PurchaseId = 8 },

    // ✅ Purchase 9-এর জন্য Medicine
    new PurchaseMedicine { Id = 19, MedicineName = "Pantoprazole", PurchasePrice = 10m, SellingPrice = 15m, SKU = "MED-019", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 50, PurchaseId = 9 },
    new PurchaseMedicine { Id = 20, MedicineName = "Esomeprazole", PurchasePrice = 14m, SellingPrice = 21m, SKU = "MED-020", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 40, PurchaseId = 9 },

    // ✅ Purchase 10-এর জন্য Medicine
    new PurchaseMedicine { Id = 21, MedicineName = "Simvastatin", PurchasePrice = 25m, SellingPrice = 38m, SKU = "MED-021", ExpiryDate = DateTime.Now.AddMonths(14), StockQuantity = 30, PurchaseId = 10 },
    new PurchaseMedicine { Id = 22, MedicineName = "Rosuvastatin", PurchasePrice = 30m, SellingPrice = 45m, SKU = "MED-022", ExpiryDate = DateTime.Now.AddMonths(24), StockQuantity = 20, PurchaseId = 10 },

    // ✅ Purchase 11-এর জন্য Medicine
    new PurchaseMedicine { Id = 23, MedicineName = "Fluoxetine", PurchasePrice = 19m, SellingPrice = 28m, SKU = "MED-023", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 40, PurchaseId = 11 },
    new PurchaseMedicine { Id = 24, MedicineName = "Sertraline", PurchasePrice = 17m, SellingPrice = 25m, SKU = "MED-024", ExpiryDate = DateTime.Now.AddMonths(12), StockQuantity = 45, PurchaseId = 11 },

    // ✅ Purchase 12-এর জন্য Medicine
    new PurchaseMedicine { Id = 25, MedicineName = "Amlodipine", PurchasePrice = 22m, SellingPrice = 32m, SKU = "MED-025", ExpiryDate = DateTime.Now.AddMonths(18), StockQuantity = 50, PurchaseId = 12 },
    new PurchaseMedicine { Id = 26, MedicineName = "Hydrochlorothiazide", PurchasePrice = 10m, SellingPrice = 15m, SKU = "MED-026", ExpiryDate = DateTime.Now.AddMonths(20), StockQuantity = 30, PurchaseId = 12 },


    // ✅ Purchase 13-20 এর জন্য র‌্যান্ডম Medicine যুক্ত করছি
};
            return purchaseMedicines;
        }
    }
}
