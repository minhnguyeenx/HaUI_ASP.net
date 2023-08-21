using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using De01_img.Models;

namespace De01_img.Controllers
{
    public class ObjectsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Objects
        public ActionResult Xemdanhsach()
        {
            return View(db.Product.ToList());
        }

        // GET: Objects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Objects/Create
        public ActionResult ThemDulieu()
        {
            ViewBag.Categorylist = new SelectList(db.Category, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Objects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemDulieu([Bind(Include = "Pid,Categoryid,ProdName,MetaTitle,Description,ImagePath,Price")] Product product)
        {
            //if (ModelState.IsValid)
            //{
            //    //int cnt = db.Product.Count(m => product.Pid = m.Pid);

            //    db.Product.Add(product);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //return View(product);

            if (ModelState.IsValid)
            {
                if (TryUpdateModel(product))
                {
                    db.Product.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Categorylist = new SelectList(db.Category, "CategoryId", "CategoryName");
            return View(product);

        }

        // GET: Objects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Objects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pid,Categoryid,ProdName,MetaTitle,Description,ImagePath,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Objects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Objects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
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
