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
    public class QuanTriPj2Controller : Controller
    {
        private K22CNT3_LEVANHOANG_PROJECT2Entities db = new K22CNT3_LEVANHOANG_PROJECT2Entities();

        // GET: QuanTriPj2
        public ActionResult Index()
        {
            return View(db.QuanTriPj2.ToList());
        }

        // GET: QuanTriPj2/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanTriPj2 quanTriPj2 = db.QuanTriPj2.Find(id);
            if (quanTriPj2 == null)
            {
                return HttpNotFound();
            }
            return View(quanTriPj2);
        }

        // GET: QuanTriPj2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanTriPj2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Taikhoan,Matkhau,Trangthai")] QuanTriPj2 quanTriPj2)
        {
            if (ModelState.IsValid)
            {
                db.QuanTriPj2.Add(quanTriPj2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanTriPj2);
        }

        // GET: QuanTriPj2/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanTriPj2 quanTriPj2 = db.QuanTriPj2.Find(id);
            if (quanTriPj2 == null)
            {
                return HttpNotFound();
            }
            return View(quanTriPj2);
        }

        // POST: QuanTriPj2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Taikhoan,Matkhau,Trangthai")] QuanTriPj2 quanTriPj2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanTriPj2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanTriPj2);
        }

        // GET: QuanTriPj2/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanTriPj2 quanTriPj2 = db.QuanTriPj2.Find(id);
            if (quanTriPj2 == null)
            {
                return HttpNotFound();
            }
            return View(quanTriPj2);
        }

        // POST: QuanTriPj2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QuanTriPj2 quanTriPj2 = db.QuanTriPj2.Find(id);
            db.QuanTriPj2.Remove(quanTriPj2);
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
