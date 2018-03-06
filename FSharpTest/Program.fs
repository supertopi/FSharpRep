namespace FSharpTest 

    module FSharpTest =
        open HockeyTeam
        open System.Net.Cache

        [<EntryPoint>]
        let main _args  =

            printfn "%i" (MyMath.DivideByTwo 5)

            printfn "%b" (
                [0..100]
                |> MyMath.MultiplyByTwoAndPreserveOdds
                |> MyMath.HasEvens);


            printfn "%s" (
                "Hello World from F#" 
                |> PigLatin.ToPigLatin)
            
            printfn "%s" (
                "My standard gravational force in Newtons:  " + 
                string (CSharpPhysics.MyPhysics.GetStandardGravityForce( 64.2 ) ))
            
            let c = CSharpPhysics.Circuit()
            c.Resistance <- 10
            c.Voltage <- 230
            printfn "%s" (
                "Current in my circuit is " + string (c.GetFloorCurrent()) + "A")                       
            
            Worker.DoStuffAsync 5000 |>  Async.RunSynchronously
            printfn "%s" ("Work complete!") 

            let p = { Information = { Name = "Wayne Gretzky"; Age = 57 }; Pos = Center ; Number = 99}
            
            printfn "%s" (IsGoalie p)

            System.Console.ReadKey(true) |> ignore 

            0
