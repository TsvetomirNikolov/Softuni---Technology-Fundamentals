import java.util.Scanner;

// Test with:
// ahasjaaakxmza
// ahaooxmaaakxs

// Result:
// aaakx

public class Task4f_LongestCommonSubstring{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        String source = sc.nextLine();
        String target = sc.nextLine();
        
        int srcLen = source.length();
        int trgLen = target.length();
        
        int bestMatchLen = 0;
        int bestMatchSrcIdx = 0;
        
        boolean useNaiveSolution = true;
        
        if(useNaiveSolution){
            //naive solution
            for(int i = 0; i < srcLen; i++){
                for(int len = srcLen - i; len >= 1; len--){
                    String substr = source.substring(i, i + len);
                    //System.out.println(substr);
                    
                    if(target.contains(substr)) {
                        if(bestMatchLen < len){
                            bestMatchLen = len;
                            bestMatchSrcIdx = i;
                        }
                    }
                }
            }
        } else {            
            //Fast solution (Dynamic Programming)
            int[][] matrix = new int[srcLen + 1][trgLen + 1];
            
            for(int i = 1; i <= srcLen; i++){
                for(int j = 1; j <= trgLen; j++){
                    if(source.charAt(i - 1) == target.charAt(j - 1)){
                        matrix[i][j] = 1 + matrix[i - 1][j - 1];
                        
                        if(bestMatchLen < matrix[i][j]){
                            bestMatchLen = matrix[i][j];
                            bestMatchSrcIdx = i - bestMatchLen;
                        }
                    }
                }
            }
        }
        
        if(bestMatchLen > 0){
            System.out.println(source.substring(bestMatchSrcIdx, bestMatchSrcIdx + bestMatchLen));
        } else{
            System.out.println("(no common substring)");
        }
    }
}
    