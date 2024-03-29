use rand::Rng;
use std::cmp::Ordering;
use std::io;

fn main() {
    // --snip--
    println!("Guess the number!!");

    let secret_number = rand::thread_rng().gen_range(1..=100);

    loop{
    println!("Please input your guess.");

    let mut guess = String::new();

    io::stdin()
        .read_line(&mut guess)
        .expect("Failed to read line");
    let  guess:i32  = guess.trim().parse().expect("Input not an integer");


    match guess.cmp(&secret_number) {
        Ordering::Less => println!("Too small!"),
        Ordering::Greater => println!("Too big!"),
        Ordering::Equal => break,
    }}
    println!("YOU WIN!")
}