using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppJobInterview.DAL;
using System.Data.Entity;

namespace WebAppJobInterview.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public JsonResult GetStudents()
        {
            using (SchoolContext ctx = new SchoolContext())
            {
                var students = ctx.Students.Include("Courses").ToList();

                return Json(new
                {
                    Students = students

                }, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult Index()
        {

            return View();
        }

        // GET: Student/Details/5
    }
}
