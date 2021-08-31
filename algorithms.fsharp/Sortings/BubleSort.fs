module algorithms.fsharp.Sortings.BubleSort

open algorithms.fsharp.Sortings.core

let moveElelement (arr: int[], i, ordering: SortDirection) = 
    let compareFunc = match ordering with 
        | SortDirection.Ascending -> (>)
        | SortDirection.Descending -> (<)
    for j in 0..arr.Length - i - 2 do
        if (compareFunc arr.[j] arr.[j+1]) then
            core.Swap (arr, j, j+1)

let sort (arr: int[], ordering: SortDirection) =
    for i in 0..arr.Length-1 do
        moveElelement(arr, i, ordering)
    
