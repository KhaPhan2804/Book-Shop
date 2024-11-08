using QuanLyBanSach_63134277.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanSach_63134277.Controllers
{
    public class Account_63134277Controller : Controller
    {
        // GET: Account_63134277
        QuanLyBanSach_63134277Entities db = new QuanLyBanSach_63134277Entities();
        public ActionResult Index()
        {
            return View(db.Accounts.ToList());
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult Signout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Sach_63134277");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account account)
        {
            var checkLogin = db.Accounts.Where(x => x.Email.Equals(account.Email) && x.MK.Equals(account.MK)).FirstOrDefault();
            if (checkLogin != null)
            {
                Account acc = db.Accounts.FirstOrDefault(x => x.Email.Equals(account.Email) && x.MK.Equals(account.MK));
                Session["Email"] = account.Email.ToString();
                Session["TenHienThi"] = acc.TenHienThi.ToString();
                if (acc.RoleID == 1)
                {
                    return RedirectToAction("Index", "NhanVien_63134277");
                }
                else
                {
                    return RedirectToAction("Index", "Sach_63134277");
                }

            }
            else
            {
                ViewBag.Notification = "Sai tài khoản hoặc mật khẩu!!";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Account account)
        {
            if (db.Accounts.Any(x => x.Email == account.Email))
            {
                ViewBag.Notification = "Tài khoản này đã tồn tại";
                return View();
            }
            else
            {
                account.RoleID = 0;
                account.CreateDate = DateTime.Now;
                if (account.MK != account.RePass)
                {
                    ViewBag.Notification = "Mật khẩu không chính xác, vui lòng nhập lại!!";
                    return View();
                }
                db.Accounts.Add(account);
                db.SaveChanges();

                Session["Email"] = account.Email.ToString();
                Session["TenHienThi"] = account.TenHienThi.ToString();
                return RedirectToAction("Index", "Sach_63134277");
            }
        }
    }
}
