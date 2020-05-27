module Arrays

    let array1 = [| |]
    let array2 = [|"Hello"; "World";"and"; "hello" ; "World" ; "again" |]
    let array3 = [| 1..1000|]
    let array4 = [|
        for words in array2 do
            if words.Contains('l') then
            yield words|]

