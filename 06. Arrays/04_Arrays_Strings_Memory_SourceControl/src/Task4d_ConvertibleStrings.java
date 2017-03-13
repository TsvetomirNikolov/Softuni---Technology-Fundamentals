import java.util.Scanner;

// Test with:
// I love orange t-shirts
// I love oranges

// Result:
// true

public class Task4d_ConvertibleStrings{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        String source = sc.nextLine();
        String target = sc.nextLine();
        
        int lastIdx = -1;
        for(int i = 0; i < target.length(); i++){
            char targetChar = target.charAt(i);
            
            // indexOf finds the next index where targetChar is found, after index lastIdx + 1
            // if indexOf doesn't find targetChar it returns -1
            lastIdx = source.indexOf(targetChar, lastIdx + 1);
            if(lastIdx == -1){
                System.out.println(false);
                return;
            }
        }
        
        System.out.println(true);
    }
}