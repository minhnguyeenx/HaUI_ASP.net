using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TH8_LamLai.Models;

namespace TH8_LamLai.Controllers
{
    public class tblEmployeesController : Controller
    {
        private Model1 db = new Model1();

        // GET: tblEmployees
        public ActionResult Index(decimal? minSalary, string searchName)
        {
            var tblEmployee = db.tblEmployee.Include(t => t.tblDept);
            if (minSalary.HasValue)
            {
                tblEmployee = tblEmployee.Where(e => e.salary >= minSalary.Value);
            }
            if (!string.IsNullOrEmpty(searchName))
            {
                tblEmployee = tblEmployee.Where(e => e.name.Contains(searchName));
            }
            return View(tblEmployee.ToList());
        }

        public ActionResult Index2(string searchName)
        {
            var tblEmployee = db.tblEmployee.Include(t => t.tblDept);
            if (!string.IsNullOrEmpty(searchName))
            {
                tblEmployee = tblEmployee.Where(e => e.name.Contains(searchName));
            }
            return View("Index2",tblEmployee.ToList());
        }

        // GET: tblEmployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblEmployee = db.tblEmployee.Find(id);
            if (tblEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tblEmployee);
        }

        // GET: tblEmployees/Create
        public ActionResult Create()
        {
            ViewBag.deptid = new SelectList(db.tblDept, "deptid", "deptname");
            return View();
        }

        // POST: tblEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "eid,name,age,addr,salary,image,deptid")] tblEmployee tblEmployee)
        {
            if (ModelState.IsValid)
            {
                tblEmployee.image = "";
                var f = Request.Files["ImageFile"];
                if (f != null && f.ContentLength > 0)
                {
                    string fileName = System.IO.Path.GetFileName(f.FileName);
                    //Response.Write(fileName);
                    string uploadPath = Server.MapPath("~/Images/" + fileName);
                    f.SaveAs(uploadPath);
                    tblEmployee.image = fileName;
                }
                db.tblEmployee.Add(tblEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.deptid = new SelectList(db.tblDept, "deptid", "deptname", tblEmployee.deptid);
            return View(tblEmployee);
        }

        // GET: tblEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblEmployee = db.tblEmployee.Find(id);
            if (tblEmployee == null)
            {
                return HttpNotFound();
            }
            ViewBag.deptid = new SelectList(db.tblDept, "deptid", "deptname", tblEmployee.deptid);
            return View(tblEmployee);
        }

        // POST: tblEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "eid,name,age,addr,salary,image,deptid")] tblEmployee tblEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.deptid = new SelectList(db.tblDept, "deptid", "deptname", tblEmployee.deptid);
            return View(tblEmployee);
        }

        // GET: tblEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblEmployee = db.tblEmployee.Find(id);
            if (tblEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tblEmployee);
        }

        // POST: tblEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblEmployee tblEmployee = db.tblEmployee.Find(id);
            db.tblEmployee.Remove(tblEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
