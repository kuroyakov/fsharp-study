// まずは直接の命令文
printfn "hello, fable"

// 次は変数束縛とその値の出力
let x = 10
printfn "x=%A" x

// 関数
let f x y = x + y
f 10 20 |> printfn "x+y=%A" 

// 部分適用
let add10 = f 10
add10 50 |> printfn "50 add 10 = %A"

// 合成
let negiate x = -x
20 |> (add10>>negiate>>string) |> printfn "20 add 10 and negiate=%A"

// 配列
[1..50] |> List.map add10 |> printfn "%A"

// 別ファイルから
#load "module.fsx"
MyModule.square 50 |> printfn "50^2 = %A"