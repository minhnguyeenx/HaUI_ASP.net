using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DE01_CoNga.Models;

namespace DE01_CoNga.Controllers
{
    public class ObjectsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Objects
        public ActionResult Xemdanhsach(string searchName, double? minSalary)
        {
            var tblEmployee = db.tblEmployee.Include(t => t.tblDept);
            if (!string.IsNullOrEmpty(searchName))
            {
                tblEmployee = tblEmployee.Where(e => e.name.Contains(searchName));
            }
            if (minSalary.HasValue)
            {
                tblEmployee = tblEmployee.Where(e => e.salary >= minSalary);
            }
            return View(tblEmployee.ToList());
        }

        // GET: Objects/Details/5
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

        // GET: Objects/Create
        public ActionResult ThemDulieu()
        {
            ViewBag.deptid = new SelectList(db.tblDept, "deptid", "deptname");
            return View("ThemDulieu");
        }

        // POST: Objects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemDulieu([Bind(Include = "eid,name,age,addr,salary,image,deptid")] tblEmployee tblEmployee)
        {
            if (ModelState.IsValid)
            {
                //
                tblEmployee.image = "";
                var f = Request.Files["ImageFile"];
                if (f != null && f.ContentLength > 0)
                {
                    string fileName = System.IO.Path.GetFileName(f.FileName);
                    string uploadPath = Server.MapPath("~/Images/" + fileName);
                    f.SaveAs(uploadPath);
                    tblEmployee.image = fileName;
                }
                //
                db.tblEmployee.Add(tblEmployee);
                db.SaveChanges();
                return RedirectToAction("Xemdanhsach");
            }

            ViewBag.deptid = new SelectList(db.tblDept, "deptid", "deptname", tblEmployee.deptid);
            return View(tblEmployee);
        }

        // GET: Objects/Edit/5
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

        // POST: Objects/Edit/5
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

        // GET: Objects/Delete/5
        public ActionResult XoaDulieu(int? id)
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

        // POST: Objects/Delete/5
        [HttpPost, ActionName("XoaDulieu")]
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
