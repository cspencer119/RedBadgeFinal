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
            },
            new Teams()
            {
                TeamId = 2,
                TeamName = "Aston Villa",
                TeamDescription = "Description of Aston Villa",
                Stadium = "Villa Park",
                StadiumId = 2
            },
            new Teams()
            {
                TeamId = 3,
                TeamName = "Birmingham City",
                TeamDescription = "Description of Birmingham City",
                Stadium = "St Andrew's",
                StadiumId = 3
            },
            new Teams()
            {
                TeamId = 4,
                TeamName = "Blackburn Rovers",
                TeamDescription = "Description of Blackburn Rovers",
                Stadium = "Ewood Park",
                StadiumId = 4
            },
            new Teams()
            {
                TeamId = 5,
                TeamName = "Bolton Wanderers",
                TeamDescription = "Description of Bolton Wanderers",
                Stadium = "Reebok Stadium",
                StadiumId = 5
            },
            new Teams()
            {
                TeamId = 6,
                TeamName = "Charlton Athletic",
                TeamDescription = "Description of Charlton Athletic",
                Stadium = "The Valley",
                StadiumId = 6
            },
            new Teams()
            {
                TeamId = 7,
                TeamName = "Chelsea",
                TeamDescription = "Description of Chelsea",
                Stadium = "Stamford Bridge",
                StadiumId = 7
            },
            new Teams()
            {
                TeamId = 8,
                TeamName = "Everton",
                TeamDescription = "Description of Everton",
                Stadium = "Goodison Park",
                StadiumId = 8
            },
            new Teams()
            {
                TeamId = 9,
                TeamName = "Fulham",
                TeamDescription = "Description of Fulham",
                Stadium = "Loftus Road",
                StadiumId = 9
            },
            new Teams()
            {
                TeamId = 10,
                TeamName = "Leeds United",
                TeamDescription = "Description of Leeds United",
                Stadium = "Elland Road",
                StadiumId = 10
            },
            new Teams()
            {
                TeamId = 11,
                TeamName = "Leicester City",
                TeamDescription = "Description of Leicester City",
                Stadium = "Walkers Stadium",
                StadiumId = 11
            },
            new Teams()
            { 
                TeamId = 12,
                TeamName = "Liverpool",
                TeamDescription = "Description of Liverpool",
                Stadium = "Anfield",
                StadiumId = 12
            },
            new Teams()
            {
                TeamId = 13,
                TeamName = "Manchester City",
                TeamDescription = "Description of Manchester City",
                Stadium = "City of Manchester Stadium",
                StadiumId = 13
            },
            new Teams()
            {
                TeamId = 14,
                TeamName = "Manchester United",
                TeamDescription = "Description of Manchester United",
                Stadium = "Old Trafford",
                StadiumId = 14
            },
            new Teams()
            {
                TeamId = 15,
                TeamName = "Middlesbrough",
                TeamDescription = "Description of Middlesbrough",
                Stadium = "Riverside Stadium",
                StadiumId = 15
            },
            new Teams()
            {
                TeamId = 16,
                TeamName = "Newcastle United",
                TeamDescription = "Description of Newcastle United",
                Stadium = "St James' Park",
                StadiumId = 16
            },
            new Teams()
            {
                TeamId = 17,
                TeamName = "Portsmouth",
                TeamDescription = "Description of Portsmouth",
                Stadium = "Fratton Park",
                StadiumId = 17
            },
            new Teams()
            {
                TeamId = 18,
                TeamName = "Southampton",
                TeamDescription = "Description of Southampton",
                Stadium = "St Mary's Stadium",
                StadiumId = 8
            },
            new Teams()
            {
                TeamId = 19,
                TeamName = "Tottenham Hotspur",
                TeamDescription = "Description of Tottenham",
                Stadium = "White Hart Lane",
                StadiumId = 19
            },
            new Teams()
            {
                TeamId = 20,
                TeamName = "Wolverhampton Wanderers",
                TeamDescription = "Description of Wolverhamton Wanderers",
                Stadium = "Molineux",
                StadiumId = 20
            });


            context.Stadium.AddOrUpdate(x => x.StadiumId, new Stadium()
            {
                StadiumId = 1,
                StadiumName = "Highbury",
                StadiumLocation = "London",
                StadiumDescription = "Descriptin of Highbury",
                StadiumCapacity = 67000
            },
            new Stadium()
            {
                StadiumId = 2,
                StadiumName = "Villa Park",
                StadiumLocation = "Birmingham (Aston)",
                StadiumDescription = "Description",
                StadiumCapacity = 42553
            },
            new Stadium()
            {
                StadiumId = 3,
                StadiumName = "St Andrew's",
                StadiumLocation = "Birmingham (Bordesley)",
                StadiumDescription = "Description",
                StadiumCapacity = 30079
            },
            new Stadium()
            {
                StadiumId = 4,
                StadiumName = "Ewood Park",
                StadiumLocation = "Blackburn",
                StadiumDescription = "Description",
                StadiumCapacity = 31367
            },
            new Stadium()
            {
                StadiumId = 5,
                StadiumName = "Rebook Stadium",
                StadiumLocation = "Bolton",
                StadiumDescription = "Description",
                StadiumCapacity = 28723
            },
            new Stadium()
            {
                StadiumId = 6,
                StadiumName = "The Valley",
                StadiumLocation = "London (Charlton)",
                StadiumDescription = "Description",
                StadiumCapacity = 27111
            },
            new Stadium()
            {
                StadiumId = 7,
                StadiumName = "Stamford Bridge",
                StadiumLocation = "London (Fulham)",
                StadiumDescription = "Description",
                StadiumCapacity = 42360
            },
            new Stadium()
            {
                StadiumId = 8,
                StadiumName = "Goodison Park",
                StadiumLocation = "Liverpool(Walton)",
                StadiumDescription = "Description",
                StadiumCapacity = 40569
            },
            new Stadium()
            {
                StadiumId = 9,
                StadiumName = "Loftus Road",
                StadiumLocation = "London (Shepard's Bush)",
                StadiumDescription = "Description",
                StadiumCapacity = 18493
            },
            new Stadium()
            {
                StadiumId = 10,
                StadiumName = "Elland Road",
                StadiumLocation = "Leeds",
                StadiumDescription = "Description",
                StadiumCapacity = 40242
            },
            new Stadium()
            {
                StadiumId = 11,
                StadiumName = "Walkers Stadium",
                StadiumLocation = "Leicester",
                StadiumDescription = "Description",
                StadiumCapacity = 32312
            },
            new Stadium()
            {
                StadiumId = 12,
                StadiumName = "Anfield",
                StadiumLocation = "Liverpool(Anfield)",
                StadiumDescription = "Description",
                StadiumCapacity = 45276
            },
            new Stadium()
            {
                StadiumId = 13,
                StadiumName = "City of Manchester Stadium",
                StadiumLocation = "Manchester(Brandford)",
                StadiumDescription = "Description",
                StadiumCapacity = 48000
            },
            new Stadium()
            {
                StadiumId = 14,
                StadiumName = "Old Trafford",
                StadiumLocation = "Manchester(Old Trafford)",
                StadiumDescription = "Description",
                StadiumCapacity = 68217
            },
            new Stadium()
            {
                StadiumId = 15,
                StadiumName = "Riverside Stadium",
                StadiumLocation = "Middlesbrough",
                StadiumDescription = "Description",
                StadiumCapacity = 35049
            },
            new Stadium()
            {
                StadiumId = 16,
                StadiumName = "St James' Park",
                StadiumLocation = "Newcastle upon Tyne",
                StadiumDescription = "Description",
                StadiumCapacity = 52387
            },
            new Stadium()
            {
                StadiumId = 17,
                StadiumName = "Fratton Park",
                StadiumLocation = "Portsmouth",
                StadiumDescription = "Description",
                StadiumCapacity = 20220
            },
            new Stadium()
            {
                StadiumId = 18,
                StadiumName = "St Mary's Stadium",
                StadiumLocation = "Southampton",
                StadiumDescription = "Description",
                StadiumCapacity = 32505
            },
            new Stadium()
            {
                StadiumId = 19,
                StadiumName = "White Hart Lane",
                StadiumLocation = "London(Tottenham)",
                StadiumDescription = "Description",
                StadiumCapacity = 36420
            },
            new Stadium()
            {
                StadiumId = 20,
                StadiumName = "Molineux Stadium",
                StadiumLocation = "Wolverhampton",
                StadiumDescription = "Description",
                StadiumCapacity = 29303
            });

            context.Results.AddOrUpdate(x => x.ResultId, new Results()
            {
                ResultId = 1,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Everton",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry, Pires - Radzinski",
                FanAttendance = 38014
            },
            new Results()
            {
                ResultId = 2,
                HomeTeamName = "Middlebrough",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 4,
                Stadium = "Riverside Stadium",
                CompetitionName = "Premier League",
                WhoScored = "NA - Henry, Silva, Wiltord x2",
                FanAttendance = 29450
            },
            new Results()
            {
                ResultId = 3,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Aston Villa",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Campbell, Henry - NA",
                FanAttendance = 38010
            },
            new Results()
            {
                ResultId = 4,
                HomeTeamName = "Manchester City",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 2,
                Stadium = "City of Manchester Stadium",
                CompetitionName = "Premier League",
                WhoScored = "Lauren(OG) - Wiltord, Ljungberg",
                FanAttendance = 46436
            },
            new Results()
            {
                ResultId = 5,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 1,
                AwayTeamName = "Portsmouth",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry - Sheringham",
                FanAttendance = 38052
            },
            new Results()
            {
                ResultId = 6,
                HomeTeamName = "Manchester United",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 0,
                Stadium = "Old Trafford",
                CompetitionName = "Premier League",
                WhoScored = "NA",
                FanAttendance = 67639
            },
            new Results()
            {
                ResultId = 7,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 3,
                AwayTeamName = "Newcastle United",
                AwayTeamScore = 2,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry x2, Silva - Robert, Bernard",
                FanAttendance = 38112
            },
            new Results()
            {
                ResultId = 8,
                HomeTeamName = "Liverpool",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 2,
                Stadium = "Anfield",
                CompetitionName = "Premier League",
                WhoScored = "Kewell - Hyppia(OG), Pires",
                FanAttendance = 44374
            },
            new Results()
            {
                ResultId = 9,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Chelsea",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Edu, Henry - Crespo",
                FanAttendance = 38172
            },
            new Results()
            {
                ResultId = 10,
                HomeTeamName = "Charlton Athletic",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "Th Valley",
                CompetitionName = "Premier League",
                WhoScored = "Di Canio - Henry",
                FanAttendance = 26660
            },
            new Results()
            {
                ResultId = 11,
                HomeTeamName = "Leeds United",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 4,
                Stadium = "Elland Road",
                CompetitionName = "Premier League",
                WhoScored = "Smith - Henry x2, Pires, Silva",
                FanAttendance = 36491
            },
            new Results()
            {
                ResultId = 12,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Tottenham Hotspur",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Pires, Ljungber - Anderton",
                FanAttendance = 38101
            },
            new Results()
            {
                ResultId = 13,
                HomeTeamName = "Birmingham City",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 3,
                Stadium = "St Andrews",
                CompetitionName = "Premier League",
                WhoScored = "NA - Ljungberg, Bergkamp, Pires",
                FanAttendance = 38010
            },
            new Results()
            {
                ResultId = 14,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 0,
                AwayTeamName = "Fulham",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "NA",
                FanAttendance = 38063
            },
            new Results()
            {
                ResultId = 15,
                HomeTeamName = "Leicester City",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "Walkers Stadium",
                CompetitionName = "Premier League",
                WhoScored = "Hignett - Silva",
                FanAttendance = 32108
            },
            new Results()
            {
                ResultId = 16,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 1,
                AwayTeamName = "Blackburn Rovers",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Bergkamp - NA",
                FanAttendance = 37677
            },
            new Results()
            {
                ResultId = 17,
                HomeTeamName = "Bolten Wanderers",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "Reebok Stadium",
                CompetitionName = "Premier League",
                WhoScored = "Pedersen - Pires",
                FanAttendance = 28003
            },
            new Results()
            {
                ResultId = 18,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 3,
                AwayTeamName = "Wolverhampton Wanderers",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Craddock(OG), Henry x2 - NA",
                FanAttendance = 38003
            },
            new Results()
            {
                ResultId = 19,
                HomeTeamName = "Southampton",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "St Mary's Stadium",
                CompetitionName = "Premier League",
                WhoScored = "NA - Pires",
                FanAttendance = 32151
            },
            new Results()
            {
                ResultId = 20,
                HomeTeamName = "Everton",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "Goodison Park",
                CompetitionName = "Premier League",
                WhoScored = "Radzinski - Kanu",
                FanAttendance = 38726
            },
            new Results()
            {
                ResultId = 21,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 4,
                AwayTeamName = "Middlesbrough",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry, Queudrue(OG), Pires, Ljungberg - Maccarone",
                FanAttendance = 38117
            },
            new Results()
            {
                ResultId = 22,
                HomeTeamName = "Aston Villa",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 2,
                Stadium = "Villa Park",
                CompetitionName = "Premier League",
                WhoScored = "NA - Henry x2",
                FanAttendance = 39380
            },
            new Results()
            {
                ResultId = 23,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Manchester City",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Tarnat(OG), Henry - Anelka",
                FanAttendance = 38103
            },
            new Results()
            {
                ResultId = 24,
                HomeTeamName = "Wolverhampton Wanderers",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 3,
                Stadium = "Molineaux",
                CompetitionName = "Premier League",
                WhoScored = "Ganea - Bergkamp, Henry, Toure",
                FanAttendance = 29392
            },
            new Results()
            {
                ResultId = 25,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Southampton",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry x2 - NA",
                FanAttendance = 38007
            },
            new Results()
            {
                ResultId = 26,
                HomeTeamName = "Chelsea",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 2,
                Stadium = "Stamford Bridge",
                CompetitionName = "Premier League",
                WhoScored = "Gudjohnsen - Viera, Edu",
                FanAttendance = 41847
            },
            new Results()
            {
                ResultId = 27,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Charlton Athletic",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Pires, Henry - Jensen",
                FanAttendance = 38137
            },
            new Results()
            {
                ResultId = 28,
                HomeTeamName = "Blackburn Rovers",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 2,
                Stadium = "Ewood Park",
                CompetitionName = "Premier League",
                WhoScored = "NA - Henry, Pires",
                FanAttendance = 28627
            },
            new Results()
            {
                ResultId = 29,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Bolton Wanderers",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Pires, Bergkamp - Campo",
                FanAttendance = 38053
            },
            new Results()
            {
                ResultId = 30,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 1,
                AwayTeamName = "Manchester United",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry - Saha",
                FanAttendance = 38184
            },
            new Results()
            {
                ResultId = 31,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 4,
                AwayTeamName = "Liverpool",
                AwayTeamScore = 2,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry x3, Pires - Hyppia, Owen",
                FanAttendance = 38119
            },
            new Results()
            {
                ResultId = 32,
                HomeTeamName = "Newcastle United",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 0,
                Stadium = "St James' Park",
                CompetitionName = "Premier League",
                WhoScored = "NA",
                FanAttendance = 52141
            },
            new Results()
            {
                ResultId = 33,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 5,
                AwayTeamName = "Leeds United",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Pires, Henry x4 - NA",
                FanAttendance = 38094
            },
            new Results()
            {
                ResultId = 34,
                HomeTeamName = "Tottenham Hotspur",
                HomeTeamScore = 2,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 2,
                Stadium = "White Hart Lane",
                CompetitionName = "Premier League",
                WhoScored = "Redknapp, Keane - Vieira, Pires",
                FanAttendance = 36097
            },
            new Results()
            {
                ResultId = 35,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 0,
                AwayTeamName = "Birmingham City",
                AwayTeamScore = 0,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "NA",
                FanAttendance = 38061
            },
            new Results()
            {
                ResultId = 36,
                HomeTeamName = "Portsmouth",
                HomeTeamScore = 1,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "Fratton Park",
                CompetitionName = "Premier League",
                WhoScored = "Yakubu - Reyes",
                FanAttendance = 20140
            },
            new Results()
            {
                ResultId = 37,
                HomeTeamName = "Fulham",
                HomeTeamScore = 0,
                AwayTeamName = "Arsenal",
                AwayTeamScore = 1,
                Stadium = "Loftus Road",
                CompetitionName = "Premier League",
                WhoScored = "NA - Reyes",
                FanAttendance = 18102
            },
            new Results()
            {
                ResultId = 38,
                HomeTeamName = "Arsenal",
                HomeTeamScore = 2,
                AwayTeamName = "Leicester City",
                AwayTeamScore = 1,
                Stadium = "Highbury",
                CompetitionName = "Premier League",
                WhoScored = "Henry, Vieira - Dickov",
                FanAttendance = 38419
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
