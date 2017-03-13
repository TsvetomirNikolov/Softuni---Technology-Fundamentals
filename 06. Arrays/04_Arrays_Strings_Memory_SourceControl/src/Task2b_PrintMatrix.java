import java.util.Scanner;

public class Task2b_PrintMatrix{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        int[][] arr = new int[n][n];
        
        int x = 1;
        
        int row = 0, col = 0;
        int dir = 1;
        
        while( x <= n * n){
            arr[row][col] = x++;
            
            if( ! (0 <= row + dir ) ){
                col++;
                dir = 1;
            } else if ( ! ( row + dir < n ) ) {
                col++;
                dir = -1;
            } else {
                row += dir;
            }
        }
        
        for(row = 0; row < n ; row++ ){
            for(col = 0; col < n ; col++){
                System.out.printf("%4d", arr[row][col]);
            }
            System.out.println();
        }
    }
}