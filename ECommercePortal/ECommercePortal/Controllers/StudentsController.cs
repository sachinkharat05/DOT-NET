using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePortal.Controllers
{
    public class StudentsController : Controller
    {
        // simple in-memory store for demonstration
        private static  List<Student> _students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Sachin", LastName = "kharat", Email = "sachin@gmail.com" },
            new Student { Id = 2, FirstName = "Karan", LastName = "Rajput", Email = "karan@gmail.com" }
        };

        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Details(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid) return View(student);

            var nextId = _students.Any() ? _students.Max(s => s.Id) + 1 : 1;
            student.Id = nextId;
            _students.Add(student);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            _students.Remove(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Aboutus()
        {
            string content = "Learning and growing together is the path to success.";
            ViewData["Message"] = content;
            return View();
        }

        public IActionResult ContactUs()
        {
            Address address = new Address
            {
                Street = "101, Student Plaza",
                City = "Pune",
                State = "MH",
                ZipCode = "411001"
            };
            ViewData["Address"] = address;

            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
