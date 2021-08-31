module LoopUsingRecursion

open System
open Xunit
open Xunit.Abstractions
open algorithm.fsharp.SoshnikovBook

type LoopTests (output: ITestOutputHelper) =
    [<Fact>]
    member __.``Self Loop test`` () =
        Recursion.myForLoop 0 5 (fun i -> output.WriteLine(i.ToString()))
        ()

    [<Fact>]
    member __.``Parmeterized Self Loop test`` () =
        Recursion.myForLoopX 0 5 (fun i x -> output.WriteLine((i + x).ToString())) 7
        ()

