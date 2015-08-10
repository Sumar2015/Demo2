using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoLog.Models
{
    public class ReportViewModel
    {
        public ReportViewModel()
        {
            DateCreated = DateTime.Now;
        }

        public int ID { get; set; }

        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Title required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Title required")]
        public string Description { get; set; }
    }
}