//these are similar to C# using statements
open canopy
open runner
open System

//start an instance of the firefox browser
start firefox
AccountCreator.CreateAccount "Frank" "Stallone"


//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()