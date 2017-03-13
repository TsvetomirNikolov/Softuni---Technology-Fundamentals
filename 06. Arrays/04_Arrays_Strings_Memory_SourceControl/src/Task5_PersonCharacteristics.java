import java.util.Scanner;

public class Task5_PersonCharacteristics{

    public static void main(String []args){
        
        final short currentYear = 2016;
        final short numberOfGrades = 4;
        
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        sc.nextLine();

        for(int i = 0; i < n ; i++){
            
            String line = sc.nextLine();
            String[] split = line.split(";");
            
            String firstName = split[0].trim();
            String lastName = split[1].trim();
            char gender = split[2].trim().toCharArray()[0];
            short yearBorn = Short.parseShort(split[3].trim());            
            float weight = Float.parseFloat(split[4].trim());            
            short height = Short.parseShort(split[5].trim());
            
            String occupation = split[6].trim();
            
            float[] grades = new float[numberOfGrades];
            float avgGrade = 0;

            for(int idx = 0; idx < numberOfGrades ; idx++){
                grades[idx] = Float.parseFloat(split[idx + 7].trim());
                avgGrade += grades[idx];
            }
            
            avgGrade /= numberOfGrades;
            
            short age = (short)(currentYear - yearBorn);
            
            String heOrShe = Character.toLowerCase(gender) == 'm' ? "He" : "She";
            String hisOrHer = Character.toLowerCase(gender) == 'm' ? "His" : "Her";

            String result = String.format("%s %s is %d years old.", firstName, lastName, age);
            result += String.format(" %s was born in %d.", heOrShe, yearBorn);
            result += String.format(" %s weight is %.1f and %s is %d cm tall.", hisOrHer, weight, heOrShe.toLowerCase(), height);
            result += String.format(" %s is a %s with an average grade of %.3f.", heOrShe, occupation, avgGrade);
                
            System.out.print(result);
            
            if(age < 18) {
                System.out.printf(" %s %s is under-aged.", firstName, lastName);
            }
            
            System.out.println();
        }
    }
}
