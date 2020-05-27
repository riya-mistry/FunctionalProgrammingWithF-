module PipelinesAndCompositions
    let square x = x*x
    let addOne x = x + 1
    let isOdd x = x % 2 <> 0 
    let numbers = [1;2;3;4;5;6]
    let squareOddValuesAndAddOne values = 
        let odds = List.filter isOdd values
        let squares = List.map square odds
        let result = List.map addOne squares
        result
    printfn "processing %A through 'squareOddValuesAndAddOne' produces: %A" numbers (squareOddValuesAndAddOne numbers)

    let squareOddValuesAndAddOneNested values = 
        List.map addOne (List.map square (List.filter isOdd values))
    let squareOddValuesAndAddOnePipeline values =
        values |> List.filter isOdd |> List.map square |> List.map addOne
    let squareOddValuesAndAddOneShorterPipeline values =
        values |> List.filter isOdd |> List.map (fun x-> x |> square |> addOne)
