import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {


        // testing the code
        List<Integer> lista = new JULinkedList();
        System.out.println("List is empty?"+lista.isEmpty());

        lista.add(1);
        lista.add(2);
        lista.add(3);

        lista.add(0,0);
        System.out.println("size of the list:"+lista.size());

        lista.remove(1);
        System.out.println("size of the list:"+lista.size());

        System.out.println("List is empty?"+lista.isEmpty());

        System.out.println("-------String List -------------");

        List<String> lista2 = new JULinkedList();
        System.out.println("List is empty?"+lista2.isEmpty());

        lista2.add("1");
        lista2.add("2");
        lista2.add("3");

        System.out.println("size of the list:"+lista2.size());


        lista2.remove("1");
        System.out.println("the element on index 0 is: "+lista2.get(0));
        System.out.println("list contains 3?"+lista2.contains("3"));
        System.out.println("size of the list:"+lista2.size());
        System.out.println("index of 2:"+lista2.indexOf("2"));

        lista2.clear();
        System.out.println("list is empty? "+lista2.isEmpty());


    }
}