using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crudMVC.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int AlumnoID { get; set; }
        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        public Alumno Alumno { get; set; }
    }
}