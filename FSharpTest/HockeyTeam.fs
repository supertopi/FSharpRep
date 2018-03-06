namespace FSharpTest

module HockeyTeam  = 
   
    type Person = {Name: string; Age: int }
    //type Person = string * int 

    type Role = Coach | Maintenance | Cheerleader
    type Position = Goalie | Defense | Center | Wingman

    type Player = { Information : Person ;  Pos : Position ; Number : int }
    type Sideliner = { Information : Person ; Role : Role }

    type TeamMember = Player | Sideliner

    type Roster = List of TeamMember

    let IsGoalie (player : Player) =
        player.Information.Name + 
            match player.Pos with
                | Goalie ->  " on moke"
                | _ -> " ei oo moke"