namespace FSharpTest

module Worker =

    let DoStuffAsync i =
        async {
            do! Async.Sleep i
        } 
    
    let DoStuffInteropAsync i =
        async {
            do! Async.Sleep i
        } |> Async.StartAsTask