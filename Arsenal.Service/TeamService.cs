using Arsenal.Data;
using Arsenal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Service
{
    public class TeamService
    {
        public bool TeamCreate(TeamCreate model)
        {
            var entity =
                new Team()
                {
                    TeamId = TeamID,
                    TeamName = model.TeamName,
                    TeamDescription = model.TeamDescription,
                    Stadium = model.Stadium,
                    StadiumId = model.StadiumId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Team
            }
        }
    }
}
