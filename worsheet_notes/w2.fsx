// let x = 2
// let name = "Brown"
// old syntax
// printfn "x is %d, name is %s" x name
// //string interpolation (no type checking of x, name)
// printfn $"x is {x}, name is {name}"
// // string interpolation with format specifier
// printfn $"x is {x}, name is %s{name}"

////Question 2:
// type Person = {
//     Age: int;
//     Firstname:string;
//     Lastname: string;
//     Email: string
// }
// let Shaanuka = {
//     Age = 21;
//     Firstname = "Shan";
//     Lastname =   "Bazooka";
//     Email = "sdfsdf@sdfsd.com"
// }

// let newEmail addr person = 
//  let new_person = {person with Email = addr}
//  new_person

// let n = newEmail "asdsdfsdf" Shaanuka

////Q5
// let lst1 = [1 ; -1 ; 6 ; 0 ; -3]
// let lst2 = [2 ; 5 ; 65 ; 3]

// let firstNegative = List.find ((>) 0) // Why is this not <?

// let res1 = firstNegative lst1
// let res2 = firstNegative lst2
// printfn "%A" res2

//Q7
// let findfirst list =
//     let firstpos = List.tryFind ((<) 0)
//     let firstneg = List.tryFind ((>) 0)
//     firstneg list|> Option.orElse (firstpos list) |> Option.defaultValue 0

// let out = findfirst [1;0;-1]
// printf "%A" out

// let lst = [1;2;3;4]

// match lst with
// |hd::tail -> printfn "%A" hd
// |[] -> ()