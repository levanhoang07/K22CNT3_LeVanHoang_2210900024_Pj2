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
    public class DonHangPj2Controller : Controller
    {
        private K22CNT3_LEVANHOANG_PROJECT2Entities db = new K22CNT3_LEVANHOANG_PROJECT2Entities();

        // GET: DonHangPj2
        public ActionResult Index()
        {
            var donHangPj2 = db.DonHangPj2.Include(d => d.KhachHangPj2);
            return View(donHangPj2.ToList());
        }

        // GET: DonHangPj2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHangPj2 donHangPj2 = db.DonHangPj2.Find(id);
            if (donHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(donHangPj2);
        }

        // GET: DonHangPj2/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen");
            return View();
        }

        // POST: DonHangPj2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDonHang,MaKH,NgayDatHang,TongTien,TrangThai")] DonHangPj2 donHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.DonHangPj2.Add(donHangPj2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", donHangPj2.MaKH);
            return View(donHangPj2);
        }

        // GET: DonHangPj2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHangPj2 donHangPj2 = db.DonHangPj2.Find(id);
            if (donHangPj2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", donHangPj2.MaKH);
            return View(donHangPj2);
        }

        // POST: DonHangPj2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDonHang,MaKH,NgayDatHang,TongTien,TrangThai")] DonHangPj2 donHangPj2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donHangPj2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangPj2, "MaKH", "HoTen", donHangPj2.MaKH);
            return View(donHangPj2);
        }

        // GET: DonHangPj2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHangPj2 donHangPj2 = db.DonHangPj2.Find(id);
            if (donHangPj2 == null)
            {
                return HttpNotFound();
            }
            return View(donHangPj2);
        }

        // POST: DonHangPj2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DonHangPj2 donHangPj2 = db.DonHangPj2.Find(id);
            db.DonHangPj2.Remove(donHangPj2);
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
