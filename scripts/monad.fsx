// Monad（モナド）の簡単な例
// ここではOption型を利用することで
// 必ずOption型という箱に入れたデータ伝搬を行う
// 仕組みを作ることができる。

// ------------------------------------------
// この演算子は次の関数を適用する場合、入力がNoneなら
// 何もせずにNoneを返す。
// Some xならfを適用する
// すなわちデータの存在確認フローをここに押し込める
// ------------------------------------------
let (>>=) x f = Option.bind f x

// ------------------------------------------
// 入力は普通だが、戻り値を必ずOption型にする設計
// 入力チェックは一々しなくて良い。
// コアロジックのみ専念できし、ロジック状の例外のみ
// Noneで返せば良い
// ------------------------------------------
let function1 x  =
    match x with
    | 1 -> Some "One"
    | 2 -> Some "Two"
    | 3 -> Some "Three"
    | _ -> None

let function2 x =
    match x  with
    | "One" -> Some "The one!"
    | _     -> None

// 「データ」を主語に、「処理」を述語として記述する
// 途中結果が存在しない場合は何もせずに通過する
// 1という「データ」をfunction1, function2という順に処理していく
1 |> function1 >>= function2
// 2という「データ」をfunction1, function2という順に処理していく
2 |> function1 >>= function2
// 4という「データ」をfunction1, function2という順に処理していく
4 |> function1 >>= function2 // <fun:it@xx-xx>という形式でしか出ない

// うまい方法がないか
let (<~) d workname = 
    match d with
    | Some x -> 
        printfn "%s is Start with arg %A" workname x
    | None   ->
        printfn "前処理でNoneが返されていますので%sを飛ばします" workname
    d

// メイン処理
Some 2 
<~ "処理1"
>>= function1 
<~ "処理2"
>>= function2 
