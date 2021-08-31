module Tests

open System
open Xunit
open algorithms.fsharp.Sortings
open Xunit.Abstractions


type SortingTests (output: ITestOutputHelper) =
    let CheckIfArraySorted(arr: int[]) :bool =
        let mutable result = true;

        for i in [0..arr.Length-2] do
            if arr.[i] > arr.[i+1] then
                result <- false
        result

    let CheckIfListSorted (arr, direction: core.SortDirection) =
        match arr with
        | [] -> true
        | arr -> List.compareWith (core.defaultComparer) arr ((match direction with | core.Ascending -> List.sort | core.Descending -> List.sortDescending) arr) = 0


    [<Fact>]
    member __.``Merge sort`` () =

        let arr1 = [|17; 3; 6; 1; 13; 9; 33|]
        let arr1Sorted = MergeSortOOPStyle.Sort(arr1)
        output.WriteLine(sprintf "%A" arr1Sorted)
        Assert.True(CheckIfArraySorted(arr1Sorted))

    [<Fact>]
    member __.``Merge sort functional`` () =

        let arr1 = [17; 3; 6; 1; 13; 9; 33; 115; 89; 50; 0; 75; 24]
        let arr1Sorted = MergeSortFunctionalStyle.Sort(arr1)
        output.WriteLine(sprintf "%A" arr1Sorted)
        Assert.True(CheckIfListSorted(arr1Sorted, core.Ascending))

    [<Fact>]
    member __. ``QSort sort version 1`` () =
    
        let arr1 = [17; 3; 6; 1; 13; 132; 156; 66; 7; 9; 33]
        let arr1Sorted = QSort.Sort(arr1, core.Ascending)
        output.WriteLine(sprintf "%A" arr1Sorted)
        Assert.True(CheckIfListSorted(arr1Sorted, core.Ascending))

    [<Fact>]
    member __. ``QSort sort version 2`` () =
    
        let arr1 = [17; 3; 6; 345; 21; 4; 1; 13; 9; 33]
        let arr1Sorted = QSort.Sort2(arr1, core.Descending)
    
        output.WriteLine(sprintf "%A" arr1Sorted)
        Assert.True(CheckIfListSorted(arr1Sorted, core.Descending))