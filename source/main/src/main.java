import java.util.Scanner;

import VBSlanguages.VBSspanish.*;

//VBS SPANISH
import static VBSlanguages.VBSspanish.vbsSpanish;

public class main {

    public static void showLanguages()
    {
        System.out.println("1- English");
        System.out.println("2- Spanish");
    }

    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        System.out.println("Welcome to this program!");
        System.out.println("Please, select your language");
        showLanguages();
        try {
            int lang = Integer.parseInt(scanner.nextLine());
            switch (lang)
            {
                case 1:
                    System.out.println("Working on english version...");
                    break;
                case 2:
                    vbsSpanish();
                    break;
                default:
                    System.out.println("ERROR 1.");
                    break;
            }
        }
        catch (Exception exception)
        {
            System.out.println("ERROR: 1.");
        }
    }
}
