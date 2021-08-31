module algorithms.fsharp.Sortings.QSort 

let rec Sort (arr, direction: core.SortDirection) = 
    match arr with
        | [] -> []
        | h::t ->
            let l = core.getLeftFilteringPredicate(direction, h)
            let r = core.getRightFilteringPredicate(direction, h)

            Sort(List.filter (l) t, direction) @ [h] @ 
            Sort(List.filter (r) t, direction)

let rec Sort2 (arr, direction: core.SortDirection) = 
    match arr with
        | [] -> []
        | h::t -> 
            let p = core.getPartitioningPredicate(direction, h)
            let (left, right) = List.partition p t
            Sort2(left, direction) @ [h] @ Sort2(right, direction)