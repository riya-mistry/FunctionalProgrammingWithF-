module StructToTuple

    let sampleStruct = struct(1,2)
    let convertFromStructTuple (struct(a,b)) = (a,b)
    let convertToStructTuple (a,b) = struct(a,b)
    printfn "Struct Tuple: %A\nReference tuple made from the Struct Tuple: %A" sampleStruct (sampleStruct |> convertFromStructTuple)