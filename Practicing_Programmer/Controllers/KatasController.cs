using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Practicing_Programmer.Models;
using Practicing_Programmer.DAL;
using System.Data.Entity;

namespace Practicing_Programmer.Controllers
{
    public class KatasController : Controller
    {
        private PracticingProgrammerDb db = new PracticingProgrammerDb();

        //
        // GET: /Kata/

        public ActionResult Index(string searchTerm = null)
        {
            var model = from k in db.Katas
                        .Where(k => searchTerm == null || k.Title.Contains(searchTerm))
                        orderby k.Category
                        select k;

            return View(model);
        }

        //
        // GET: /Kata/Details/5

        public ActionResult Details(int id = 0)
        {
            Kata kata = db.Katas.Find(id);
            if (kata == null)
            {
                return HttpNotFound();
            }
            return View(kata);
        }

        //
        // GET: /Kata/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Kata/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kata kata)
        {
            if (ModelState.IsValid)
            {
                db.Katas.Add(kata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kata);
        }

        //
        // GET: /Kata/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Kata kata = db.Katas.Find(id);
            if (kata == null)
            {
                return HttpNotFound();
            }
            return View(kata);
        }

        //
        // POST: /Kata/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kata kata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kata);
        }

        //
        // GET: /Kata/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Kata kata = db.Katas.Find(id);
            if (kata == null)
            {
                return HttpNotFound();
            }
            return View(kata);
        }

        //
        // POST: /Kata/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kata kata = db.Katas.Find(id);
            db.Katas.Remove(kata);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}