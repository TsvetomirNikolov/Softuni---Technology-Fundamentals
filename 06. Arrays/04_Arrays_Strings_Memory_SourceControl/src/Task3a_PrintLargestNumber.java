import java.util.Scanner;

// Test with:
// 11 21 8 11 -1 -3 7 4 19 5 -6 0

// Result:
// 21

public class Task3a_PrintLargestNumber{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int numberCount = sc.nextInt();
        int max = Integer.MIN_VALUE;
        
        for(int i = 0 ; i < numberCount ; i++) {
            int n = sc.nextInt();
            
            if(max < n) {
                max = n;
            }
        }
        
        System.out.println(max);
    }
}