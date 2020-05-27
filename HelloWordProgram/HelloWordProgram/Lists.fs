module Lists

    let List1 = []
    let List2 = [1;2;3]
    let List3 = [
        1
        2
        3
     ]
    let numList = [1..100]
    let blackSquares = 
        [for i in 0..7 do
            for j in 0..7 do
                if (i+j) % 2 =1 then
                    yield (i,j) ]
    let squares = 
        numList |> List.map (fun x-> x*x)
    let sumOfSquares = 
        numList |> List.filter (fun x -> x % 3 = 0 ) |> List.sumBy (fun x-> x * x)

    printfn "The sum of the squares of numbers up to 1000 that are divisible by 3 is: %d" sumOfSquares
        