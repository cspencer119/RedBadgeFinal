using Arsenal.Models;
using Arsenal.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedBadgeFinal.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        private TeamService CreateTeamServiceUserId()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var cService = new TeamService(userId);
            return cService;
        }

        private TeamService CreateTeamService()
        {
            var cService = new TeamService();
            return cService;
        }

        public IHttpActionResult Get()
        {
            var cService = CreateTeamService();
            var team = cService.GetTeam();
            return Ok(team);
        }

        [Authorize]
        public IHttpActionResult Post(TeamCreate team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var cService = CreateTeamServiceUserId();
            if (!cService.CreateTeam(team))
                return InternalServerError();
            return Ok($"Team {team.TeamName} has been created!");
        }

    }
}