using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoLog.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }

        public string Description { get; set; }

        public string Array { get; set; }

        public DateTime Date { get; set; }
    }
}