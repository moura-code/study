import java.util.Arrays;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
public class SumOfK {
    
    public static Integer chooseBestSum(int t, int k, List<Integer> ls) {
        List<List<Integer>> combinations = getCombinations(ls, k);
      List<List<Integer>> comb = combinations.stream().filter(n -> n.stream().mapToInt(Integer::intValue).sum() <= d).map(n -> (List<Integer>)n)
        .collect(Collectors.toList());
      System.out.println(comb);
      return comb.get(comb.size()-1).stream().mapToInt(Integer::intValue).sum();
    }
  public static List<List<Integer>> getCombinations(List<Integer> nums, int n) {
        List<List<Integer>> combinations = new ArrayList<>();
        getCombinationsHelper(nums, n, new ArrayList<>(), combinations);
        return combinations;
    }

    private static void getCombinationsHelper(List<Integer> nums, int n, List<Integer> current, List<List<Integer>> combinations) {
        if (current.size() == n) {
            combinations.add(new ArrayList<>(current));
            return;
        }

        for (int i = 0; i < nums.size(); i++) {
            current.add(nums.get(i));
            getCombinationsHelper(nums.subList(i + 1, nums.size()), n, current, combinations);
            current.remove(current.size() - 1);
        }
    }}