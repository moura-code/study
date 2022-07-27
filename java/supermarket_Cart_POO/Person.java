package study.java.supermarket_Cart_POO;

import java.util.ArrayList;

public class Person {
     String name;

     ArrayList<String> supermarket_cart= new ArrayList<String>();
     Person(String name){
        this.name = name;  
    }
    public void addToCart(String product){
        this.supermarket_cart.add(product);
    }
    
    public String toString(){
        return this.name ;
    }
    

}
