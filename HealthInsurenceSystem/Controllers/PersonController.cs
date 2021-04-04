using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsurenceSystem.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PersonController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult ok()
        {
            return View();
        }
        public IActionResult Notok()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult login(Person obj)
        {
            IEnumerable<Person> objList = _db.Person;
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("ok");
            }
            return RedirectToAction("Notok");
        }
        public IActionResult signup()
        {
            return View();
        }
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult signup(Person obj)
        {
            if (ModelState.IsValid)
            {
                _db.Person.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("login");
            }
            return View(obj);
        }
    }
}
