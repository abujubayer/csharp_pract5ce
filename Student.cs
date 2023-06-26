using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course
{
    internal class Student
    {
        public List <Course> EnrolledCourses = new List <Course> ();

        public int Id { get; set; }
        public string Name { get; set; }
        public List <string> EmailCollection = new List<string>();


        public double GetCGPA()
        {
           throw new NotImplementedException();
        }
    }
}
