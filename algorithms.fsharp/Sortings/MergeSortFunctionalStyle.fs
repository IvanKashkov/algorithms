module algorithms.fsharp.Sortings.MergeSortFunctionalStyle

let rec Merge(a,b) =
    match (a,b) with 
    | ([], []) -> []
    | ([], _) -> b
    | (_, []) -> a
    | (h1::t1, h2::t2) -> 
        if h1 < h2 then h1::Merge(t1, b)
        else h2::Merge(a, t2)

let rec Sort arr =
    match arr with
    | [] -> []
    | h::t when arr.Length = 1 -> arr
    | h::t when arr.Length = 2 -> 
        if h < t.Head then arr
        else t.Head::[h]
    | _ ->
        let half = arr.Length / 2
        let first,second = arr.[0..half-1], arr.[half..arr.Length-1]
        let firstSorted,secondSorted = Sort(first),Sort(second)
        Merge(firstSorted, secondSorted)
        
            


