using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE03_DeMau_2.Models
{
    public class Student
    {
        public string SID { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Student() { }

        public Student(string sID, string sName, int age, string address)
        {
            SID = sID;
            SName = sName;
            Age = age;
            Address = address;
        }
    }
}