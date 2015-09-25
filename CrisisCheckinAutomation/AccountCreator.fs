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
    "#PhoneNumber" << "123.456.7890"
    "#Email" << firstName + "." + lastName + "@mailinator.com"
    "#txt_userName" << firstName + "." + lastName

    "#txt_password" << "monkey"
    "#ConfirmPassword" << "monkey"
//    "#Cluster" << "Agriculture Cluster"
    click "Create new account"
