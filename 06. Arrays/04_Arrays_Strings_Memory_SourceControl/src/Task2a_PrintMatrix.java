import java.util.Scanner;

public class Task2a_PrintMatrix{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        int[][] arr = new int[n][n];
        int x = 1;
        
        for(int row = 0; row < n ; row++) {
            for(int col = 0; col < n; col++){
                arr[col][row] = x++;
            }
        }
        
        for(int row = 0; row < n ; row++ ){
            for(int col = 0; col < n ; col++){
                System.out.printf("%4d", arr[row][col]);
            }
            System.out.println();
        }
    }
}