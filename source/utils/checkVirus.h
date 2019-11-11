#include <stdio.h>
#include <string.h>
#include <stdlib.h>

void checkVirus()
{
    bool canContinue = true;
    FILE *virus;
    if((virus = fopen("virus.vbs", "r")) != NULL)
    {
        printf("Error 5.\n");
        printf("You can't create a virus if already this exist\n");
        system("PAUSE");
        exit(0);
    }
}