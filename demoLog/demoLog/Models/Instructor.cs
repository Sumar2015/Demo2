using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoLog.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}