//Case Math
//Basic functions
namespace FSharpTest

module MyMath =

    let MultiplyByTwo a = a * 2

    let DivideByTwo a =  a / 2

    let IsEven a = (a % 2) = 0

    let IsOdd a =
         a |> IsEven |> not
           

    //Lists 
    let DivideByTwoAndFilterEvens numbers =
        numbers
        |> List.map DivideByTwo
        |> List.filter IsOdd

    
    //Pattern Match
    let ReconciliateEvens numbers =
        match List.tryFind IsOdd numbers with
        | Some value -> value
        | None -> -1


