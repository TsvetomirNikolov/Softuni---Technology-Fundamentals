import java.util.Scanner;

// Test with:
// 12 4 -11 -8 -4 -3 0 2 4 5 5 6 7 9 4
// Result:
// 6

// Test with:
// 9 11 1 2 3 4 5 6 7 8 9
// Result
// NO

public class Task3i_FindKInSorted{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
    
        int numberCount = sc.nextInt();
        int[] numbers = new int[numberCount];
        
        int k = sc.nextInt();
       
        for(int i = 0; i < numberCount; i++){
            numbers[i] = sc.nextInt();
        }
        
        // binary search
        
        int idx = -1;
        int start = 0;
        int end = numberCount - 1;
        
        while(start <= end){
            
            int current = (start + end) / 2;
            
            if(numbers[current] == k){
                idx = current;
                break;
            } else if(numbers[current] < k){
                start = current + 1;
            } else{
                end = current - 1;
            }
        }
        
        System.out.println(idx != -1 ? idx : "NO");
    }
}