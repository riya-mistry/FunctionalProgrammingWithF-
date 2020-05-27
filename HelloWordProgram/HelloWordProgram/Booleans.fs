module Booleans
    let bool = 
        let a = true
        let b = false
        let c = not a  && (b || false)
        printfn "the expression 'not a  && (b || false)' is %b " c

