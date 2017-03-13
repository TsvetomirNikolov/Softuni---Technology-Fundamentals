
import java.util.Arrays;
import java.util.Scanner;

// Test with:
// 6 1 2 3 4 9 1
// Result:
// true
public class Task3d_PrintSplitIndex {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int numberCount = sc.nextInt();
        int[] numbers = new int[numberCount];

        int[] sums = new int[numberCount];
        int totalSum = 0;

        for (int i = 0; i < numberCount; i++) {
            numbers[i] = sc.nextInt();
            totalSum += numbers[i];
            sums[i] = totalSum;
        }
        System.out.println(Arrays.toString(sums));
        if (totalSum % 2 == 0) {
            for (int i = 0; i < numberCount; i++) {
                if (sums[i] * 2 == totalSum) {
                    System.out.println(i);
                    System.out.println(sums[i]);
                    return;
                }
            }
        }

        System.out.println("NO");
    }
}
