
import java.util.Scanner;

public class Task1c_ReadArray {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();

        int[] arr = new int[n];

        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }

        for (int i = 0; i < n - 1; i++) {
            System.out.print(arr[i] + ", ");
        }

        System.out.println(arr[n - 1]);
    }
}
