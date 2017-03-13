import java.util.Scanner;

// Test with:
// 10 9 8 1 2 6 11 4 8 9 3

// Result:
// 1 2 6 11

public class Task3e_LongestIncreasingSubsequence{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int numberCount = sc.nextInt();
        int[] numbers = new int[numberCount];
        
        numbers[0] = sc.nextInt();
        
        int currentStartIdx = 0;
        int currentLength = 1;
        int longestSeqIdx = 0;
        int longestLength = 1;
        
        for(int i = 1; i < numberCount; i++){
            numbers[i] = sc.nextInt();
        
            if(numbers[i] > numbers[i - 1]) {
                currentLength++;
            } else{
                if(longestLength < currentLength) {
                    longestSeqIdx = currentStartIdx;
                    longestLength = currentLength;
                }
                
                currentStartIdx = i;
                currentLength = 1;
            }
        }
        
        if(longestLength < currentLength) {
            longestSeqIdx = currentStartIdx;
            longestLength = currentLength;
        }
       
        for(int i = 0; i < longestLength; i++){
            System.out.print(numbers[longestSeqIdx + i] + " ");
        }
    }
}