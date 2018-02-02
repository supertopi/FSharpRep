//Case Math
//Basic functions
namespace FSharpTest

module MyMath =

    let MultiplyByTwo a =
        a * 2

    let DivideByTwo a =
        a / 2

    let IsEven a =
        (a % 2) = 0

    let IsOdd a =
         a |> IsEven 
           |> not

    //Lists 
    let DivideByTwoAndFilterOdds l =
        l
        |> List.map DivideByTwo
        |> List.filter IsOdd

    
    //Pattern Match
    let ReconciliateEvens l =
        match List.tryFind IsOdd l with
        | Some value -> value
        | None -> -1


