using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE03_DeMau.Models
{
    public class Student
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public Student() { }

        public Student(string maSV, string tenSV, int tuoi, string diaChi)
        {
            MaSV = maSV;
            TenSV = tenSV;
            Tuoi = tuoi;
            DiaChi = diaChi;
        }
    }
}