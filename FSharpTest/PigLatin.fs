// Case Strings
namespace FSharpTest 

module PigLatin =
    open System
    
    let vowels =
        let lowerCase = ['a';'e';'i';'o';'u']
        lowerCase 
        |> List.append ( lowerCase  |> List.map Char.ToUpper )

    let private wordToPigLatin (word :string) =

        let isVowel c = 
            List.contains c vowels
        
        match isVowel word.[0] with
            | true -> word + "yay"
            | false -> word.[1..] + string(word.[0]) + "ay"


    let pigLatin (sentence : string) =
        sentence.Split [|' '|]
        |> Array.fold ( fun total nextWord -> total + wordToPigLatin nextWord + " "  ) ""


