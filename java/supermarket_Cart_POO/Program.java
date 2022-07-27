package study.java.supermarket_Cart_POO;
import java.util.Scanner;
public class Program {
    Boolean exit = true;
    public String input;
    Scanner scanner = new Scanner(System.in);
    Person person;
    Program(){
        start();
    };
    public void start(){
        System.out.println("--------------------Welcome to supermarket--------------------");

        System.out.println("Please say your name");
        person = new Person(scanner.nextLine());
       
    }

    public void ask(){

        System.out.println("Hi "+ person.toString() + ", what do you want to do? [Exit:E/Add to cart:A/See cart:S/Remove item:R]");
        String input = scanner.nextLine().trim();
        while(!(input.equalsIgnoreCase("E") || input.equalsIgnoreCase("R")|| input.equalsIgnoreCase("S")|| input.equalsIgnoreCase("A") ) ){
            System.out.println("Please a enter operation. [Exit:E/Add to cart:A /See cart:S/Remove item:R ]");
            input = scanner.nextLine().trim();
        }
    this.input = input;

    }

    public void Exit(){
        System.out.println("----------thanks for test my progran--------");
        this.exit = false;
    }
    public void See(){
        if(person.supermarket_cart.size() <= 0){
            System.out.println("cart is empty");
            
        }else{
            System.out.print("you have :");
            for (String i : person.supermarket_cart) {
                System.out.print(i + " ");
            }
            System.out.print("in your cart");
        }
        ask();
    }
    public void Add(){
        System.out.println("what do you want to put in your cart? it can be anything");
        String item = scanner.nextLine();
        person.supermarket_cart.add(item);
        ask();
    }
    public void remove(){
        System.out.println("what do you want to remove from your cart?");
        String item = scanner.nextLine();
        if(person.supermarket_cart.contains(item)){
        person.supermarket_cart.remove(item);}else{
            System.out.println("you entered a item that doesnt is at the cart"); 
        }
        ask();
    }
}