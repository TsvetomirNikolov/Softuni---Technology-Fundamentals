
import java.util.Scanner;

public class Task1d_PrintString {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        for (char c : input.toCharArray()) {
            System.out.println(c);
        }

        /*
        for (int i = 0; i < input.length(); i++) {
            System.out.println(input.charAt(i));
        }
        */
    }
}
