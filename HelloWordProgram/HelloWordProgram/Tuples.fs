module Tuples
    let tuplefun1 = 
        let tuple1 = (1,2,3)
        let swapElements (a,b) = (b,a)
        printfn "The result of swapping (1, 2) is %A" (swapElements (1,2))
        let tuple2 = (1, "fred", 3.1415)
        printfn "tuple1: %A\ttuple2: %A" tuple1 tuple2

