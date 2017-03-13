import java.util.Arrays;
import java.util.Scanner;

// Test with
// 12 4 7 -3 -11 2 9 -4 5 6 -8 0 5

// Result:
// 2 9 -4 5 6

public class Task3g_LargestSumSubsequence{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        int[] arr = Arrays.stream(sc.nextLine().split("\\s")).mapToInt(Integer::valueOf).toArray();
        int numberCount = sc.nextInt();
        int[] numbers = new int[numberCount];
        long system = System.nanoTime();
        numbers[0] = sc.nextInt();
        int currentMax = numbers[0];
        int globalMax = numbers[0];
        int currentStart = 0;
        int bestSumIdxStart = 0;
        int bestSumIdxEnd = 0;
        
        for(int i = 1; i < numberCount; i++){
            numbers[i] = sc.nextInt();
         
            currentMax += numbers[i];

            if (currentMax < 0){
                currentStart = i + 1;
                currentMax = 0;
            }

            if (globalMax < currentMax) {
                globalMax = currentMax;
                bestSumIdxStart = currentStart;
                bestSumIdxEnd = i;
            }
        }
        
        for(int i = bestSumIdxStart; i <= bestSumIdxEnd ; i++){
            System.out.print(numbers[i] + " ");
        }
        
        System.out.println();
    }
}