/*-----------------------------------|
|CosmoXD(c) 2019                     |
|                                    |
|                                    |
|                                    |
|-----------------------------------*/

//Include the common libs
#include <iostream>
#include <string.h>
#include <stdlib.h>
#include <fstream>

#include "utils/checkVirus.h"

// THE LANGUAGES
#include "VBScript/VBSspanish.hpp"

void showProgramingLanguages()
{
    std::cout << endl;
    std::cout << "1- VBScript" << endl;
    std::cout << "2- Bash (WORKING)" << endl;
}

void showLanguages()
{
    std::cout << "1- English" << "\n";
    std::cout << "2- Spanish" << "\n";
}

// This is the main entry of the program
int main()
{
    checkVirus();
    std::cout << "Welcome to this program!" << "\n";
    std::cout << "Please select your language:" << "\n";
    int langNumber;
    showLanguages();
    std::cin >> langNumber;

    //Select language
    switch(langNumber)
    {
        case 1: 
        /*  showEnglish(); */
            std::cout << "The english version is paused for now" << endl;
            system("PAUSE");
            break;
        
        case 2:
            int programingLanguage;
            std::cout << "Ahora por favor dime que lenguaje quieres usar: ";
            showProgramingLanguages();
            std::cout << "NOTA: Las distribuciones linux y posiblemente MAC OS no soportan VBScript" << endl;
            scanf("%i", &programingLanguage);
            if(programingLanguage == 1)
            {
                vbsSpanish();
            }
            else if(programingLanguage == 2)
            {
                std::cout << "Estoy trabajando en crear soporte para Bash, por favor ten paciencia" << endl;
            }
            else 
            {
                std::cout << "Error 5." << endl;
            }
            break;

        default:
            std::cout << "Error 1." << "\n";
            system("PAUSE");
    }
    return 0;
}