using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoLog.App_Data;
using demoLog.Models;

namespace demoLog.Repository
{
    public class AdminRepo
    {
        Database1 m_db = new Database1();

        public IEnumerable<Admin> GetAllReports()
        {
            var result = (from n in m_db.Admins
                          orderby n.Date descending
                          select n).ToList();
            return result;
        }

        public Admin GetReportById(int? id)
        {
            var result = (from n in m_db.Admins
                          where n.Id == id
                          select n).SingleOrDefault();
            return result;
        }

        public void AddReport(Admin n)
        {
            m_db.Admins.Add(n);
            m_db.SaveChanges();
        }
    }
}