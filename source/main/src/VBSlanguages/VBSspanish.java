package VBSlanguages;

import java.io.*;
import java.util.Scanner;

public class VBSspanish {
    public static void mostrarOpciones()
    {
        System.out.println("1- Abrir otra alerta");
        System.out.println("2- Abrir pagina web");
        System.out.println("3- Reiniciar PC");
        System.out.println("4- Script Personalizado");
        System.out.println("5- Mensaje SPAM");
        System.out.println("6- Terminar virus");
    }

    public static void vbsSpanish()
    {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ahora dime el nombre de tu virus: ");
        String nombreVirus = scanner.nextLine();
        System.out.println("Entonces el nombre de tu virus sera: " + nombreVirus);

        File virus = new File("virus.vbs");
        try
        {
            PrintWriter salidaVirus = new PrintWriter(new FileWriter(virus, true));

            for(int i = 0; i <= 1000; i++)
            {
                int option;
                mostrarOpciones();
                option = scanner.nextInt();
                salidaVirus.println(nombreVirus);
                //ACCIONES
                if(option == 1)
                {
                    String mensaje;
                    System.out.print("Por favor dime que mensaje quieres que diga tu virus: ");
                    mensaje = scanner.nextLine();
                    salidaVirus.println("msgbox(\"" + mensaje + "\")");
                }
                else if(option == 2)
                {

                }
                else if(option == 3)
                {

                }
                else if(option == 4)
                {

                }
                else if(option == 5)
                {

                }
                else if(option == 6)
                {
                    System.out.println("BYE!");
                    break;
                }
                else
                {
                    System.out.println("ERROR 4.");
                }
                i++;
            }
        }
        catch (Exception e)
        {
            e.printStackTrace();
            System.out.println("ERROR 2.");
        }

        System.out.println("Ahora selecciona lo que quieres que tu virus haga: ");
    }
}
