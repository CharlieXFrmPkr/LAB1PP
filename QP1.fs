let a exponent value =
    pown value exponent

// Partially apply the function to create specialized functions
let sq = a 2
let cu = a 3

// Test the partially applied functions
let sqRes1 = sq 4 
let sqRes2 = sq 5 

let cuRes1 = cu 2  
let cuRes2 = cu 3  

printfn "Square of 4 is %d" sqRes1
printfn "Square of 5 is %d" sqRes2
printfn "Cube of 2 is %d" cuRes1
printfn "Cube of 3 is %d" cuRes2