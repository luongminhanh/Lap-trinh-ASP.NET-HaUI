using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De02.Models
{
    public class SanPham
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string loaisp { get; set; }
        public int soluong { get; set; }
        public double dongia { get; set; }
        public double thanhtien { 
            get {
                if (soluong >= 200) return soluong * dongia * 0.9;
                else return soluong * dongia;
            } 
        }
    }
}