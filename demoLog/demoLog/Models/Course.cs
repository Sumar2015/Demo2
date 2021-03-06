﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace demoLog.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string Students { get; set; }
        public string Instructor { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}