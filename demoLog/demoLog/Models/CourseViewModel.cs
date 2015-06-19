using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoLog.Models
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            DateCreated = DateTime.Now;
            Courses = new List<SelectListItem>();
            Courses.Add(new SelectListItem { Text = "-Select-", Value = "", Selected = true });
            Courses.Add(new SelectListItem { Text = "Operating systems", Value = "Operating systems" });
            Courses.Add(new SelectListItem { Text = "Programming languages", Value = "Programming languages" });
            Courses.Add(new SelectListItem { Text = "Networks", Value = "Networks" });
            Courses.Add(new SelectListItem { Text = "C++ programming", Value = "C++ programming" });
            Courses.Add(new SelectListItem { Text = "Data structures and functional programming", Value = "Data structures and functional programming" });
            Courses.Add(new SelectListItem { Text = "Practicum in Artificial Intelligence", Value = "Practicum in Artificial Intelligence" });
            Courses.Add(new SelectListItem { Text = "Introduction to Theory of Computing", Value = "Introduction to Theory of Computing" });

            Credit = new List<SelectListItem>();
            Credit.Add(new SelectListItem { Text = "-Select-", Value = "", Selected = true });
            Credit.Add(new SelectListItem { Text = "-1-", Value = "1" });
            Credit.Add(new SelectListItem { Text = "-2-", Value = "2" });
            Credit.Add(new SelectListItem { Text = "-3-", Value = "3" });
            Credit.Add(new SelectListItem { Text = "-4-", Value = "4" });
            Credit.Add(new SelectListItem { Text = "-5-", Value = "5" });
            Credit.Add(new SelectListItem { Text = "-6-", Value = "6" });

        }
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public List<SelectListItem> Credit { get; set; }
        public DateTime DateCreated { get; set; }
        public List<SelectListItem> Courses { get; set; }
        public string Course { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}