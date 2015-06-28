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
            Instructor = new List<SelectListItem>();
            Instructor.Add(new SelectListItem { Text = "-Select-", Value = "", Selected = true });
            Instructor.Add(new SelectListItem { Text = "Daníel Brandur Sigurgeirsson", Value = "Daníel Brandur Sigurgeirsson" });
            Instructor.Add(new SelectListItem { Text = "Hallgrímur Arnalds", Value = "Hallgrímur Arnalds" });
            Instructor.Add(new SelectListItem { Text = "Hjalti Magnússon", Value = "Hjalti Magnússon" });
            Instructor.Add(new SelectListItem { Text = "Freysteinn Alfreðsson", Value = "Freysteinn Alfreðsson" });
            Instructor.Add(new SelectListItem { Text = "Halldóra Jóhannsdóttir", Value = "Halldóra Jóhannsdóttir" });
            Instructor.Add(new SelectListItem { Text = "-No instructor-", Value = "-No instructor-" });

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
        public List<SelectListItem> Instructor { get; set; }
        public string Course { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}