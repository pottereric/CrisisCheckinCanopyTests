//these are similar to C# using statements
open canopy
open runner
open System

//start an instance of the firefox browser
start firefox
//AccountCreator.CreateAccount "Anthony" "Rizzo"
AccountCreator.CreateAccount "Javier" "Baez"
//AccountCreator.CreateAccount "Starlin" "Castro"
//AccountCreator.CreateAccount "Kris" "Bryant"
//AccountCreator.CreateAccount "Addison" "Russell"
//AccountCreator.CreateAccount "Kyle" "Schwarber"


//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()