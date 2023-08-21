using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE01_1.Models
{
    public class HangHoa
    {

        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string LoaiHang { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien
        {
            get
            {
                if (SoLuong < 100)
                    return DonGia * SoLuong;
                else return DonGia * SoLuong * 0.9;
            }
        }

        public HangHoa() { }

        public HangHoa(string maHang, string tenHang, string loaiHang, double donGia, int soLuong)
        {
            MaHang = maHang;
            TenHang = tenHang;
            LoaiHang = loaiHang;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is HangHoa hoa &&
        //           MaHang == hoa.MaHang &&
        //           TenHang == hoa.TenHang &&
        //           LoaiHang == hoa.LoaiHang &&
        //           DonGia == hoa.DonGia &&
        //           SoLuong == hoa.SoLuong &&
        //           ThanhTien == hoa.ThanhTien;
        //}
    }
}