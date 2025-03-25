using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public ICollection<StudentCourse> EnrolledCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new List<Homework>();
    }
}
