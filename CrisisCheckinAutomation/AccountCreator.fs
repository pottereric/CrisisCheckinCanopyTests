module AccountCreator

// If there is only one module in the file, you can define it like this

open canopy
open runner
open System

let CreateAccount firstName lastName =
    url "http://localhost:2077/Account/Login"
    click "Register"

    "#FirstName" << firstName
    "#LastName" << lastName
    "#Email" << firstName + "." + lastName + "@mailinator.com"
