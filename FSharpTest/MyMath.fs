//Case Math
//Basic functions
namespace FSharpTest

module MyMath =

    let MultiplyByTwo a = a * 2

    let DivideByTwo a =  a / 2

    let IsEven a = (a % 2) = 0

    let IsOdd a =
         a |> IsEven |> not


    let DivideByTwoAndFilterEvens numbers =
        numbers
        |> List.map DivideByTwo
        |> List.filter IsOdd


    let ReconciliateEvens numbers =
        match List.tryFind IsEven numbers with
        | Some _ -> true
        | None -> false


