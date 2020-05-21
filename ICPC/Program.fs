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


   (* let convertIntoWordsList (ogList: string List) = 
        let nwList = []
        let rec createWord  ogList nwList str =                                                         //str::' '.ToString::nwList  createWord
            match ogList with
            |a :: rest -> match a with
                          |' ' -> str::' '.ToString::nwList (createWord rest nwList "")
                          |'.' -> str::'.'.ToString::nwList (createWord rest nwList "")
                          |_ -> str+a.ToString (createWord rest nwList str)
            |_ -> nwList

        convertIntoWordsList ogList nwList ""*)


   






    //let findCommas (lst:string list) =()
        
        

   // let findWord (input:string) =
      //  let lst = Seq.splitInto 
    


    validate input //|> checkCharacters




let rivers (input: string) =
    let validate (str:string) =
        let nList = input.Split ' ' 
        match nList.Length<2 || (Seq.exists (fun elem -> elem = "") nList) || ((Seq.exists (fun (elem:string) -> elem.Length >80) nList)) || ((Seq.exists (fun (elem:string) -> elem.Contains "!") nList )) ||  ((Seq.exists (fun (elem:string) -> elem.Contains ",") nList ))  with
        |true -> None
        |false -> Some nList




        
    validate input



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
