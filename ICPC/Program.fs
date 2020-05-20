module ICPC
open System

let commaSprinkler input =

    
    (*let checkCharacters (str: string) =
        let k = Seq.toList str
        match k with
        |_ -> None
        |_ -> None*)




    
    let validate (str:string) =
        match (str.Length < 2) with
        |true -> None
        |false -> let k = Seq.toList str
                  match List.exists (fun c -> not (Char.IsLower c) || not(c = ' ') || not(c = '.') || not(c = '.') ) k   with
                  |true -> None
                  |_ -> Some k

        
        
    


    validate input //|> checkCharacters








let rivers input =
    failwith "Not implemented"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
