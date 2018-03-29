# Round robin scheduler class description
This document briefly describes 
the classes impleneted in the project
## District
It contains info about region. Ids are assigned to
its names, like:  
int id=1, string name=Małopolska  
2 - Mazowsze  
etc.
## Team
Team has its id, name and district, eg:  
int id=466, string name=Garbarnia Kraków, 
District assignedDistrict=Małopolska
## Match
Holds info about single match.
Team HomeTeam, Team AwayTeam, Result MatchResult
## Result
Just results and control of values (>0). Ints are nullable
in case of matches not played yet
int? HomeScore, int? AwayScore
## League
Contains schedule and identifier of league
int Id, string Name (like Name=2. liga, wschód), Season LeagueSeason, 
List<Round> Rounds
## IScheduler
Interface for schedulers (could be different like 
round robin, knock-out). Need to assing season and id?
bool LoadTeam(List<Team>) - true if List.Count > 1,
void GenerateSchedule()
and id present 
## GroupScheduler
Implements IScheduler. Round robin scheduling for league
## KnockOutScheduler
Implements IScheduler. National Cup, league cup etc.
## Round
List<Match>
## Season
int Id, string Name
