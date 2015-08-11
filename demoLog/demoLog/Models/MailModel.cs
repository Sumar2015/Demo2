using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoLog.Models
{
    public class MailModel
    {
        public int ID { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}