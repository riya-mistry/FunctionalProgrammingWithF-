// Learn more about F# at http://fsharp.org

open System
open HelloWorldNTimes
open Greetings
open Immutability
open BasicFunctions
open IntergerAndNumbers
open StringManipulation
[<EntryPoint>]
let main argv =
    let names = ["Riya"; "Maliha"; "Trupti"]
    names
    |> List.map getGreeting
    |> List.iter (fun greeting -> printfn "%s" greeting)
    Ntimes
    printfn "Hello World from F#!"
    let  ans = sampleFunction1 3
    printfn "%d" ans
    function1
    IntAndNums
    stringFunc1
    0 // return an integer exit code
