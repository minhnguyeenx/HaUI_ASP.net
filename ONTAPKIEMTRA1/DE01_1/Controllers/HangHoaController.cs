using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DE01_1.Models;

namespace DE01_1.Controllers
{
    public class HangHoaController : Controller
    {
        // GET: HangHoa
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Output(HangHoa hh)
        {
            return View("Output", hh);
        }

        //public ActionResult Output()
        //{
        //    HangHoa hh = new HangHoa();
        //    hh.MaHang = Convert.ToString(Request["maHang"]);
        //    hh.TenHang = Convert.ToString(Request["tenHang"]);
        //    hh.LoaiHang = Convert.ToString(Request["loaiHang"]);
        //    hh.DonGia = Convert.ToDouble(Request["donGia"]);
        //    hh.SoLuong = Convert.ToInt32(Request["soLuong"]);
        //    hh.ThanhTien = Convert.ToDouble(Request["thanhTien"]);
        //    return View("Output", hh);
        //}
    }
}