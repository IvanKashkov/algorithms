module BinaryTreeTests

open System
open Xunit
open Xunit.Abstractions
open algorithms.fsharp.structures

type BinaryTreeTest (output: ITestOutputHelper) =
    [<Fact>]
    member __.``Insert many items into empty tree`` () =
        let tree = BinaryTree.insertMany [5; 7; 12; 3; 2; 9] BinaryTree.Empty
        let treeFromList = BinaryTree.buildTreeFromList [7; 12; 3; 2; 9]
        ()

    [<Fact>]
    member __.``Insert item into existing tree`` () =
        let tree = BinaryTree.insertMany [7; 5; 9; 3;] BinaryTree.Empty
        let tree2 = BinaryTree.insertOne 1 tree
        Assert.NotEqual(tree, tree2);
        ()

