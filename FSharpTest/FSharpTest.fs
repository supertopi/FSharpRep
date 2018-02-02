namespace FSharpTest 

    module FSharpTest =

        [<EntryPoint>]
        let main _args  =

            printfn "%i" (
                [0..100]
                |> MyMath.DivideByTwoAndFilterOdds
                |> MyMath.ReconciliateEvens);


            printfn "%s" (
                "Moi mita kuuluu?" 
                |> PigLatin.pigLatin)

            0
