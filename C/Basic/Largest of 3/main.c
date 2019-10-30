///
/**
 *      WAP to find the Largest of 3 Numbers.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int a, b, c;
    //clrscr();

    printf(" Enter the value of a: ");
    scanf("%d", &a);

    printf("\n Enter the value of b: ");
    scanf("%d", &b);

    printf("\n Enter the value of c: ");
    scanf("%d", &c);

    if ((a > b ) && (a > c))
        printf("\n a is the largest number");
    else if((b > c) && (b > a))
        printf("\n b is the largest number");
    else
        printf("\n c is the largest number");

    //getch();
    return 0;
}
