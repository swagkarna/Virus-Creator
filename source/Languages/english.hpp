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
#define PAUSE system("PAUSE");

void showOptions()
{
    std::cout << "1. Open other alert" << endl;
    std::cout << "2. Open website(ONLY CHROME)" << endl;
    std::cout << "3. Reboot PC" << endl;
    std::cout << "4. Custom Script(VBscript)" << endl;
    std::cout << "5. End Virus" << endl;
}

void showEnglish()
{
    std::cout << "Translated by: CosmoXD and Google Translate xD" << endl;
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
    

    //This part create the virus file.
    try
    {
        virus.open("virus.vbs", std::ios::ate);
        virus << "msgbox(\"" << "You are infected by the virus:" << " " << nombreVirus << "\")";
    }
    catch(const std::exception& e)
    {
        std::cout << "ERROR Creating the virus.vbs file!. 0x2" << endl;
    }

    std::cout << "Now select what the virus need do:" << endl;

    //This is the "main loop" what write the events
    for(int i = 0; i < 1000; i++)
    {
        int option;
        showOptions();
        scanf("%i", &option);
        if(option == 1)
        {
            std::cout << "Please, say me the other message: ";
            char mensaje[500];
            std::cin >> mensaje;
            virus << endl << "msgbox(\"" << mensaje << "\")";
            clearConsole
        }
        else if (option == 2)
        {
            char abrirWebChrome[] = 
            endl
            "Dim wShell"
            endl
            "Set wShell = CreateObject(\"WScript.Shell\")"
            endl
            "wShell.Run \"http://google.com\",9"
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
            char scriptPersonalizado[1000];
            std::cout << "Write the custom script:" << endl;
            std::cout << "NOTE: I am developing a way to make a multiline script, please wait ..." << endl;
            std::cout << "For now to do that you have to select the custom script option more than once to make a multiline script" << endl;
            std::cin >> scriptPersonalizado;
            std::cout << endl;
            virus << endl << scriptPersonalizado;
        }
        else if(option == 5)
        {
            break;
            virus.close();
            system("PAUSE");
            std::cout << "BYE!!";
        }
        else 
        {
            std::cout << "ERROR 0x4." << endl;
            break;
            PAUSE
        }
        i++;
    }
}