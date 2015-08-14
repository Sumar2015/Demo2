using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace demoLog.App_Data
{
    public class Database1 : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Database1() : base("name=Database1")
        {
        }

        public System.Data.Entity.DbSet<demoLog.Models.Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<demoLog.Models.AdminViewModel> AdminViewModels { get; set; }
    
    }
}
