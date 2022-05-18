Red Badge Final Project ReadMe

This Red Badge Final Project is my attempt at creating a easy and simple to use database for Arsenal FC. Serving as a reference to the teams that Arsenal has played against as well as the various stadiums they have played it the database also provides a list of results of games played. 

Features

Full CRUD of Teams, Stadiums, and Results

Easy to read lists of Teams, Stadiums and Results

Information of Teams include TeamId, TeamName, TeamDescription, Stadium and StadiumId

Information of Stadiums include StadiumId, StadiumName, StadiumLocation, StadiumDescription and StadiumCapacity

Information of Results include HomeTeamName, AwayTeamName, HomeTeamScore,AwayTeamScore, WhoScored, Stadium, FanAttendance and CompetitionName

Already includes 20 different Teams, Id's are assigned by Alphabetical Order

Includes 20 different Stadiums, Id's are assigned by the Teams Alphabetical Order (TeamId always matches StadiumId)

Includes 38 different Results, ResultsId's are assigned as the order of games played during that season



Some Feature that I look to be adding in the future are

Additional Teams that Arsenal has played in previous season of the Premier League as well as other Competitions

Additional Stadiums that Arsenal have played in 

Additional Seasons worth of Results as well as the inclusion of Seasons so as to differentiate the groups of results by Season AND Competition



Seed List does exist so when making changes
you can update the contents of the Seed List in the Migrations Folder/Configuration File 
then type into the Package Manager Console
  - Update-Database

Or 

By running the application you can go the the appropriate section of the website and then either click on 

Create - to Create a whole new Team, Stadium or Result (Remember to assign an Id that does not currently assigned to another Team, Stadium or Result)

Edit - to Update an existing Team, Stadium or Result

Delete - to Delete an existing Team, Stadium or Result (Please do not delete needlessly, only if large changes needed to be made to multiple Teams, Stadiums or Results)

link to my dbdiagram - https://dbdiagram.io/d/626aa48195e7f23c619036fe

link to the published site on Azure - https://arsenaldatabaseresult.azurewebsites.net

Author
Cyrus Spencer


