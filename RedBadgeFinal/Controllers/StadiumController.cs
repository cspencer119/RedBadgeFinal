using Arsenal.Data;
using Arsenal.Models;
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

        public ActionResult Edit(int id)
        {
            var service = CreateStadiumService();
            var detail = service.GetStadiumById(id);
            var model =
                new StadiumEdit
                {
                    StadiumId = detail.StadiumId,
                    StadiumName = detail.StadiumName,
                    StadiumLocation = detail.StadiumLocation,
                    StadiumDescription = detail.StadiumDescription,
                    StadiumCapacity = detail.StadiumCapacity
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StadiumEdit stadium)
        {
            if (!ModelState.IsValid) return View(stadium);

            if (stadium.StadiumId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(stadium);
            }

            var service = CreateStadiumService();

            if (service.UpdateStadium(stadium))
            {
                TempData["SaveResult"] = "Your stadium was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The stadium could not be updated.");
            return View(stadium);
        }


        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateStadiumService();
            var model = svc.GetStadiumById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateStadiumService();

            service.DeleteStadium(id);

            TempData["SaveResult"] = "Your stadium was deleted.";

            return RedirectToAction("Index");
        }
    }
}