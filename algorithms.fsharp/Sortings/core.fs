module algorithms.fsharp.Sortings.core

let Swap (arr: int[], i, j) = 
    let temp = arr.[j]
    arr.[j] <- arr.[i]
    arr.[i] <- temp

type SortDirection = Ascending | Descending

let defaultComparer elem1 elem2 =
    if elem1 > elem2 then 1 
    elif elem1 < elem2 then -1
    else 0

let getLeftFilteringPredicate(direction, value) = 
    match direction with
    | SortDirection.Ascending -> (>) value
    | SortDirection.Descending -> (<=) value

let getRightFilteringPredicate(direction, value) =
    match direction with
    | SortDirection.Ascending -> (<=) value
    | SortDirection.Descending -> (>) value

let getPartitioningPredicate(direction, value) = 
    match direction with
    | SortDirection.Ascending -> (>) value
    | SortDirection.Descending -> (<=) value
