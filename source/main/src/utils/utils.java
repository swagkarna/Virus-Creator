package utils;

import java.io.File;

import static java.lang.Thread.sleep;

public class utils {
    //CONSOLE COLORS
    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_BLACK = "\u001B[30m";
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_GREEN = "\u001B[32m";
    public static final String ANSI_YELLOW = "\u001B[33m";
    public static final String ANSI_BLUE = "\u001B[34m";
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_CYAN = "\u001B[36m";
    public static final String ANSI_WHITE = "\u001B[37m";

    public static void checkIfVirusExist() {
        File virusFile = new File("virus.vbs");
        boolean virusExists = virusFile.exists();

        if(virusExists == true)
        {
            System.out.println("You can't create a virus if this already exists!");
            System.out.println("ERROR 5.");
            System.exit(1);
        }
        else if(virusExists == false)
        {
            return;
        }
    }
}
