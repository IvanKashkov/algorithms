namespace algorithms.fsharp.recursion

open System.Collections.Generic

module Fibonacci = 
    let rec fib n = 
        match n with
            | 0 -> 1
            | 1 -> 1
            | _ -> fib(n - 1) + fib(n - 2)

    let rec fibMemozed  = 
        // _ - wildcard character
        let cache = Dictionary<_,_>();
        let rec fibInner n = match n with
            | 0 -> 1
            | 1 -> 1
            | _ -> if cache.ContainsKey(n) then
                        cache.[n]
                   else
                        cache.[n] <- fibInner(n - 1) + fibInner(n - 2);
                        cache.[n]
        fibInner

    let rec fibTailRecursion n = 
        let rec fibInner prev1 prev2 i n =
            match i with
                | j when j = n -> prev1 + prev2
                | _ -> fibInner prev2 (prev1 + prev2) (i + 1) n
        match n with
            | 0 -> 1
            | 1 -> 1
            | _ -> fibInner 1 1 2 n

    let rec fibTailRecursion2 n = 
        let rec fibInner prev1 prev2 i n = 
            if i < n then  
                fibInner prev2 (prev1 + prev2) (i + 1) n
            else 
                prev1 + prev2
        match n with
            | 0 -> 1
            | 1 -> 1
            | _ -> fibInner 1 1 2 n

        