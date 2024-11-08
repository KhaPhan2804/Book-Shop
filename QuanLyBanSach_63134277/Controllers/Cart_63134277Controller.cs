using QuanLyBanSach_63134277.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanSach_63134277.Controllers
{
    public class Cart_63134277Controller : Controller
    {
        // GET: Cart_63134277
        QuanLyBanSach_63134277Entities db = new QuanLyBanSach_63134277Entities();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public ActionResult AddToCart(int id)
        {

            var sachs = db.Saches.SingleOrDefault(s => s.ma_Sach == id);
            {
                if (sachs != null)
                {
                    GetCart().Add(sachs);
                }
            }
            return RedirectToAction("ShowToCart", "Cart_63134277");
        }
        public ActionResult ThanhToan()
        {
            return View();
        }
        public ActionResult Show()
        {
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult CheckOut(FormCollection form)
        {

            try
            {
                Cart cart = Session["Cart"] as Cart;
                DonHang dh = new DonHang();
                dh.ngaydat = DateTime.Now;
                dh.Ten_KH = form["Ten_KH"];
                dh.diachi = form["diachi"];
                dh.ghichu = form["ghichu"];
                dh.email = form["email"];
                db.DonHangs.Add(dh);
                foreach (var item in cart.Items)
                {
                    ChiTietDonHang ct = new ChiTietDonHang();
                    ct.ma_DH = dh.ma_DH;
                    ct.ma_Sach = item._sach.ma_Sach;
                    ct.tong = item._sach.giatien;
                    ct.soluong = item._sach_soluong;
                    db.ChiTietDonHangs.Add(ct);

                }
                db.SaveChanges();
                cart.ClearCart();
                return RedirectToAction("ThanhCong", "Cart_63134277");
            }
            catch
            {
                return Content("Đặt hàng không thành công");
            }

        }
        public ActionResult ThanhCong()
        {
            return View();
        }
        public ActionResult ShowToCart()
        {
            if (Session["Cart"] == null)
            {
                return RedirectToAction("ShowToCart", "Cart_63134277");

            }
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult Update(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            int ma_sach = int.Parse(form["MaSach"]);
            int soluong = int.Parse(form["SL"]);
            cart.Update_Soluong(ma_sach, soluong);
            return RedirectToAction("ShowToCart", "Cart_63134277");
        }
        public ActionResult Remove_Cart(int id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove(id);
            return RedirectToAction("ShowToCart", "Cart_63134277");
        }
        public PartialViewResult Bag()
        {
            int total = 0;
            Cart cart = Session["Cart"] as Cart;
            if (cart != null)
            {
                total = cart.Tong_SL();
                ViewBag.sl_cart = total;
                return PartialView("Bag");
            }
            return PartialView();
        }
    }
}