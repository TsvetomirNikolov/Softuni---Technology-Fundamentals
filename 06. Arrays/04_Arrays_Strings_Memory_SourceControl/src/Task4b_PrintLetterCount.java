import java.util.Scanner;

// Test with:
// Programming

// Result:
// a(1)
// g(2)
// i(1)
// m(2)
// n(1)
// o(1)
// p(1)
// r(2)

public class Task4b_PrintLetterCount{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        
        int[] letterCount = new int[26];
        
        for(char c : str.toCharArray()){
            if(Character.isLetter(c)) {
                letterCount[Character.toLowerCase(c) - 'a']++;
            }
        }
        
        for(int i = 0; i < 26; i++){
            if(letterCount[i] > 0){
                System.out.printf("%c(%d)%n", i + 'a', letterCount[i]);
            }
        }
    }
}