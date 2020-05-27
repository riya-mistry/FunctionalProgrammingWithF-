module IntergerAndNumbers
    let IntAndNums = 
        let sampleInteger = 176
        let sampleDouble = 4.1
        let sampleInteger2 = (sampleInteger/4 + 5 - 7 ) * 4 + int sampleDouble
        let sampleNumbers = [0..99]
        let sampleTableOfSquares = [for i in 0..99 -> (i,i*i)]
        printfn "The table of squares from 0 to 99 is:\n%A" sampleTableOfSquares


