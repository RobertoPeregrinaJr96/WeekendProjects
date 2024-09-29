//  The io library comes from the standard library, known as std:
use std::io;


// "fn" declares a new function
// "main" declares the entry point of a program

fn main() {
    // "println!" is not a method call but is a macro that is standard in Rust

    // prints a statement to the console
    println!("Guess the number!");
    // prints a statement to the console
    println!("Please input your guess.");
    // assign the inital variable "mut guess" with a string datatype  
    // the "let" keyword initialize the variable as a mutable datatype
    // we bind a value with the "=" 
    // the value of our initialized variable will have a new String datatype that is growable but invoking the "String::new()" method
    // the "::" syntax in "String::new()" means that "new()" is a associated function of "String" so in other words a new empty string datatype locked value  
    let mut guess = String::new();

    io::stdin()
        .read_line(&mut guess)
        .expect("Failed to read line");

    println!("You guessed: {}", guess);
}