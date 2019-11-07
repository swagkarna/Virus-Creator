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

// THE LANGUAGES
#include "Languages/spanish.hpp"

void showLanguages()
{
    std::cout << "1- English" << "\n";
    std::cout << "2- Spanish" << "\n";
}

// This is the main entry of the program
int main()
{
    std::cout << "Welcome to this program!" << "\n";
    std::cout << "Please select your language:" << "\n";
    int langNumber;
    showLanguages();
    std::cin >> langNumber;

    //Select language
    switch(langNumber)
    {
        case 1: 
            break;
        
        case 2: 
            showSpanish();
            break;

        default:
            std::cout << "Error 0x1." << "\n";
            system("PAUSE");
    }
    return 0;
}