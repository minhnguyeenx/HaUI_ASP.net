using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE03_DeMau.Models
{
    public class Course
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public Course() { }

        public Course(string maKH, string tenKH)
        {
            MaKH = maKH;
            TenKH = tenKH;
        }
    }
}