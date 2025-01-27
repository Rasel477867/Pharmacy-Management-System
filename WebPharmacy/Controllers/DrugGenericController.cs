using Microsoft.AspNetCore.Mvc;
using WebPharmacy.Models;

namespace WebPharmacy.Controllers
{
    public class DrugGenericController : Controller
    {
        public IActionResult Index()
        {
            var druglist = DrugGenericList();
            var model=new DrugGenericModel();
            model.DrugGenericList = druglist;
            return View(model);
        }
        public static List<DrugGenericModel> DrugGenericList()
        {
            var drugGenericModels = new List<DrugGenericModel>
{
    new DrugGenericModel { Id = 1, Name = "Paracetamol", Description = "Pain reliever and fever reducer." },
    new DrugGenericModel { Id = 2, Name = "Ibuprofen", Description = "Nonsteroidal anti-inflammatory drug (NSAID) used for pain and inflammation." },
    new DrugGenericModel { Id = 3, Name = "Aspirin", Description = "Pain reliever, anti-inflammatory, and blood thinner." },
    new DrugGenericModel { Id = 4, Name = "Amoxicillin", Description = "Antibiotic used to treat various bacterial infections." },
    new DrugGenericModel { Id = 5, Name = "Cetirizine", Description = "Antihistamine used for allergy symptoms." },
    new DrugGenericModel { Id = 6, Name = "Loratadine", Description = "Antihistamine for allergy symptoms." },
    new DrugGenericModel { Id = 7, Name = "Metformin", Description = "Used to manage type 2 diabetes." },
    new DrugGenericModel { Id = 8, Name = "Simvastatin", Description = "Statin used to lower cholesterol levels." },
    new DrugGenericModel { Id = 9, Name = "Omeprazole", Description = "Proton pump inhibitor used to treat acid reflux and ulcers." },
    new DrugGenericModel { Id = 10, Name = "Furosemide", Description = "Diuretic used to treat high blood pressure and fluid retention." },
    new DrugGenericModel { Id = 11, Name = "Salbutamol", Description = "Bronchodilator used for asthma and chronic obstructive pulmonary disease (COPD)." },
    new DrugGenericModel { Id = 12, Name = "Warfarin", Description = "Anticoagulant (blood thinner) used to prevent blood clots." },
    new DrugGenericModel { Id = 13, Name = "Losartan", Description = "Angiotensin II receptor blocker (ARB) used for high blood pressure." },
    new DrugGenericModel { Id = 14, Name = "Alprazolam", Description = "Anti-anxiety medication belonging to the benzodiazepine class." },
    new DrugGenericModel { Id = 15, Name = "Fluoxetine", Description = "Selective serotonin reuptake inhibitor (SSRI) used to treat depression and anxiety." },
    new DrugGenericModel { Id = 16, Name = "Clopidogrel", Description = "Antiplatelet medication used to prevent strokes and heart attacks." },
    new DrugGenericModel { Id = 17, Name = "Diazepam", Description = "Benzodiazepine used for anxiety, muscle spasms, and seizures." },
    new DrugGenericModel { Id = 18, Name = "Hydrochlorothiazide", Description = "Diuretic used to treat high blood pressure and fluid retention." },
    new DrugGenericModel { Id = 19, Name = "Prednisolone", Description = "Corticosteroid used for inflammation and autoimmune disorders." },
    new DrugGenericModel { Id = 20, Name = "Codeine", Description = "Opioid used to treat mild to moderate pain and as a cough suppressant." },
    new DrugGenericModel { Id = 21, Name = "Ciprofloxacin", Description = "Antibiotic used to treat bacterial infections." },
    new DrugGenericModel { Id = 22, Name = "Doxycycline", Description = "Antibiotic used to treat bacterial infections, malaria, and acne." },
    new DrugGenericModel { Id = 23, Name = "Tamsulosin", Description = "Used to treat symptoms of benign prostatic hyperplasia (BPH)." },
    new DrugGenericModel { Id = 24, Name = "Zolpidem", Description = "Sedative used to treat insomnia." },
    new DrugGenericModel { Id = 25, Name = "Acetaminophen", Description = "Pain reliever and fever reducer." },
    new DrugGenericModel { Id = 26, Name = "Naproxen", Description = "Nonsteroidal anti-inflammatory drug (NSAID) for pain and inflammation." },
    new DrugGenericModel { Id = 27, Name = "Candesartan", Description = "Angiotensin II receptor blocker (ARB) used for high blood pressure." },
    new DrugGenericModel { Id = 28, Name = "Cimetidine", Description = "H2 blocker used to reduce stomach acid production." },
    new DrugGenericModel { Id = 29, Name = "Sertraline", Description = "Selective serotonin reuptake inhibitor (SSRI) used to treat depression and anxiety." },
    new DrugGenericModel { Id = 30, Name = "Levothyroxine", Description = "Synthetic thyroid hormone used to treat hypothyroidism." }
};
            return drugGenericModels;
        }
    }
}
