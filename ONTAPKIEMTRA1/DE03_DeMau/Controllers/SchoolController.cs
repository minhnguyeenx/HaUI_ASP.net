using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DE03_DeMau.Models;

namespace DE03_DeMau.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TinhToan()
        {
            return View();
        }
        public ActionResult DisplayAStudent(Student st)
        {
            return View(st);
        }
        public ActionResult DisplayListStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("SV1", "Nguyen Van A", 20, "Ha Noi"));
            students.Add(new Student("SV2", "Nguyen Van B", 21, "Ha Noi"));
            students.Add(new Student("SV3", "Nguyen Van C", 22, "Hai Phong"));
            students.Add(new Student("SV4", "Nguyen Van C", 20, "Ha Noi"));
            return View(students);
        }
        public ActionResult Display2ListStudent()
        {
            List<Student> li1 = new List<Student>();
            li1.Add(new Student("SV1", "Nguyen Van A", 20, "Ha Noi"));
            li1.Add(new Student("SV2", "Nguyen Van B", 21, "Ha Noi"));
            li1.Add(new Student("SV3", "Nguyen Van C", 22, "Hai Phong"));
            li1.Add(new Student("SV4", "Nguyen Van C", 20, "Ha Noi"));

            List<Student> li2 = new List<Student>();
            li2.Add(new Student("SV1", "Nguyen Van A", 20, "Ha Noi"));
            li2.Add(new Student("SV2", "Nguyen Van B", 21, "Ha Noi"));
            li2.Add(new Student("SV3", "Nguyen Van C", 22, "Hai Phong"));
            li2.Add(new Student("SV4", "Nguyen Van C", 20, "Ha Noi"));

            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View();
        }
        public ActionResult DisplayCourseStudent()
        {
            CourseStudent courseStudent = new CourseStudent();
            courseStudent.course.MaKH = "KH01";
            courseStudent.course.TenKH = "Khoa hoc 1";
            courseStudent.students = new List<Student>();
            courseStudent.students.Add(new Student("SV1", "Nguyen Van A", 20, "Ha Noi"));
            courseStudent.students.Add(new Student("SV2", "Nguyen Van B", 21, "Ha Noi"));
            courseStudent.students.Add(new Student("SV3", "Nguyen Van C", 22, "Ha Noi"));
            courseStudent.students.Add(new Student("SV4", "Nguyen Van D", 20, "Ha Noi"));
            return View(courseStudent);
        }
    }
}