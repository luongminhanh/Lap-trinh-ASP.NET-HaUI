using BookStore_LuongMinhAnh.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace BookStore_LuongMinhAnh.Controllers
{
    public class GiohangController : Controller
    {
        QLBanSachDB db = new QLBanSachDB();
        public List<Giohang> Laygiohang()
        {
            List<Giohang> ltgiohang = Session["Giohang"] as List<Giohang>;
            if (ltgiohang == null)
            {
                ltgiohang = new List<Giohang>();
                Session["Giohang"] = ltgiohang;
            }
            return ltgiohang;
        }
        // GET: Giohang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Themgiohang(int iMasach, string strURL)
        {
            List<Giohang> ltgiohang = Laygiohang();
            Giohang sp = ltgiohang.Find(n => n.iMasach == iMasach);
            if (sp == null)
            {
                sp = new Giohang(iMasach);
                ltgiohang.Add(sp);
                return Redirect(strURL);    
            }
            else
            {
                sp.iSoluong++;
                return Redirect(strURL);    
            }
        }
        public ActionResult XoaGiohang(int masp)
        {
            List<Giohang> ltgiohang = Laygiohang();
            Giohang sp = ltgiohang.SingleOrDefault(n => n.iMasach == masp);
            if (sp != null)
            {
                ltgiohang.RemoveAll(n => n.iMasach == masp);
                return RedirectToAction("Giohang");
            }
            if (ltgiohang.Count == 0)
            {
                return RedirectToAction("Index", "BookStore");
            }
            return RedirectToAction("Giohang");
        }
        public ActionResult XoatatcaGiohang()
        {
            List<Giohang> ltgiohang = Laygiohang();
            ltgiohang.Clear();
            return RedirectToAction("Index", "BookStore");
        }
        public ActionResult CapnhatGiohang(int masp, FormCollection f)
        {
            List<Giohang> ltgiohang = Laygiohang();
            Giohang sp = ltgiohang.SingleOrDefault(n => n.iMasach == masp);
            if (sp != null)
            {
                sp.iSoluong = int.Parse(f["txtSoluong"].ToString());
            }
            return RedirectToAction("Giohang");
        }
        [HttpGet]
        public ActionResult Dathang()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "Nguoidung");
            }
            if (Session["Giohang"]== null)
            {
                return RedirectToAction("Index", "BookStore");
            }
            List<Giohang> ltgiohang = Laygiohang();
            ViewBag.Tongsoluong = tongsl();
            ViewBag.Tongtien = tongtien();
            return View(ltgiohang);
        }
        public ActionResult DatHang(FormCollection collection)
        {
            //Thêm đơn hàng
            DONDATHANG ddh = new DONDATHANG();
            KHACHHANG kh = (KHACHHANG)Session["Taikhoan"];
            List<Giohang> gh = Laygiohang();
            ddh.MaKH = kh.MaKH;
            ddh.Ngaydat = DateTime.Now;
            var Ngaygiao = String.Format("{0:MM/dd/yyyy}", collection["Ngaygiao"]);
            ddh.Ngaygiao = DateTime.Parse(Ngaygiao);
            ddh.Tinhtranggiaohang = false;
            ddh.Dathanhtoan = false;
            db.DONDATHANGs.Add(ddh);
            db.SaveChanges();
            //Thêm chỉ tiết đơn hàng
            foreach (var item in gh)
            {
                CHITIETDONTHANG ctdh = new CHITIETDONTHANG();
                ctdh.MaDonHang = ddh.MaDonHang;
                ctdh.Masach = item.iMasach;
                ctdh.Soluong = item.iSoluong;
                ctdh.Dongia = (decimal)item.dDongia;
                db.CHITIETDONTHANGs.Add(ctdh);
            }
            db.SaveChanges();
            Session["Giohang"] = null;
            return RedirectToAction("Xacnhandonhang", "Giohang");
        }
        public ActionResult Xacnhandonhang()
        {
            return View();
        }
        private int tongsl()
        {
            int iSoluong = 0;
            List<Giohang> ltgiohang = Session["Giohang"] as List<Giohang>;
            if (ltgiohang != null)
            {
                iSoluong = ltgiohang.Sum(n => n.iSoluong);
            }
            return iSoluong;
        }
        private Double tongtien()
        {
            double dTongtien = 0;
            List<Giohang> ltgiohang = Session["Giohang"] as List<Giohang>;
            if (ltgiohang != null)
            {
                dTongtien = ltgiohang.Sum(n => n.dThanhtien);
            }
            return dTongtien;
        }
        public ActionResult Giohang()
        {
            List<Giohang> ltgiohang = Laygiohang();
            if (ltgiohang.Count == 0)
            {
                return RedirectToAction("Index", "BookStore");
            }
            ViewBag.Tongsoluong = tongsl();
            ViewBag.Tongtien = tongtien();
            return View(ltgiohang);
        }
    }
}