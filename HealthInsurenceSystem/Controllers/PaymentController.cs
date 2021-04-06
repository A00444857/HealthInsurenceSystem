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
                    TempData["Epay"]= _db.Customer.First().Cemail;
                    return RedirectToAction("PaymentPage");
                }
                else
                {
                    return RedirectToAction("Notok");
                }
            }
            return RedirectToAction("Notok");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult check(Payment obj)
        {
            DateTime now = DateTime.Today;
            IEnumerable<Payment> x1 = _db.Payment.Where(a => a.Cardnumber == obj.Cardnumber && a.ExpiredDate==obj.ExpiredDate && a.Cvv == obj.Cvv);
            if (ModelState.IsValid)
            {
                if (x1.Count() > 0)
                {
                    var x=TempData["data"];
                    var lpay = _db.Customer.First(a => a.Cemail == TempData["Epay"].ToString());
                    lpay.Lastpayment = now;
                    _db.SaveChanges();
                    return View("ok");
                }
                    
            }
            return View("Notok");
        }
    }
}
