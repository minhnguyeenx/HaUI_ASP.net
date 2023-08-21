using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DE02.Models;

namespace DE02.Controllers
{
    public class Cau6Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: Cau6
        public ActionResult Index()
        {
            return View(db.SanPham.ToList());
        }

        // GET: Cau6/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cau6/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Masp,Tensp,Donvitinh,Soluong")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                int cnt = db.SanPham.Count(m => sanPham.Masp == m.Masp);
                if (cnt > 0)
                {
                    ViewBag.Message = "Mã sản phẩm không được trùng";
                    return View(sanPham);
                }
                db.SanPham.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sanPham);
        }

    }
}
