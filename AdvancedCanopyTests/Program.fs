//these are similar to C# using statements
open canopy
open runner
open System

//start an instance of the firefox browser
//start firefox
start chrome


//go to url
url "http://localhost:2077/Account/Login"


//this is how you define a test
"The title is correct." &&& fun _ ->

    // Validate the error message
    title() |> is "Crisis Checkin"



"Make sure the user can login" &&& fun _ ->
    "input#UserName" << "Anthony.Rizzo"
    "input#Password" << "monkey"
    click "input.btn-success"
    displayed "div#loginStatus"
    screenshot @"C:\temp" "MainPage" |> ignore

"Check how it looks on an iPhone" &&& fun _ ->
    resize screenSizes.iPhone5



//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()
