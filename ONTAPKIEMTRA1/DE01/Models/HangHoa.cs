using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE01.Models
{
    public class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string LoaiHang { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string TrangThai { get; set; }
        public double ThanhTien {
            get { 
                if(SoLuong < 100)
                {
                    return SoLuong * DonGia;
                }
                else
                {
                    return SoLuong * DonGia * 0.9;
                }
            } 
        }
        public HangHoa() { }
        public HangHoa(string maHang, string tenHang, string loaiHang, double donGia, int soLuong, string trangThai)
        {
            MaHang = maHang;
            TenHang = tenHang;
            LoaiHang = loaiHang;
            DonGia = donGia;
            SoLuong = soLuong;
            TrangThai = trangThai;
        }
        //public override bool Equals(object obj)
        //{
        //    return obj is HangHoa hoa &&
        //        MaHang == hoa.MaHang &&
        //        TenHang == hoa.TenHang &&
        //        LoaiHang == hoa.LoaiHang &&
        //        DonGia == hoa.DonGia &&
        //        SoLuong == hoa.SoLuong &&
        //        ThanhTien == hoa.ThanhTien;
        //}

        //public override int GetHashCode()
        //{
        //    int hashCode = -379059182;
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaHang);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TenHang);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LoaiHang);
        //    hashCode = hashCode * -1521134295 + DonGia.GetHashCode();
        //    hashCode = hashCode * -1521134295 + SoLuong.GetHashCode();
        //    hashCode = hashCode * -1521134295 + ThanhTien.GetHashCode();
        //    return hashCode;
        //}
    }
}