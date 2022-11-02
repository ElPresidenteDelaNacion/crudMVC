using crudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crudMVC.DAL
{
    public class SchoolInitializaer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Alumno>
            {
            new Alumno{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Alumno{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Alumno{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Alumno{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Alumno{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Alumno{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Alumno{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Alumno{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Alumnos.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{AlumnoID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{AlumnoID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{AlumnoID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{AlumnoID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{AlumnoID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{AlumnoID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{AlumnoID=3,CourseID=1050},
            new Enrollment{AlumnoID=4,CourseID=1050,},
            new Enrollment{AlumnoID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{AlumnoID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{AlumnoID=6,CourseID=1045},
            new Enrollment{AlumnoID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }

    }
}