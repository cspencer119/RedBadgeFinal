using Arsenal.Data;
using Arsenal.Models;
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
            if (!ModelState.IsValid)
            {
               return View(result); 
            }

            var service = CreateResultsService();

            ModelState.AddModelError("", "Result could not be created.");

            return View(result);
            
        }

        public ActionResult Details(int id)
        {
            var svc = CreateResultsService();
            var model = svc.GetResultsById(id);

            return View(model);
        }

        private ResultsService CreateResultsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ResultsService(userId);
            return service;
        }


        public ActionResult Edit(int id)
        {
            var service = CreateResultsService();
            var detail = service.GetResultsById(id);
            var model =
                new ResultsEdit
                {
                    ResultId = detail.ResultId,
                    HomeTeamName = detail.HomeTeamName,
                    HomeTeamScore = detail.HomeTeamScore,
                    AwayTeamName = detail.AwayTeamName,
                    AwayTeamScore = detail.AwayTeamScore,
                    WhoScored = detail.WhoScored,
                    FanAttendance = detail.FanAttendance,
                    CompetitionName = detail.CompetitionName
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ResultsEdit results)
        {
            if (!ModelState.IsValid) return View(results);

            if (results.ResultId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(results);
            }

            var service = CreateResultsService();

            if (service.UpdateResult(results))
            {
                TempData["SaveResult"] = "Your stadium was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The result could not be updated.");
            return View(results);
        }


        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateResultsService();
            var model = svc.GetResultsById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateResultsService();

            service.DeleteResult(id);

            TempData["SaveResult"] = "Your result was deleted.";

            return RedirectToAction("Index");
        }
    }
}