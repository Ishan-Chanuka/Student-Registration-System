using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Data;
using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AuthDBContext _db;

        public CoursesController(AuthDBContext db)
        {
            _db = db;
        }

        public IActionResult Create(Courses obj)
        {
            if (ModelState.IsValid)
            {
                _db.Courses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(obj);
        }

        public IActionResult Courses()
        {
            IEnumerable<Courses> _courList = _db.Courses;
            return View(_courList);
        }
    }
}
