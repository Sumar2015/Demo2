using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demoLog.Models;

namespace demoLog.Models
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            EnrollmentDate = DateTime.Now;
            Courses = new List<SelectListItem>();
            Courses.Add(new SelectListItem { Text = "-Select-", Value = "", Selected = true });
            Courses.Add(new SelectListItem { Text = "Operating systems", Value = "Operating systems" });
            Courses.Add(new SelectListItem { Text = "Programming languages", Value = "Programming languages" });
            Courses.Add(new SelectListItem { Text = "Networks", Value = "Networks" });
            Courses.Add(new SelectListItem { Text = "C++ programming", Value = "C++ programming" });
            Courses.Add(new SelectListItem { Text = "Data structures and functional programming", Value = "Data structures and functional programming" });
            Courses.Add(new SelectListItem { Text = "Practicum in Artificial Intelligence", Value = "Practicum in Artificial Intelligence" });
            Courses.Add(new SelectListItem { Text = "Introduction to Theory of Computing", Value = "Introduction to Theory of Computing" });
        }
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public List<SelectListItem> Courses { get; set; }
        public string Course { get; set; }
    }
}