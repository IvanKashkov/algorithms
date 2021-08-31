namespace algorithms.fsharp.structures

module BinaryTree = 
    type 't Tree =
        | Empty
        | Node of 't * 't Tree * 't Tree

    let buildTreeExample =
        Tree.Node(5, 
            Tree.Node(3, Tree.Node(1, Empty, Empty), Tree.Node(4, Empty, Empty)), 
            Tree.Node(9, Tree.Node(7, Empty, Empty), Tree.Node(11, Empty, Empty)))

    let rec insertOne value node =
        match node with
        | Empty -> Node(value, Empty, Empty)
        | Node(x, L, R) -> if x = value then node
                           else if value < x then Node(x, insertOne value L, R)
                           else Node(x, L, insertOne value R)

    let insertMany list node =
        List.fold (fun acc elem -> insertOne elem acc) node list

    let buildTreeFromList list =
        List.fold (fun acc elem -> insertOne elem acc) Empty list

    let rec findNode value node =
        match node with
        | Empty -> Empty
        | Node(x, L, R) -> if x = value then node  
                           else if value < x then findNode value L
                           else findNode value R

    let deleteNode value node =
        ()

    let balanceTree root = 
        ()
