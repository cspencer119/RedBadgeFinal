using Arsenal.Data;
using Arsenal.Models;
using Arsenal.Models.Team;
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
    public class TeamController : Controller
    {
        // GET: Team
        private TeamDbContext _db = new TeamDbContext();
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TeamService(userId);
            var model = service.GetTeam();
            //var model = new TeamListItem[20];

            return View(model);
        }
       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teams teams)
        {
            if (ModelState.IsValid)
            {
                _db.Teams.Add(teams);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teams);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teams team = _db.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Teams team = _db.Teams.Find(id);
            _db.Teams.Remove(team);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teams team = _db.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
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