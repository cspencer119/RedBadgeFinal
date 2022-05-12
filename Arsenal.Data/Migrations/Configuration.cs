namespace RedBadgeFinal.Migrations
{
    using Arsenal.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Arsenal.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(Arsenal.Data.ApplicationDbContext context)
        {
            context.Teams.AddOrUpdate(x => x.TeamId, new Teams()
            {
                TeamId = 1,
                TeamName = "Arsenal FC",
                TeamDescription = "Description for Arsenal",
                Stadium = "Emirates",
                StadiumId = 1
            });

            context.Stadium.AddOrUpdate(x => x.StadiumId, new Stadium()
            {
                StadiumId = 1,
                StadiumName = "Emirates",
                StadiumLocation = "London",
                StadiumDescription = "Descriptin of Emirates",
                StadiumCapacity = 67000
            });

            context.Results.AddOrUpdate(x => x.ResultId, new Results()
            {
                ResultId = 1,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "West Ham United",
                AwayTeamScore = 0,
                CompetitionName = "Premier League",
                WhoScored = "Bukayo Saka, Ben White",
                FanAttendance = 67000
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
