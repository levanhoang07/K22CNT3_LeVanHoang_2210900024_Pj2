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
    public class GioHangPj2Controller : Controller
    {
        private K22CNT3_LEVANHOANG_PROJECT2Entities db = new K22CNT3_LEVANHOANG_PROJECT2Entities();

        // GET: GioHangPj2
        public ActionResult Index()
        {
            var gioHangPj2 = db.GioHangPj2.Include(g => g.KhachHangPj2).Include(g => g.SanPhamPj2);
            return View(gioHangPj2.ToList());
        }

        // GET: GioHangPj2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GioHangPj2 gioHangPj2 = db.GioHangPj2.Find(id);
            if (gioHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(gioHangPj2);
        }

        // GET: GioHangPj2/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen");
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP");
            return View();
        }

        // POST: GioHangPj2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGioHang,MaKH,MaSP,SoLuong,NgayThem,TrangThai")] GioHangPj2 gioHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.GioHangPj2.Add(gioHangPj2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", gioHangPj2.MaKH);
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP", gioHangPj2.MaSP);
            return View(gioHangPj2);
        }

        // GET: GioHangPj2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GioHangPj2 gioHangPj2 = db.GioHangPj2.Find(id);
            if (gioHangPj2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", gioHangPj2.MaKH);
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP", gioHangPj2.MaSP);
            return View(gioHangPj2);
        }

        // POST: GioHangPj2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGioHang,MaKH,MaSP,SoLuong,NgayThem,TrangThai")] GioHangPj2 gioHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gioHangPj2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", gioHangPj2.MaKH);
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP", gioHangPj2.MaSP);
            return View(gioHangPj2);
        }

        // GET: GioHangPj2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GioHangPj2 gioHangPj2 = db.GioHangPj2.Find(id);
            if (gioHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(gioHangPj2);
        }

        // POST: GioHangPj2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GioHangPj2 gioHangPj2 = db.GioHangPj2.Find(id);
            db.GioHangPj2.Remove(gioHangPj2);
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
