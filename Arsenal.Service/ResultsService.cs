using Arsenal.Data;
using Arsenal.Models;
using Arsenal.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Service
{
    public class ResultsService
    {
        private readonly Guid _userId;
        public ResultsService() { }
        public ResultsService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateResult(ResultsCreate model)
        {
            var entity =
                new Results()
                {
                    UserId = _userId,
                    HomeTeamName = model.HomeTeamName,
                    AwayTeamName = model.AwayTeamName,
                    HomeTeamScore = model.HomeTeamScore,
                    AwayTeamScore = model.AwayTeamScore,
                    WhoScored = model.WhoScored,
                    FanAttendance = model.FanAttendance,
                    CompetitionName = model.CompetitionName
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Results.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ResultListItem> GetResults()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Results
                    .Select(e => new ResultListItem
                    {
                        ResultId = e.ResultId,
                        HomeTeamName = e.HomeTeamName,
                        HomeTeamScore = e.HomeTeamScore,
                        AwayTeamName = e.AwayTeamName,
                        AwayTeamScore = e.AwayTeamScore,
                        WhoScored = e.WhoScored,
                        FanAttendance = e.FanAttendance,
                        CompetitionName = e.CompetitionName
                    });
                return query.ToArray();
            }
        }

        public ResultsDetail GetResultsById(int resultId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var chars = ctx.Results.Where(e => e.ResultId == resultId).ToArray();
                foreach (var c in chars)
                {
                    if (c.ResultId == resultId)
                    {
                        var entity = ctx.Results.Single(e => e.ResultId == resultId);
                        return
                            new ResultsDetail()
                            {
                                HomeTeamName = entity.HomeTeamName,
                                HomeTeamScore = entity.HomeTeamScore,
                                AwayTeamName = entity.AwayTeamName,
                                AwayTeamScore = entity.AwayTeamScore,
                                WhoScored = entity.WhoScored,
                                FanAttendance = entity.FanAttendance,
                                CompetitionName = entity.CompetitionName
                            };
                    }
                }
                return null;
            }
        }

        public bool UpdateResult(ResultsEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var all = ctx.Results.ToArray();
                foreach (var c in all)
                {
                    if (c.ResultId == model.ResultId)
                    {
                        var entity =
                            ctx
                            .Results.Single(e => e.ResultId == model.ResultId);
                        entity.HomeTeamName = model.HomeTeamName;
                        entity.HomeTeamScore = model.HomeTeamScore;
                        entity.AwayTeamName = model.AwayTeamName;
                        entity.AwayTeamScore = model.AwayTeamScore;
                        entity.WhoScored = model.WhoScored;
                        entity.FanAttendance = model.FanAttendance;
                        entity.CompetitionName = model.CompetitionName;
                        return ctx.SaveChanges() >= 1;
                    }
                }
                return false;
            }
        }

        public bool DeleteResult(int resultId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var userResults = ctx.Results.Where(e => e.UserId == _userId).ToArray();
                foreach (var c in userResults)
                {
                    if (c.ResultId == resultId)
                    {
                        var entity =
                            ctx
                            .Results
                            .Single(e => e.ResultId == resultId && e.UserId == _userId);

                        ctx.Results.Remove(entity);
                        return ctx.SaveChanges() == 1;
                    }
                }
                return false;
            }
        }
    }
}
