using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//PHAI CO CAI NAY
using DE02.Models;

namespace DE02.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public List<SanPham> sanPhams;
        public SanPhamController()
        {
            sanPhams = new List<SanPham>();
            sanPhams.Add(new SanPham("SP01", "RealMe", 100, 200));
            sanPhams.Add(new SanPham("SP02", "Nokia", 70, 150));
            sanPhams.Add(new SanPham("SP03", "Oppo", 50, 160));
        }
        public ActionResult Index()
        {
            return View(sanPhams);
        }
        public ActionResult HaiDanhSach()
        {
            return View(sanPhams);
        }
    }
}