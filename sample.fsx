let x = 10
let y = 5.0
let s = "hoge"
let a = [1;2;3]
let b= [|1;2;3|]
let f n =
    if n % 2 = 0 then
        "Even"
    else
        "Odd"

type ClassA() =
    member this.X = "F#"

