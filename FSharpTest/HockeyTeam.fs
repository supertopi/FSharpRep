namespace FSharpTest

module HockeyTeam  = 
   
    type Person = {Name: string; Age: int }
    //type Person = string * int 

    type Position = Goalie | Defense | Center | Wingman
    type Role = Coach | Maintenance | Cheerleader

    type Player = { Information : Person ;  Pos : Position ; Number : int }
    type Sideliner = { Information : Person ; Role : Role }
    type TeamMember = Player | Sideliner

    type Roster = List of TeamMember


