import java.util.Scanner;

// Test with:
// (([[{({})]}]))
// Result:
// false

// Test with:   
// ([]({}){[]})
// Result:
// true

public class Task4e_BracketMatching{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        
        int len = str.length();
        
        if(len % 2 != 0){
            System.out.println(false);
            return;
        }
        
        boolean[] matched = new boolean[len];
        
        for(int i = 1 ; i < len; i++){
            
            char source = str.charAt(i);
            char match;
            
            if(source == ')') {
                match = '(';
            } else if(source == ']'){
                match = '[';
            } else if(source == '}'){
                match = '{';
            } else {
                continue;
            }
            
            for(int j = i - 1; j >= 0 ; j-- ){
                if(!matched[j]) {
                    char target = str.charAt(j);
                    if(target != match){
                        System.out.println(false);
                        return;
                    } else{
                        matched[i] = matched[i] = true;
                        break;
                    }
                }
            }            
        }
        
        System.out.println(true);
    }
}