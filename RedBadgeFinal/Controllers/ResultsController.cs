using Arsenal.Data;
using Arsenal.Models.Results;
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
    public class ResultsController : Controller
    {
        // GET: Results
        private ResultsDbContext _db = new ResultsDbContext();
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ResultsService(userId);
            var model = service.GetResults();
            //var model = new ResultListItem[38];
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Results result)
        {
            if (ModelState.IsValid)
            {
                _db.Results.Add(result);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Results result = _db.Results.Find(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Results result = _db.Results.Find(id);
            _db.Results.Remove(result);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Results results = _db.Results.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            return View(results);
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