
import java.util.Scanner;

public class Task2d_PrintMatrix {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        int[][] arr = new int[n][n];
        int number = 0;
        int row = 0, col = 0;

        int leftBoundary = 0;
        int upperBoundary = 0;
        int rightBoundary = n - 1;
        int lowerBoundary = n - 1;

        while (number < n * n) {

            for (col = leftBoundary; col <= rightBoundary; col++) {
                arr[upperBoundary][col] = ++number;
            }
            upperBoundary++;

            for (row = upperBoundary; row <= lowerBoundary; row++) {
                arr[row][rightBoundary] = ++number;
            }
            rightBoundary--;

            for (col = rightBoundary; col >= leftBoundary; col--) {
                arr[lowerBoundary][col] = ++number;
            }
            lowerBoundary--;

            for (row = lowerBoundary; row >= upperBoundary; row--) {
                arr[row][leftBoundary] = ++number;
            }
            leftBoundary++;

        }

        for (row = 0; row < n; row++) {
            for (col = 0; col < n; col++) {
                System.out.printf("%4d", arr[row][col]);
            }
            System.out.println();
        }
    }
}
