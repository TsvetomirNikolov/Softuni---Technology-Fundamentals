import java.util.Scanner;

// Test with:
// I love programming.
// encode
// Result:
// J mpwf qsphsbnnjoh.

// Test with:
// J ibuf tusjoht opx
// decode
// Result:
// I hate strings now

public class Task4c_CaesarCipher{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        
        String operation = sc.nextLine();
        
        if(operation.equals("encode")){
            
            for(char c : str.toCharArray()){
                
                if(Character.isLetter(c)){
                    char nextLetter = (char)(c + 1);
                    
                    if(c == 'z'){
                        nextLetter = 'a';
                    }
                    
                    System.out.print(nextLetter);
                } else{
                    System.out.print(c);
                }
            }
            
        } else if(operation.equals("decode")){
            
            for(char c : str.toCharArray()){
                
                if(Character.isLetter(c)){
                    char nextLetter = (char)(c - 1);
                    
                    if(c == 'a'){
                        nextLetter = 'z';
                    }
                    
                    System.out.print(nextLetter);
                } else{
                    System.out.print(c);
                }
            }
            
        } else {
            System.out.println("Wrong command [encode/decode].");
        }
        
        System.out.println();
    }
}