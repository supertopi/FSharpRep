namespace FSharpTest 

    module FSharpTest =

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

            Worker.DoStuffAsync 5000 |>  Async.RunSynchronously
            printfn "%s" ("Work complete!") 

            System.Console.ReadKey(true) |> ignore 

            0
