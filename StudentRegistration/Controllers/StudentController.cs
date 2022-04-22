using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Data;
using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Controllers
{
    public class StudentController : Controller
    {
        private readonly AuthDBContext _db;

        public StudentController(AuthDBContext db)
        {
            _db = db;
        }

        public IActionResult Create()
        {
            return View();
        }

        // Get student data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Stidents.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Create");
            }

            return View(obj);
        }

        // Display Student Data
        public IActionResult StudentDetails()
        {
            IEnumerable<Student> _stdList = _db.Stidents;
            return View(_stdList);
        }
    }
}
