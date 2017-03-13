import java.util.Scanner;

// Test with:
// 15 4 6 4 -3 5 2 5 4 5 6 -3 2 5 4 6

// Result:
// 6

public class Task3h_PrintOddFrequencyNumber{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int numberCount = sc.nextInt();
        
        int result = 0;
        
        for(int i = 0 ; i < numberCount; i++){
           result ^= sc.nextInt(); 
        }
        
        System.out.println(result);
    }
}