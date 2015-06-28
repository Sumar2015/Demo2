using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoLog.DAL;
using demoLog.Models;

namespace demoLog.Repository
{
    public class StudentRepo
    {
        SchoolContext m_db = new SchoolContext();
        public IEnumerable<Student> GetAllStudents()
        {
            var result = (from n in m_db.Students
                          orderby n.EnrollmentDate descending
                          select n).Take(10);
            return result;
        }
        public Student GetStudentById(int? id)
        {
            var result = (from n in m_db.Students
                          where n.ID == id
                          select n).SingleOrDefault();
            return result;
        }

        public void AddStudent(Student n)
        {
            m_db.Students.Add(n);
            m_db.SaveChanges();
        }

        public void UpdateStudent(Student n)
        {
            Student p = GetStudentById(n.ID);
            if (p != null)
            {
                p.LastName = n.LastName;
                p.FirstMidName = n.FirstMidName;
                p.Course = n.Course;
                p.EnrollmentDate = n.EnrollmentDate;
                m_db.SaveChanges();
            }
        }

        public void DeleteStudent(Student n)
        {
            m_db.Students.Remove(n);
            m_db.SaveChanges();
        }
    }
}