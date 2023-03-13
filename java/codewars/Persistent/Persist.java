public class Persist {
    public static int persistence(long n) {
        if(n < 10){ return 0;}
        Integer times = 1;
        long total = n;
        Integer temp;
        while (true){
          temp = 1;
          for(String num: Long.toString(total).split("") ){
            temp = temp * Integer.parseInt(num);
          }
          System.out.println(total);
          total = temp;

          if(total < 10){
            break;
        }
        times+=1;
      }
        
        return times;
        }
}
