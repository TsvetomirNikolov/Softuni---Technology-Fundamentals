import java.util.Scanner;

// Test with:
// 10 5 9 8 1 2 6 11 4 8 9 3 

// Result:
// 6 11 4 8 9

public class Task3f_LargestSumOfKSubsequence{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int numberCount = sc.nextInt();
        int[] numbers = new int[numberCount];
        int k = sc.nextInt();
        
        int currentSum = 0;
        int largestSum = Integer.MIN_VALUE;
        int largestSumIdx = 0;
        
        for(int i = 0; i < numberCount; i++){
            numbers[i] = sc.nextInt();
            
            currentSum += numbers[i];
            
            if(i >= k){
                currentSum -= numbers[i - k];
            
                if(largestSum < currentSum) {
                    largestSum = currentSum;
                    largestSumIdx = i - k + 1;
                }
            }
        }
        
        for(int i = 0; i < k; i++){
            System.out.print(numbers[i + largestSumIdx] + " ");
        }
        
        System.out.println();
    }
}