using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoLog.Models
{
    public class Report
    {
        public int ID { get; set; }

        public DateTime dateCreated { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Title required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Title required")]
        public string description { get; set; }
    }
}