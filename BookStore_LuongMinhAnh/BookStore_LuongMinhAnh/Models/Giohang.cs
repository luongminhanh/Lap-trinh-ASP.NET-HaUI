using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_LuongMinhAnh.Models
{
    public class Giohang
    {
        QLBanSachDB db = new QLBanSachDB();
        public int iMasach { get; set; }
        public string sTensach { get; set; }
        public string sAnhbia { get; set; }
        public Double dDongia { get; set; } 
        public int iSoluong {  get; set; }
        public Double dThanhtien
        {
            get
            {
                return iSoluong * dDongia;
            }
        }
        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = db.SACHes.Single(x => x.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Anhbia;
            dDongia = double.Parse(sach.Giaban.ToString());
            iSoluong = 1;
        }
    }
}