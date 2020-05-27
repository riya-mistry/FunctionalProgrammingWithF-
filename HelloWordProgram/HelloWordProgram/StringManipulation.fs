module StringManipulation
    let stringFunc1 = 
        let string1 = "Hello"
        let string2 = "World"
        let string3 = @"C:\Program Files\"
        let string4 = """The computer said "hello world" when I told it to!"""
        let helloworld = string1 + " "+ string2
        printfn "%s" helloworld
        let substring = helloworld.[0..6]
        printfn "%s" substring
