namespace FSharpTest 

    module FSharpTest =

        [<EntryPoint>]
        let main _args  =

            printfn "%i" (
                [0..100]
                |> MyMath.DivideByTwoAndFilterEvens
                |> MyMath.ReconciliateEvens);


            printf "%s" (
                "Hello World from F#" 
                |> PigLatin.ToPigLatin)

            0
