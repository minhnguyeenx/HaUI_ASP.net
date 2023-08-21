using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TH15_Employee.Models;

namespace TH15_Employee.Controllers
{
    public class LoginController : Controller
    {
        private Model1 db = new Model1();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Accout.Where(u => u.username == username && u.password == password).FirstOrDefault();
            if (user == null)
            {
                ViewBag.errMsg = "Sai ten dang nhap hoac mat khau";
                return View("Login");
            }
            else
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }
        // GET: Login
        public ActionResult Index()
        {
            return View(db.Accout.ToList());
        }

        // GET: Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accout accout = db.Accout.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,username,password,role")] Accout accout)
        {
            if (ModelState.IsValid)
            {
                db.Accout.Add(accout);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accout);
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accout accout = db.Accout.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,username,password,role")] Accout accout)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accout).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accout);
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accout accout = db.Accout.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accout accout = db.Accout.Find(id);
            db.Accout.Remove(accout);
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
