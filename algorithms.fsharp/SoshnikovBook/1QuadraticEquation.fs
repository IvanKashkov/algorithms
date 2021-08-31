namespace algorithm.fsharp.SoshnikovBook

open System

module QuadraticEquation =
    type QuadraticRoots = 
        | None 
        | Linear of float
        | Quadratic of float * float

    let CalcDescriminator (a: float, b: float, c: float) =
        let a1 = a in
            let b1 = b in 
                let c1 = c in
                    let D = b1 * b1 - 4.0 * a1 * c1;
        (D)

    let solve1 (a: float, b: float, c: float) =
        let d = CalcDescriminator(a, b, c);
        if (d < 0.) then
            ([||])
        else 
            let x1 = (-b - Math.Sqrt(d)) / (2. * a)
            let x2 = (-b + Math.Sqrt(d)) / (2. * a)
            
            if (x1 = x2) then
                ([|x1|])
            else 
                ([|x1; x2|])

    let solve2 (a: float, b: float, c: float) = 
        let D = b * b - 4.* a * c in
            if (D < 0.) then 
                ([||])
            else if (D > 0.) then
                ([| (-b - Math.Sqrt(D)) / (2. * a); (-b + Math.Sqrt(D)) / (2. * a) |])
            else 
                ([| -b / (2. * a) |])

    let solve3 a b c =
        let D = b * b - 4.* a * c in
        if (D < 0.) then 
            Option.None
        else if (D > 0.) then
            Option.Some([| (-b - Math.Sqrt(D)) / (2. * a); (-b + Math.Sqrt(D)) / (2. * a) |])
        else 
            Option.Some([| -b / (2. *a ) |])

    let solve4 a b c = 
        let D = b * b - 4. * a * c
        if a = 0. then
            if b = 0. then QuadraticRoots.None
            else QuadraticRoots.Linear(-c / b)
        else 
            if D < 0. then None
            else QuadraticRoots.Quadratic ((-b - Math.Sqrt(D)) / (2. * a), (-b+Math.Sqrt(D))/(2. * a))

    let solve5 = fun (a: float, b: float, c: float) -> 
        let D = b * b - 4. * a * c
        if a = 0. then
            if b = 0. then QuadraticRoots.None
            else QuadraticRoots.Linear(-c / b)
        else 
            if D < 0. then QuadraticRoots.None
            else QuadraticRoots.Quadratic ((-b - Math.Sqrt(D)) / (2. * a), (-b + Math.Sqrt(D)) / (2. * a))