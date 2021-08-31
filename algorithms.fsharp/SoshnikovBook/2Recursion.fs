namespace algorithm.fsharp.SoshnikovBook

module Recursion =
    // For cycle as recursive function
    let rec myForLoop a b f =
        f a
        if a < b then
            myForLoop (a + 1) b f

    let rec myForLoopX a b f x =
        f a x
        if a < b then
            myForLoopX (a + 1) b f x
            
            
    
    