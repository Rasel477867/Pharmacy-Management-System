using Microsoft.AspNetCore.Mvc;
using WebPharmacy.Models;

namespace WebPharmacy.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            var companyList = CompanyList();
            var model = new CompanyModel();
            model.CompanyList = companyList;
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CompanyModel entity)
        {
            TempData["SuccessNotify"] = "Company Type Add Succesfully";
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var druglist = CompanyList();
            var model = new CompanyModel();
            model = druglist.FirstOrDefault(x => x.Id == id);
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var druglist = CompanyList();
            var model = new CompanyModel();
            model = druglist.FirstOrDefault(x => x.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(CompanyModel entity)
        {
            TempData["SuccessNotify"] = "Company Type Update Succesfully";
            return RedirectToAction("Index");
        }
        public static List<CompanyModel> CompanyList()
        {
            return new List<CompanyModel>
        {
            new CompanyModel { Id = 1, Name = "Square Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880123456789", Email = "info@square.com", Website = "www.squarepharma.com" },
            new CompanyModel { Id = 2, Name = "Beximco Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880987654321", Email = "info@beximco.com", Website = "www.beximcopharma.com" },
            new CompanyModel { Id = 3, Name = "ACI Limited", Address = "Dhaka, Bangladesh", ContactNumber = "+880123498765", Email = "info@aci-bd.com", Website = "www.aci-bd.com" },
            new CompanyModel { Id = 4, Name = "Renata Limited", Address = "Dhaka, Bangladesh", ContactNumber = "+880112233445", Email = "info@renata-ltd.com", Website = "www.renata-ltd.com" },
            new CompanyModel { Id = 5, Name = "Incepta Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880223344556", Email = "info@inceptapharma.com", Website = "www.inceptapharma.com" },
            new CompanyModel { Id = 6, Name = "Eskayef Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880334455667", Email = "info@eskayef.com", Website = "www.eskayefbd.com" },
            new CompanyModel { Id = 7, Name = "Aristopharma Limited", Address = "Dhaka, Bangladesh", ContactNumber = "+880445566778", Email = "info@aristopharma.com", Website = "www.aristopharma.com" },
            new CompanyModel { Id = 8, Name = "GlaxoSmithKline (GSK)", Address = "Dhaka, Bangladesh", ContactNumber = "+880556677889", Email = "info@gsk.com", Website = "www.gsk.com" },
            new CompanyModel { Id = 9, Name = "Sanofi Bangladesh", Address = "Dhaka, Bangladesh", ContactNumber = "+880667788990", Email = "info@sanofi.com", Website = "www.sanofi.com" },
            new CompanyModel { Id = 10, Name = "Novo Nordisk", Address = "Dhaka, Bangladesh", ContactNumber = "+880778899001", Email = "info@novonordisk.com", Website = "www.novonordisk.com" },
            new CompanyModel { Id = 11, Name = "Orion Pharma", Address = "Dhaka, Bangladesh", ContactNumber = "+880889900112", Email = "info@orionpharma.com", Website = "www.orionpharma.com" },
            new CompanyModel { Id = 12, Name = "General Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880990011223", Email = "info@generalpharma.com", Website = "www.generalpharma.com" },
            new CompanyModel { Id = 13, Name = "Ziska Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880110022334", Email = "info@ziskapharma.com", Website = "www.ziskapharma.com" },
            new CompanyModel { Id = 14, Name = "Popular Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880220033445", Email = "info@popularpharma.com", Website = "www.popularpharma.com" },
            new CompanyModel { Id = 15, Name = "Healthcare Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880330044556", Email = "info@hcpharma.com", Website = "www.hcpharma.com" },
            new CompanyModel { Id = 16, Name = "ACI Animal Health", Address = "Dhaka, Bangladesh", ContactNumber = "+880440055667", Email = "info@aci-animalhealth.com", Website = "www.aci-animalhealth.com" },
            new CompanyModel { Id = 17, Name = "Beacon Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880550066778", Email = "info@beaconpharma.com", Website = "www.beaconpharma.com" },
            new CompanyModel { Id = 18, Name = "Drug International", Address = "Dhaka, Bangladesh", ContactNumber = "+880660077889", Email = "info@drug-international.com", Website = "www.drug-international.com" },
            new CompanyModel { Id = 19, Name = "Opso Saline Ltd.", Address = "Dhaka, Bangladesh", ContactNumber = "+880770088990", Email = "info@opso-saline.com", Website = "www.opso-saline.com" },
            new CompanyModel { Id = 20, Name = "Acme Laboratories", Address = "Dhaka, Bangladesh", ContactNumber = "+880880099001", Email = "info@acme-labs.com", Website = "www.acme-labs.com" },
            new CompanyModel { Id = 21, Name = "Rangs Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880990001112", Email = "info@rangspharma.com", Website = "www.rangspharma.com" },
            new CompanyModel { Id = 22, Name = "Nuvista Pharma", Address = "Dhaka, Bangladesh", ContactNumber = "+880112233446", Email = "info@nuvista.com", Website = "www.nuvistapharma.com" },
            new CompanyModel { Id = 23, Name = "Medimet Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880223344557", Email = "info@medimetpharma.com", Website = "www.medimetpharma.com" },
            new CompanyModel { Id = 24, Name = "Serapharma Ltd.", Address = "Dhaka, Bangladesh", ContactNumber = "+880334455668", Email = "info@serapharma.com", Website = "www.serapharma.com" },
            new CompanyModel { Id = 25, Name = "Biopharma Limited", Address = "Dhaka, Bangladesh", ContactNumber = "+880445566779", Email = "info@biopharma.com", Website = "www.biopharma.com" },
            new CompanyModel { Id = 26, Name = "Labaid Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880556677880", Email = "info@labaidpharma.com", Website = "www.labaidpharma.com" },
            new CompanyModel { Id = 27, Name = "Hudson Pharmaceuticals", Address = "Dhaka, Bangladesh", ContactNumber = "+880667788991", Email = "info@hudsonpharma.com", Website = "www.hudsonpharma.com" },
            new CompanyModel { Id = 28, Name = "Herbal Remedies", Address = "Dhaka, Bangladesh", ContactNumber = "+880778899002", Email = "info@herbalremedies.com", Website = "www.herbalremedies.com" },
            new CompanyModel { Id = 29, Name = "Cosmic Pharma", Address = "Dhaka, Bangladesh", ContactNumber = "+880889900113", Email = "info@cosmicpharma.com", Website = "www.cosmicpharma.com" },
            new CompanyModel { Id = 30, Name = "Mega Pharma Ltd.", Address = "Dhaka, Bangladesh", ContactNumber = "+880990011224", Email = "info@megapharma.com", Website = "www.megapharma.com" }
        };
        }
    }
}
