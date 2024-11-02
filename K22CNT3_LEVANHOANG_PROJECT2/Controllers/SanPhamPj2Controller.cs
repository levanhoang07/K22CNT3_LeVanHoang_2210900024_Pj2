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
    public class SanPhamPj2Controller : Controller
    {
        private K22CNT3_LEVANHOANG_PROJECT2Entities db = new K22CNT3_LEVANHOANG_PROJECT2Entities();

        // GET: SanPhamPj2
        public ActionResult Index()
        {
            return View(db.SanPhamPj2.ToList());
        }

        // GET: SanPhamPj2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPhamPj2 sanPhamPj2 = db.SanPhamPj2.Find(id);
            if (sanPhamPj2 == null)
            {
                return HttpNotFound();
            }
            return View(sanPhamPj2);
        }

        // GET: SanPhamPj2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPhamPj2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSP,TenSP,MoTa,Gia,SoLuong,NgayNhap,TrangThai")] SanPhamPj2 sanPhamPj2)
        {
            if (ModelState.IsValid)
            {
                db.SanPhamPj2.Add(sanPhamPj2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sanPhamPj2);
        }

        // GET: SanPhamPj2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPhamPj2 sanPhamPj2 = db.SanPhamPj2.Find(id);
            if (sanPhamPj2 == null)
            {
                return HttpNotFound();
            }
            return View(sanPhamPj2);
        }

        // POST: SanPhamPj2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSP,TenSP,MoTa,Gia,SoLuong,NgayNhap,TrangThai")] SanPhamPj2 sanPhamPj2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPhamPj2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sanPhamPj2);
        }

        // GET: SanPhamPj2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPhamPj2 sanPhamPj2 = db.SanPhamPj2.Find(id);
            if (sanPhamPj2 == null)
            {
                return HttpNotFound();
            }
            return View(sanPhamPj2);
        }

        // POST: SanPhamPj2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SanPhamPj2 sanPhamPj2 = db.SanPhamPj2.Find(id);
            db.SanPhamPj2.Remove(sanPhamPj2);
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
