using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppJobInterview.Models;

namespace WebAppJobInterview.DAL
{
    public class SchoolContext : DbContext
    {

       public IDbSet<Student> Students {get; set;}
        public IDbSet<Course> Courses{ get; set; }

        public SchoolContext() :base("deafult")
        {
          //  Database.SetInitializer<SchoolContext>(new DatabaseInitializer());
        }
    }



    public class DatabaseInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {



            var c1 = new Course() { CourseId = 1, CourseName = "mather" };
            var c2 = new Course() { CourseId = 2, CourseName = "alg" };
            var c3 = new Course() { CourseId = 3, CourseName = "hist" };


            var studentList = new List<Student> {

               new Student () {  StudentId = 1, StudentName ="Eyal", Courses= new List<Course> {
                  c1,c2,c3
               } }
           };

            studentList.ForEach(s => context.Students.Add(s));

            context.Courses.Add(c1);
            context.Courses.Add(c2);
            context.Courses.Add(c3);



            context.SaveChanges();


        }
    }
}