///
/**
 *      WAP to check whether the year entered
 *      by the User is a Leap Year or not.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int year;
    //clrscr();

    printf(" Enter the Year: ");
    scanf("%d", &year);

    if (year % 4 == 0)
        printf("\n It is a Leap Year");
    else
        printf("It is Not a Leap Year");

    //getch();
    return 0;
}
