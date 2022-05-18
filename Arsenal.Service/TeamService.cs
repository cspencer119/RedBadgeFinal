using Arsenal.Data;
using Arsenal.Models;
using Arsenal.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Service
{
    public class TeamService
    {
        private readonly Guid _userId;
        public TeamService() { }
        public TeamService(Guid userId)
        {
            _userId = userId;
        }
        public bool TeamCreate(TeamCreate model)
        {
            var entity =
                new Teams()
                {
                    TeamId = model.TeamId,
                    TeamName = model.TeamName,
                    TeamDescription = model.TeamDescription,
                    Stadium = model.Stadium,
                    StadiumId = model.StadiumId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TeamListItem> GetTeam()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Teams
                    .Select(e => new TeamListItem()
                    {
                        TeamId = e.TeamId,
                        TeamName = e.TeamName
                    });
                return query.ToArray();
            }
        }


        public TeamDetail GetTeamById(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
    
                 var entity = ctx.Teams.Single(e => e.TeamId == teamId);
                return
                    new TeamDetail
                    {
                        TeamId = entity.TeamId,
                        TeamName = entity.TeamName,
                        TeamDescription = entity.TeamDescription,
                        Stadium = entity.Stadium,
                        StadiumId = entity.StadiumId
                    };
            }
        }

        public bool UpdateTeam(TeamEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                        var entity =
                            ctx
                            .Teams.Single(e => e.TeamId == model.TeamId);
                        entity.TeamName = model.TeamName;
                        entity.TeamDescription = model.TeamDescription;
                        entity.Stadium = model.Stadium;
                        entity.StadiumId = model.StadiumId;
                        return ctx.SaveChanges() == 1;
                
            }
        }
        
        public bool DeleteTeam(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                        var entity =
                            ctx
                            .Teams
                            .Single(e => e.TeamId == teamId && e.UserId == _userId);

                        ctx.Teams.Remove(entity);
                        return ctx.SaveChanges() == 1;
                 
            }
        }
    }
}
