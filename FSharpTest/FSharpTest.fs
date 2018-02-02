
#import "Math.fsx"
#import "PigLatin.fsx"

[0..100]
        |> MyMath.DivideByTwoAndFilterOdds
        |> MyMath.ReconciliateEvens

PigLatin.pigLatin "Moi kaikki miten menee?"