using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsurenceSystem.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PaymentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PaymentPage()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Customer obj)
        {
            IEnumerable<Customer> x1 = _db.Customer.Where(a => a.Cemail == obj.Cemail && a.Pnumber == obj.Pnumber);
            if (ModelState.IsValid)
            {
                if (x1.Count() > 0)
                {
                    TempData["data"] = _db.Customer.First().Amount;
                    return RedirectToAction("PaymentPage");
                }
                else
                {
                    return RedirectToAction("Notok");
                }
            }
            return RedirectToAction("Notok");
        }
    }
}
