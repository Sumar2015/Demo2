﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using demoLog.Models;

namespace demoLog.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var instructors = new List<Instructor>
            {
                new Instructor{FirstMidName="Daníel Brandur",LastName="Sigurgeirsson",Course="Networks",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Instructor{FirstMidName="Freysteinn",LastName="Alfreðsson",Course="Operating system",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Instructor{FirstMidName="Hjalti",LastName="Magnússon",Course="Data structures and functional programming",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Instructor{FirstMidName="Hallgrímur",LastName="Arnalds",Course="C++ programming",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Instructor{FirstMidName="Halldóra",LastName="Jóhannsdóttir",Course="Introduction to Theory of Computing",EnrollmentDate=DateTime.Parse("2005-09-01")},
            };
            instructors.ForEach(s => context.Instructor.Add(s));
            context.SaveChanges();

            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",Course="C++ programming",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",Course="C++ programming",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",Course="C++ programming",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",Course="Networks",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",Course="Networks",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",Course="Networks",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",Course="Operating systems",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",Course="Operating systems",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
             new Course{CourseID=1050,Title="C++ programming",Credits=3,Students="Carson Alexander, Meredith Alonso, Arturo Anand",Instructor="Hallgrimur Arnalds"},
             new Course{CourseID=4022,Title="Networks",Credits=3,Students="Gytis Barzadukas, Yan Li, Peggy Justice",Instructor="Daníel Brandur Sigurgeirsson"},
             new Course{CourseID=4041,Title="Data structures and functional programming",Credits=3,Instructor="Hjalti Magnússon"},
             new Course{CourseID=1045,Title="Operating systems",Credits=4,Students="Laura Norman, Nino Olivetto",Instructor="Freysteinn Alfreðsson"},
             new Course{CourseID=3141,Title="Programming languages",Credits=4,Instructor="No instructor"},
             new Course{CourseID=2021,Title="Practicum in Artificial Intelligence",Credits=3,Instructor="No instructor"},
             new Course{CourseID=2042,Title="Introduction to Theory of Computing",Credits=4,Instructor="Halldóra Jóhannsdóttir"}       
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var posts = new List<PostItem>
            {
                new PostItem
                {
                    Category="Network",
                    Title="Message from instructor.",
                    DateCreated=DateTime.Parse("2014-08-25"),
                    Text="New course getting started, hopefully everybody got their paper and pencil ready!!"
                },

                new PostItem
                {
                    Category="C++ programming",
                    Title="Message from instructor.",
                    DateCreated=DateTime.Parse("2014-08-25"),
                    Text="Stundents must have finished homework1 before next friday."
                },

                new PostItem
                {
                    Category="Operating systems",
                    Title="Message to students",
                    DateCreated=DateTime.Parse("2014-08-25"),
                    Text="Let the party begin!!"
                },
            };
            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();
        }
    }
}