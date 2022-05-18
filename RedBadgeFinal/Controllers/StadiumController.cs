using Arsenal.Data;
using Arsenal.Models.Stadium;
using Arsenal.Service;
using Microsoft.AspNet.Identity;
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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new StadiumService(userId);
            var model = service.GetStadium();
            //var model = new StadiumListItem[20];
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stadium stadium)
        {
            if (!ModelState.IsValid)
            {
                return View(stadium);
            }
            var service = CreateStadiumService();

            ModelState.AddModelError("", "Stadium could not be created.");

            return View(stadium);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateStadiumService();
            var model = svc.GetStadiumById(id);

            return View(model);
        }

        private StadiumService CreateStadiumService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new StadiumService(userId);
            return service;
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
        public ActionResult Edit(Stadium team)
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