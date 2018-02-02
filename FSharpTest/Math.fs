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
    let DivideByTwoAndFilterOdds lista =
        lista
        |> List.map DivideByTwo
        |> List.filter IsOdd

    //Pattern Match
    let ReconciliateEvens list1d =
        match List.tryFind IsOdd list1d with
        | Some value ->  value
        | None -> -1


