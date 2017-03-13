import java.util.Scanner;

// Test with:
// 11 21 8 11 -1 -3 7 4 19 5 -6 0 

// Result:
// -6  -3  -1   0   4   5   7   8  11  19  21

public class Task3b_PrintSortedNumbers{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int numberCount = sc.nextInt();
        int[] numbers = new int[numberCount];
        
        for(int i = 0; i < numberCount; i++){
            numbers[i] = sc.nextInt();
        }
        
        //// Naive sort
        //for(int i = 0; i < numberCount - 1; i++) {
        //    for(int j = i + 1; j < numberCount; j++){
        //        if(numbers[i] > numbers[j]) {
        //            int tmp = numbers[i];
        //            numbers[i] = numbers[j];
        //            numbers[j] = tmp;
        //            
        //            i = -1;
        //            break;
        //        }
        //    }
        //}
        
        ////Bubble sort
        //for(int i = 0; i < numberCount - 1; i++) {
        //    for(int j = 0; j < numberCount - 1; j++){
        //        if(numbers[j] > numbers[j + 1]) {
        //            int tmp = numbers[j];
        //            numbers[j] = numbers[j + 1];
        //            numbers[j + 1] = tmp;
        //        }
        //    }
        //}
        
        //Selection sort
        for (int j = 0; j < numberCount - 1; j++) {
            int idxMin = j;
            for (int i = j + 1; i < numberCount; i++) {
                if (numbers[i] < numbers[idxMin]) {
                    idxMin = i;
                }
            }
        
            if(idxMin != j) {
                int tmp = numbers[j];
                numbers[j] = numbers[idxMin];
                numbers[idxMin] = tmp;
            }
        }
        
        ////Insertion sort
        //for(int i = 1; i < numberCount ; i++)
        //{
        //    int current = numbers[i];
        //    
        //    int j;
        //    for(j = i - 1; j >= 0 ; j--){
        //        
        //        if( current < numbers[j] ){
        //            numbers[j + 1] = numbers[j];
        //        } else{
        //            break;
        //        }
        //    }
        //    
        //    numbers[j + 1] = current;
        //}
        
        for(int i = 0; i < numberCount; i++){
            System.out.printf("%4d", numbers[i]);
        }
        
        System.out.println();
    }
}