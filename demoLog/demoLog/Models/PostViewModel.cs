using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoLog.Models
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            DateCreated = DateTime.Now;
            Categories = new List<SelectListItem>();
            Categories.Add(new SelectListItem { Text = "-Select-", Value = "", Selected = true });
            Categories.Add(new SelectListItem { Text = "Operating systems", Value = "Operating systems" });
            Categories.Add(new SelectListItem { Text = "Programming languages", Value = "Programming languages" });
            Categories.Add(new SelectListItem { Text = "Networks", Value = "Networks" });
            Categories.Add(new SelectListItem { Text = "C++ programming", Value = "C++ programming" });
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Text required")]
        public string Text { get; set; }

        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "You have to choose a category")]
        public string Category { get; set; }

        public List<SelectListItem> Categories { get; set; }
    }
}