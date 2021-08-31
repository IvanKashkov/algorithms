module FinN

// Define function that elevates (rases to a power) function f in n 
// f(f(f(x)))
let rec rpt n f x =
    if (n = 0) then x
    else f (rpt (n - 1) f x)

// f(f(f(x))) using F# internals
let rec rpt2 n f =
    if n = 0 then fun x -> x // if n == 0 then it's just functions that returns x value itself
    else f >> (rpt2 (n-1) f) // 