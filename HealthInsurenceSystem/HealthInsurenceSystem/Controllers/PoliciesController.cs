﻿using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace HealthInsurenceSystem.Controllers
{
    public class PoliciesController : Controller
    {

        private readonly ApplicationDbContext _db;

        public PoliciesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Policy> objList = _db.Policy;
            return View(objList);
        }
    }
}