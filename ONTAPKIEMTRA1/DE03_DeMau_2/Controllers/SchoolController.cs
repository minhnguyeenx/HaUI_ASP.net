using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DE03_DeMau_2.Models;

namespace DE03_DeMau_2.Controllers
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
            List<Student> st = new List<Student>();
            st.Add(new Student("SV01", "Nguyễn Văn A", 20, "Hà Nội"));
            st.Add(new Student("SV02", "Nguyễn Văn B", 20, "Hà Nội"));
            st.Add(new Student("SV03", "Nguyễn Văn C", 20, "Hà Nội"));
            st.Add(new Student("SV04", "Nguyễn Văn D", 20, "Hà Nội"));
            ViewBag.st = st;
            return View();
        }
        public ActionResult Display2ListStudent()
        {
            List<Student> li1 = new List<Student>();
            li1.Add(new Student("SV01", "Nguyễn Văn A", 20, "Hà Nội"));
            li1.Add(new Student("SV02", "Nguyễn Văn A", 20, "Hà Nội"));
            li1.Add(new Student("SV03", "Nguyễn Văn A", 20, "Hà Nội"));
            li1.Add(new Student("SV04", "Nguyễn Văn A", 20, "Hà Nội"));
            List<Student> li2 = new List<Student>();
            li2.Add(new Student("SV01", "Nguyễn Văn A", 20, "Hà Nội"));
            li2.Add(new Student("SV02", "Nguyễn Văn A", 20, "Hà Nội"));
            li2.Add(new Student("SV03", "Nguyễn Văn A", 20, "Hà Nội"));
            li2.Add(new Student("SV04", "Nguyễn Văn A", 20, "Hà Nội"));
            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View();
        }
        public ActionResult DisplayCourseStudent()
        {
            CourseStudent ct = new CourseStudent();
            ct.course.CID = "C01";
            ct.course.CName = "Khoa hoc 1";
            ct.students = new List<Student>();
            ct.students.Add(new Student("SV01", "Nguyễn Văn A", 20, "Hà Nội"));
            ct.students.Add(new Student("SV02", "Nguyễn Văn A", 20, "Hà Nội"));
            ct.students.Add(new Student("SV03", "Nguyễn Văn A", 20, "Hà Nội"));
            ct.students.Add(new Student("SV04", "Nguyễn Văn A", 20, "Hà Nội"));
            return View(ct);
        }
    }
}