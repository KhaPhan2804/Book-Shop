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
    public class Sach_63134277Controller : Controller
    {
        private QuanLyBanSach_63134277Entities db = new QuanLyBanSach_63134277Entities();

        // GET: Sach_63134277
        public ActionResult Index(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult DS(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult SP(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult TT(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult LS(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult PL(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult KH(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult TG(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult KD(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult TL(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult TT1(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult VHNT(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult ST(string SearchString = "")
        {
            if (SearchString != "")
            {
                var saches = db.Saches.Include(s => s.LoaiSach).Where(x => x.ten_Sach.ToUpper().Contains(SearchString.ToUpper()));
                return View(saches.ToList());
            }
            else
            {
                var saches = db.Saches.Include(s => s.LoaiSach);
                return View(saches.ToList());
            }
        }
        public ActionResult ChiTiet(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // GET: Sach_63134277/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // GET: Sach_63134277/Create
        public ActionResult Create()
        {
            ViewBag.ma_LS = new SelectList(db.LoaiSaches, "ma_LS", "ten_LS");
            return View();
        }

        // POST: Sach_63134277/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_Sach,ten_Sach,loai_Sach,giatien,anh_Sach,mota,ma_LS")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Saches.Add(sach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_LS = new SelectList(db.LoaiSaches, "ma_LS", "ten_LS", sach.ma_LS);
            return View(sach);
        }

        // GET: Sach_63134277/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_LS = new SelectList(db.LoaiSaches, "ma_LS", "ten_LS", sach.ma_LS);
            return View(sach);
        }

        // POST: Sach_63134277/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_Sach,ten_Sach,loai_Sach,giatien,anh_Sach,mota,ma_LS")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_LS = new SelectList(db.LoaiSaches, "ma_LS", "ten_LS", sach.ma_LS);
            return View(sach);
        }

        // GET: Sach_63134277/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // POST: Sach_63134277/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sach sach = db.Saches.Find(id);
            db.Saches.Remove(sach);
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
