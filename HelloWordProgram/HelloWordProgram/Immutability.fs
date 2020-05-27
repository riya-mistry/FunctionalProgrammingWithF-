module Immutability
    let function1 = 
        let number = 2
        let mutable otherNumber = 3
        printfn "'otherNumber' is %d" otherNumber
        otherNumber <- otherNumber + 1
        printfn "'otherNumber' changed to be %d" otherNumber



