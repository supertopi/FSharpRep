//Case Math
//Basic functions
namespace FSharpTest

module MyMath =

    let MultiplyByTwo a = a * 2

    let DivideByTwo a =   a / 2

    let IsEven a = (a % 2) = 0

    let IsOdd a = a |> IsEven |> not


    let MultiplyByTwoAndPreserveOdds numbers =
        numbers
        |> List.map MultiplyByTwo
        |> List.filter IsOdd


    let HasEvens numbers =
        match List.tryFind IsEven numbers with
        | Some _ -> true
        | None -> false
