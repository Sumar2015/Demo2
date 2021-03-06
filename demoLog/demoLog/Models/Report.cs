﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoLog.Models
{
    public class Report
    {
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