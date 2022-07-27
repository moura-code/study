package study.java.supermarket_Cart_POO;

public class Main {

    public static void main(String[] args) {
        Program program = new Program();

        program.ask();

        while(program.exit){
        switch(program.input.toUpperCase()){
            case "E": program.Exit();
            break;
            case "S": program.See();
            break;
            case "A":program.Add();
            break;
            case "R":program.remove();
        }
        
    }}
   
}
