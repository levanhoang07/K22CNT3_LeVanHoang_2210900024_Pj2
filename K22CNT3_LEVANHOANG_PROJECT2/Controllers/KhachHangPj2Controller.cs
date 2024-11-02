using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using K22CNT3_LEVANHOANG_PROJECT2.Models;

namespace K22CNT3_LEVANHOANG_PROJECT2.Controllers
{
    public class KhachHangPj2Controller : Controller
    {
        private K22CNT3_LEVANHOANG_PROJECT2Entities db = new K22CNT3_LEVANHOANG_PROJECT2Entities();

        // GET: KhachHangPj2
        public ActionResult Index()
        {
            return View(db.KhachHangPj2.ToList());
        }

        // GET: KhachHangPj2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHangPj2 khachHangPj2 = db.KhachHangPj2.Find(id);
            if (khachHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(khachHangPj2);
        }

        // GET: KhachHangPj2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangPj2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKH,HoTen,TaiKhoan,MatKhau,DiaChi,DienThoai,Email,NgaySinh,NgayCapNhat,GioiTinh,TrangThai")] KhachHangPj2 khachHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.KhachHangPj2.Add(khachHangPj2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khachHangPj2);
        }

        // GET: KhachHangPj2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHangPj2 khachHangPj2 = db.KhachHangPj2.Find(id);
            if (khachHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(khachHangPj2);
        }

        // POST: KhachHangPj2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKH,HoTen,TaiKhoan,MatKhau,DiaChi,DienThoai,Email,NgaySinh,NgayCapNhat,GioiTinh,TrangThai")] KhachHangPj2 khachHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khachHangPj2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khachHangPj2);
        }

        // GET: KhachHangPj2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHangPj2 khachHangPj2 = db.KhachHangPj2.Find(id);
            if (khachHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(khachHangPj2);
        }

        // POST: KhachHangPj2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KhachHangPj2 khachHangPj2 = db.KhachHangPj2.Find(id);
            db.KhachHangPj2.Remove(khachHangPj2);
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
