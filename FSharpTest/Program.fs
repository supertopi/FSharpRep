namespace FSharpTest 

    module FSharpTest =

        [<EntryPoint>]
        let main _args  =

            printfn "%i" (MyMath.DivideByTwo 5)

            printfn "%b" (
                [0..100]
                |> MyMath.MultiplyByTwoAndPreserveOdds
                |> MyMath.HasEvens);


            printf "%s" (
                "Hello World from F#" 
                |> PigLatin.ToPigLatin)

            System.Console.ReadKey(true) |> ignore 

            0
