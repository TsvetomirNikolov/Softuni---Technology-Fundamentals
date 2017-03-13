
public class Task1e_Print2dArray {

    public static void main(String[] args) {
        int n = 4;
        int[][] arr = new int[n][n];

        int number = 0;
        
        for (int row = 0; row < arr.length; row++) {
            for (int col = 0; col < arr[row].length; col++) {
                arr[row][col] = ++number;
            }
        }

        for (int row = 0; row < arr.length; row++) {
            for (int col = 0; col < arr[row].length; col++) {
                System.out.printf("%4d ", arr[row][col]);
            }
            System.out.println();
        }
    }
}
