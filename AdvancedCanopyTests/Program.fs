//these are similar to C# using statements
open canopy
open runner
open System

//start an instance of the firefox browser
start firefox


//go to url
url "http://localhost:2077/Account/Login"


//this is how you define a test
"The title is correct." &&& fun _ ->

    // Validate the error message
    title() |> is "Crisis Checkin"


//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()
