using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppJobInterview.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int MyProperty { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}