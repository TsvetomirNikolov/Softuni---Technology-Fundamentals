import java.util.Scanner;

public class Task2c_PrintMatrix{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        int[][] arr = new int[n][n];
        int x = 1;
        
        int row = 0, col = 0;
        int dirRow = -1, dirCol = 1;
        
        while( x <= n * n ){
            arr[row][col] = x++;
            
            int newRow = row + dirRow;
            int newCol = col + dirCol;
            
            if(newRow < 0){
                dirRow = 1;
                dirCol = -1;
                newRow = row;
            }  
            
            if(newCol < 0) {
                dirRow = -1;
                dirCol = 1;
                newCol = col;
            }  
            
            if(newRow >= n){
                dirRow = -1;
                dirCol = 1;
                newRow = row;
                newCol = col + 1;
            }  
            
            if(newCol >= n){
                dirRow = 1;
                dirCol = -1;
                newCol = col;
                newRow = row + 1;
            }
            
            row = newRow;
            col = newCol;
        }
        
        for(row = 0; row < n ; row++ ){
            for(col = 0; col < n ; col++){
                System.out.printf("%4d", arr[row][col]);
            }
            System.out.println();
        }
    }
}