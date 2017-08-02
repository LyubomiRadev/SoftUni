import java.io.Console;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        //scanner - чете, трябва да се импортне и в него да се кажe от къде да чете
       Scanner scanner = new Scanner(System.in);

       double num1 = Double.parseDouble(scanner.nextLine());
       double num2 = Double.parseDouble(scanner.nextLine());
       double sum  = num1 + num2;
       System.out.println(sum);
    }
}
