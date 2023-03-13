import java.util.ArrayList;
import java.util.HashMap;

public class EnoughIsEnough {
    public static int[] deleteNth(int[] elements, int maxOccurrences) {
		//Code here ;)
		if (elements.length == 0 || maxOccurrences <= 0){
      return elements;
    }

    HashMap<Integer,Integer> counters = new HashMap();
    
    ArrayList<Integer> list = new ArrayList<>();

    for (int num : elements) {
        Integer value = counters.getOrDefault(num, 0);
            counters.put(value, value)
        if (value > maxOccurrences) { 
            continue;
        }
            
        list.add(num);
        counters.put(num, value + 1);
    }
    int[] array = list.stream().mapToInt(Integer::intValue).toArray();
    System.out.println(array);
    return array;

	}
}

