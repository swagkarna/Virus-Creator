import java.util.Scanner;

import VBSlanguages.VBSspanish.*;

//IMPORT UTILS
import static VBSlanguages.VBenglish.*;
import static utils.utils.ANSI_RED;
import static utils.utils.checkIfVirusExist;

//VBS GENERATORS
import static VBSlanguages.VBSspanish.vbsSpanish;

public class main {

    public static void showLanguages()
    {
        System.out.println(ANSI_WHITE + "1- English");
        System.out.println("2- Spanish");
    }

    public static void main(String[] args){
        checkIfVirusExist();
        Scanner scanner = new Scanner(System.in);
        System.out.println(ANSI_GREEN + "Welcome to this program!");
        System.out.println(ANSI_BLUE + "Please, select your language");
        showLanguages();
        try {
            int lang = Integer.parseInt(scanner.nextLine());
            switch (lang)
            {
                case 1:
                    vbsEnglish();
                    break;
                case 2:
                    vbsSpanish();
                    break;
                default:
                    System.out.println(ANSI_RED + "ERROR 1.");
                    break;
            }
        }
        catch (Exception exception)
        {
            System.out.println("ERROR: 1.");
        }
    }
}
