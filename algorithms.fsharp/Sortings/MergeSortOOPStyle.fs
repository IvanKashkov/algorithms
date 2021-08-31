module algorithms.fsharp.Sortings.MergeSortOOPStyle

let Merge(a: int[], b: int[]): int[] =
    let mutable i,j,k = 0,0,0
    let result: int[] = [|0..(a.Length+b.Length-1)|]
    // 1. go through 2 array and form the result array.
    while k < result.Length && i < a.Length && j < b.Length do
        if a.[i] < b.[j] then
            result.[k] <- a.[i]
            i <- i + 1
        else 
            result.[k] <- b.[j]
            j <- j + 1
        k <- k + 1

    // 2. put all that is left inside the result array (only one item can be not empty)
    while i < a.Length do 
        result.[k] <- a.[i]
        i <- i + 1
        k <- k + 1

    while j < b.Length do
        result.[k] <- b.[j]
        j <- j + 1
        k <- k + 1

    (result)

let rec Sort (arr: int[]): int[] =
    match arr.Length with
    | 0 -> (arr)
    | 1 -> (arr)
    | 2 -> 
        if (arr.[0] > arr.[1]) then
            core.Swap(arr, 0, 1)
        (arr)
    | _ ->
        let half = arr.Length / 2
        let first,second = arr.[0..half-1], arr.[half..arr.Length-1]
        let firstSorted,secondSorted = Sort(first), Sort(second)
        (Merge(firstSorted, secondSorted))
        
            


