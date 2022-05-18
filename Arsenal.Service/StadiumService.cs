using Arsenal.Data;
using Arsenal.Models;
using Arsenal.Models.Stadium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Service
{
    public class StadiumService
    {
        private readonly Guid _userId;
        public StadiumService() { }
        public StadiumService(Guid userId)
        {
            _userId = userId;
        }
        public bool TeamCreate(StadiumCreate model)
        {
            var entity =
                new Stadium()
                {
                    StadiumId = model.StadiumId,
                    StadiumName = model.StadiumName,
                    StadiumDescription = model.StadiumDescription,
                    StadiumCapacity = model.StadiumCapacity,
                    StadiumLocation = model.StadiumLocation
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Stadium.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<StadiumListItem> GetStadium()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Stadium
                    .Select(e => new StadiumListItem()
                    {
                        StadiumId = e.StadiumId,
                        StadiumName = e.StadiumName,
                        StadiumCapacity = e.StadiumCapacity,
                        StadiumLocation = e.StadiumLocation
                    });
                return query.ToArray();
            }
        }

        public StadiumDetail GetStadiumById(int stadiumId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var chars = ctx.Stadium.Where(e => e.StadiumId == stadiumId).ToArray();
                foreach (var c in chars)
                {
                    if (c.StadiumId == stadiumId)
                    {
                        var entity = ctx.Stadium.Single(e => e.StadiumId == stadiumId);
                        return
                            new StadiumDetail
                            {
                                StadiumId = entity.StadiumId,
                                StadiumName = entity.StadiumName,
                                StadiumDescription = entity.StadiumDescription,
                                StadiumCapacity = entity.StadiumCapacity
                            };
                    }
                }
                return null;
            }
        }

        public bool UpdateStadium(StadiumEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                        var entity =
                            ctx
                            .Stadium.Single(e => e.StadiumId == model.StadiumId);
                        entity.StadiumName = model.StadiumName;
                        entity.StadiumDescription = model.StadiumDescription;
                        entity.StadiumCapacity = model.StadiumCapacity;
                        return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteStadium(int stadiumId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var userStadium = ctx.Stadium.Where(e => e.UserId == _userId).ToArray();
                foreach (var c in userStadium)
                {
                    if (c.StadiumId == stadiumId)
                    {
                        var entity =
                            ctx
                            .Teams
                            .Single(e => e.StadiumId == stadiumId && e.UserId == _userId);

                        ctx.Teams.Remove(entity);
                        return ctx.SaveChanges() == 1;
                    }
                }
                return false;
            }
        }
    }
}

