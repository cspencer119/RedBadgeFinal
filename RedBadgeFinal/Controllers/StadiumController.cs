using Arsenal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RedBadgeFinal.Controllers
{
    public class StadiumController : Controller
    {
        // GET: Stadium
        private StadiumDbContext _db = new StadiumDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stadium stadium)
        {
            if (ModelState.IsValid)
            {
                _db.Stadium.Add(stadium);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stadium);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stadium stadium = _db.Stadium.Find(id);
            if (stadium == null)
            {
                return HttpNotFound();
            }
            return View(stadium);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Stadium stadium = _db.Stadium.Find(id);
            _db.Stadium.Remove(stadium);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stadium stadium = _db.Stadium.Find(id);
            if (stadium == null)
            {
                return HttpNotFound();
            }
            return View(stadium);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Teams team)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(team).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team);
        }
    }
}