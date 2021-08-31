namespace algorithms.fsharp.recursion

module factorial =

let rec fRec n =
    match n with
    | 1 -> 1 
    | _ -> n * fRec(n - 1)

let fTailRecursion n =
    let rec inner m acc =
        match m with
           | 1 -> acc 
           | _ -> inner (m-1) (acc * m)
    inner n 1

   



