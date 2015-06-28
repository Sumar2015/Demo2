using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoLog.DAL;
using demoLog.Models;

namespace demoLog.Repository
{
    public class InstructorRepo
    {
        SchoolContext m_db = new SchoolContext();
        public IEnumerable<Instructor> GetAllInstructors()
        {
            var result = (from n in m_db.Instructor
                          orderby n.EnrollmentDate descending
                          select n).Take(10);
            return result;
        }
        public Instructor GetInstructorById(int? id)
        {
            var result = (from n in m_db.Instructor
                          where n.ID == id
                          select n).SingleOrDefault();
            return result;
        }

        public void AddInstructor(Instructor n)
        {
            m_db.Instructor.Add(n);
            m_db.SaveChanges();
        }

        public void UpdateInstructor(Instructor n)
        {
            Instructor p = GetInstructorById(n.ID);
            if (p != null)
            {
                p.LastName = n.LastName;
                p.FirstMidName = n.FirstMidName;
                p.Course = n.Course;
                m_db.SaveChanges();
            }
        }

        public void DeleteInstructor(Instructor n)
        {
            m_db.Instructor.Remove(n);
            m_db.SaveChanges();
        }
    }
}