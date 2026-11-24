
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        // Temporary in-memory data
        private static List<Student> students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Sachin",
                Email = "sachin@gmail.com",
                Age = 22
            },

            new Student
            {
                Id = 2,
                Name = "Rahul",
                Email = "rahul@gmail.com",
                Age = 23
            }
        };

        // 1. GET - Get All Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        // 2. GET - Get Student By ID
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            return Ok(student);
        }

        // 3. POST - Add New Student
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            student.Id = students.Count == 0
                ? 1
                : students.Max(s => s.Id) + 1;

            students.Add(student);

            return Ok(student);
        }

        // 4. PUT - Update Student
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            student.Name = updatedStudent.Name;
            student.Email = updatedStudent.Email;
            student.Age = updatedStudent.Age;

            return Ok(student);
        }

        // 5. DELETE - Delete Student
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            students.Remove(student);

            return Ok("Student Deleted Successfully");
        }
    }
}