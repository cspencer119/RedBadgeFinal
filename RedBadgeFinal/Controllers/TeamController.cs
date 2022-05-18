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
            if (!ModelState.IsValid)
            {
                return View(teams);
            }
            var service = CreateTeamService();

            //if (service.TeamCreate(teams))
            {
                //TempData["SaveResult"] = "The team was created";
                //return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Team could not be created");

            return View(teams);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateTeamService();
            var model = svc.GetTeamById(id);

            return View(model);
        }

        private TeamService CreateTeamService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TeamService(userId);
            return service;
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

        public ActionResult Edit(int id)
        {
            var service = CreateTeamService();
            var detail = service.GetTeamById(id);
            var model =
                new TeamEdit
                {
                    TeamId = detail.TeamId,
                    TeamName = detail.TeamName,
                    TeamDescription = detail.TeamDescription,
                    Stadium = detail.Stadium,
                    StadiumId = detail.StadiumId
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TeamEdit team)
        {
            if (!ModelState.IsValid) return View(team);

            if (team.TeamId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(team);
            }

            var service = CreateTeamService();

            if (service.UpdateTeam(team))
            {
                TempData["SaveResult"] = "Your team was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your team could not be updated.");
            return View(team);
        }
    }
}