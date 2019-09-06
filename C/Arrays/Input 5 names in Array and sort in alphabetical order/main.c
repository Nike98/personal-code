#include<stdio.h>
#include<conio.h>
#include<string.h>

void main()
{
    int num_strings;
    char list[20][20], temp[20];

    printf(" How many Names? ");
    scanf("%d", &num_strings);

    if (num_strings <= 0){
        printf("\n Invalid Input");
    }

    printf("\n Enter the %d name: \n", num_strings);

    for (int i = 0; i < num_strings; i++){
        fflush(stdin);
        gets(list[i]);
    }

    for (int i = 0; i < num_strings - 1; i++){
        for (int j = i + 1; j < num_strings; j++){
            if (strcmp(list[i], list[j]) > 0){
                strcpy(temp, list[i]);
                strcpy(list[i], list[j]);
                strcpy(list[j], temp);
            }
        }
    }

    printf("\n The sorted list of Names : \n");

    for (int i = 0; i < num_strings; i++)
        puts(list[i]);

    getch();
}
