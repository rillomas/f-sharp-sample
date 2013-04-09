//let add x y = x + y

let isSubString (s1: string) (s2: string) = 
    s1.Contains(s2)

let isRotatedString (answer: string) (input: string) = 
    if answer.Length <> input.Length then
        false
    else
        let concated = input + input
        isSubString concated answer

//[<EntryPoint>]
//let main args =
//    let res = add 2 2
//    printfn "Arguments passed to function : %A" args
//    printfn "result: %d"  res
//    

let result = isRotatedString "waterbottle" "erbottlewat"
//let result = isRotatedString "waterbottle" "waterbottled"

if result then
    printfn "OK!"
else
    printfn "Not ok..."
