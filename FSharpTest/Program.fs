namespace FSharpTest 

    module FSharpTest =

        [<EntryPoint>]
        let main _args  =

            printfn "%b" (
                [0..100]
                |> MyMath.DivideByTwoAndFilterEvens
                |> MyMath.ReconciliateEvens);


            printf "%s" (
                "Hello World from F#" 
                |> PigLatin.ToPigLatin)

            System.Console.ReadKey(true) |> ignore 

            0
