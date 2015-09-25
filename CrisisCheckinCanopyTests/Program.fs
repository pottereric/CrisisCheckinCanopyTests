//these are similar to C# using statements
open canopy
open runner
open System

//start an instance of the firefox browser
start firefox
//start chrome
//start ie

pin canopy.types.direction.Left
//pin canopy.types.direction.Right 
//pin canopy.types.direction.FullScreen

//go to url
url "http://localhost:2077/Account/Login"

// enter the user name
"#UserNameOrEmail" << "Frank"

// enter the password
"#Password" << "notThePassword"

// Click the login button
click "input.btn-success"

//this is how you define a test
"The invalid username message is displayed" &&& fun _ ->

    // Validate the error message
    "div.validation-summary-errors" == "The username/email or password provided is incorrect."

"The password is blank" &&& fun _ ->
    // Validate the blank password input element
    
    "#Password" == ""
//    "#Password" == "MakeThisFail"



//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()