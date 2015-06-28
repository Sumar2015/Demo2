using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoLog.DAL;
using demoLog.Models;
namespace demoLog.Repository
{
    public class CourseRepo
    {
        SchoolContext m_db = new SchoolContext();
        public IEnumerable<Course> GetAllCourses()
        {
            var result = (from n in m_db.Courses
                          orderby n.Title ascending
                          select n).Take(10);
            return result;
        }
        public Course GetCourseById(int? id)
        {
            var result = (from n in m_db.Courses
                          where n.CourseID == id
                          select n).SingleOrDefault();
            return result;
        }

        public void AddCourse(Course n)
        {
            m_db.Courses.Add(n);
            m_db.SaveChanges();
        }

        public void UpdateCourse(Course n)
        {
            Course p = GetCourseById(n.CourseID);
            if (p != null)
            {
                p.Title = n.Title;
                p.Credits = n.Credits;
                p.Instructor = n.Instructor;
                m_db.SaveChanges();
            }
        }

        public void DeleteCourse(Course n)
        {
            m_db.Courses.Remove(n);
            m_db.SaveChanges();
        }
    }
}