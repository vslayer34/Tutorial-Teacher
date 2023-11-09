using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {

        [HttpGet("names")]
        public IEnumerable<string> Get(int id, string name) => new string[] { id.ToString(), name };

        [HttpPost("names/student")]
        public string Post(Student student) => $"The student name is {student.Name} and his/her id is {student.Id}";

        [HttpPost("names/relative-to-rana")]
        public string Post(Student student, string name) => $"The student name is {student.Name} and his/her id is {student.Id} after {name}";

        // return primitive or complex return types
        
        [HttpGet("name")]
        public int GetId(string name)
        {
            return Student.GetStudentId();
        }

        [HttpGet("ID")]
        public Student GetStudent(int id)
        {
            return new Student() { Id = 78, Name = "Rana" };
        }

        // HttpResonseMessage

        
    }


    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public static int GetStudentId()
        {
            return 78;
        }

        public static string GetStudentName()
        {
            return "Rana";
        }
    }
}