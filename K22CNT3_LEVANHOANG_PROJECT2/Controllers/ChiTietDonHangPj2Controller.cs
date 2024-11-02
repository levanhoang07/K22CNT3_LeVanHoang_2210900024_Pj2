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
    public class ChiTietDonHangPj2Controller : Controller
    {
        private K22CNT3_LEVANHOANG_PROJECT2Entities db = new K22CNT3_LEVANHOANG_PROJECT2Entities();

        // GET: ChiTietDonHangPj2
        public ActionResult Index()
        {
            var chiTietDonHangPj2 = db.ChiTietDonHangPj2.Include(c => c.KhachHangPj2).Include(c => c.SanPhamPj2);
            return View(chiTietDonHangPj2.ToList());
        }

        // GET: ChiTietDonHangPj2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHangPj2 chiTietDonHangPj2 = db.ChiTietDonHangPj2.Find(id);
            if (chiTietDonHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHangPj2);
        }

        // GET: ChiTietDonHangPj2/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen");
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP");
            return View();
        }

        // POST: ChiTietDonHangPj2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChiTiet,MaKH,MaSP,SoLuong,DonGia,NgayDatHang")] ChiTietDonHangPj2 chiTietDonHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietDonHangPj2.Add(chiTietDonHangPj2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", chiTietDonHangPj2.MaKH);
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP", chiTietDonHangPj2.MaSP);
            return View(chiTietDonHangPj2);
        }

        // GET: ChiTietDonHangPj2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHangPj2 chiTietDonHangPj2 = db.ChiTietDonHangPj2.Find(id);
            if (chiTietDonHangPj2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", chiTietDonHangPj2.MaKH);
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP", chiTietDonHangPj2.MaSP);
            return View(chiTietDonHangPj2);
        }

        // POST: ChiTietDonHangPj2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChiTiet,MaKH,MaSP,SoLuong,DonGia,NgayDatHang")] ChiTietDonHangPj2 chiTietDonHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietDonHangPj2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", chiTietDonHangPj2.MaKH);
            ViewBag.MaSP = new SelectList(db.SanPhamPj2, "MaSP", "TenSP", chiTietDonHangPj2.MaSP);
            return View(chiTietDonHangPj2);
        }

        // GET: ChiTietDonHangPj2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHangPj2 chiTietDonHangPj2 = db.ChiTietDonHangPj2.Find(id);
            if (chiTietDonHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHangPj2);
        }

        // POST: ChiTietDonHangPj2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietDonHangPj2 chiTietDonHangPj2 = db.ChiTietDonHangPj2.Find(id);
            db.ChiTietDonHangPj2.Remove(chiTietDonHangPj2);
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
