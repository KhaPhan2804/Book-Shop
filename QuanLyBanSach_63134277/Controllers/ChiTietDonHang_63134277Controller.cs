using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyBanSach_63134277.Models;

namespace QuanLyBanSach_63134277.Controllers
{
    public class ChiTietDonHang_63134277Controller : Controller
    {
        private QuanLyBanSach_63134277Entities db = new QuanLyBanSach_63134277Entities();

        // GET: ChiTietDonHang_63134277
        public ActionResult Index()
        {
            var chiTietDonHangs = db.ChiTietDonHangs.Include(c => c.DonHang).Include(c => c.Sach);
            return View(chiTietDonHangs.ToList());
        }

        // GET: ChiTietDonHang_63134277/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHang_63134277/Create
        public ActionResult Create()
        {
            ViewBag.ma_DH = new SelectList(db.DonHangs, "ma_DH", "Ten_KH");
            ViewBag.ma_Sach = new SelectList(db.Saches, "ma_Sach", "ten_Sach");
            return View();
        }

        // POST: ChiTietDonHang_63134277/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_CDH,ma_DH,ma_Sach,soluong,tong")] ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietDonHangs.Add(chiTietDonHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_DH = new SelectList(db.DonHangs, "ma_DH", "Ten_KH", chiTietDonHang.ma_DH);
            ViewBag.ma_Sach = new SelectList(db.Saches, "ma_Sach", "ten_Sach", chiTietDonHang.ma_Sach);
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHang_63134277/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_DH = new SelectList(db.DonHangs, "ma_DH", "Ten_KH", chiTietDonHang.ma_DH);
            ViewBag.ma_Sach = new SelectList(db.Saches, "ma_Sach", "ten_Sach", chiTietDonHang.ma_Sach);
            return View(chiTietDonHang);
        }

        // POST: ChiTietDonHang_63134277/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_CDH,ma_DH,ma_Sach,soluong,tong")] ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietDonHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_DH = new SelectList(db.DonHangs, "ma_DH", "Ten_KH", chiTietDonHang.ma_DH);
            ViewBag.ma_Sach = new SelectList(db.Saches, "ma_Sach", "ten_Sach", chiTietDonHang.ma_Sach);
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHang_63134277/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHang);
        }

        // POST: ChiTietDonHang_63134277/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            db.ChiTietDonHangs.Remove(chiTietDonHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
