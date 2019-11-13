package utils;

import java.io.File;

import static java.lang.Thread.sleep;

public class utils {
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
