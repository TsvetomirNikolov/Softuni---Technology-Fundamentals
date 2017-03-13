import java.util.Scanner;

// Test with
// 14 1 1 2 3 3 5 6 7 9 9 9 9 10 10 

// Result:
// 4

public class Task3c_PrintClusterCount{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int numberCount = sc.nextInt();
        int[] numbers = {1, 1, 2, 3, 3, 9, 9, 9, 9, 9, 9, 9, 10, 10};
        
        int clusterCount = 0;
        boolean oldCluster = false;
        
        numbers[0] = sc.nextInt();
        
        for(int i = 1; i < numberCount; i++){
            numbers[i] = sc.nextInt();
            
            if(numbers[i] == numbers[i-1]) {
                if(!oldCluster) {
                    clusterCount++;
                }
                
                oldCluster = true;
            } else{
                oldCluster = false;
            }
        }
        
        System.out.println(clusterCount);
       
    }
}