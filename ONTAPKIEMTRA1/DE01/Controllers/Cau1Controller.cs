using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DE01.Models; //NHỚ PHẢI CÓ CÁI NÀY

namespace DE01.Controllers
{
    public class Cau1Controller : Controller
    {
        // GET: Cau1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Output(HangHoa hanghoa)
        //{
        //    return View("Output", hanghoa);
        //}

        public ActionResult Output(HangHoa hanghoa)
        {
            return View("Output", hanghoa);
        }
        public ActionResult Output()
        {
            var hangHoa = new HangHoa();
            hangHoa.MaHang = Convert.ToString(Request["maHang"]);
            hangHoa.TenHang = Convert.ToString(Request["tenHang"]);
            hangHoa.LoaiHang = Convert.ToString(Request["loaiHang"]);
            hangHoa.SoLuong = Convert.ToInt32(Request["soLuong"]);
            hangHoa.DonGia = Convert.ToDouble(Request["donGia"]);
            hangHoa.TrangThai = Convert.ToString(Request["trangThai"]);
            return View(hangHoa);
        }
    }
}