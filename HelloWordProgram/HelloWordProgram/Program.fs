﻿// Learn more about F# at http://fsharp.org

open System
open HelloWorldNTimes
[<EntryPoint>]
let main argv =
    Ntimes
    printfn "Hello World from F#!"
    0 // return an integer exit code
