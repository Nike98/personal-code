///
/**
 *      Given the values of a, b, and c, WAP
 *      to compute and display the value of x
 *      where:
 *
 *      x = a / b - c
 *
 *      Conditions:
 *      1. a=250    b=85    c=25
 *      2. a=300    b=70    c=70
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    float a,b,c;
    double x;
    //clrscr();

    printf(" Enter the value of a: ");
    scanf("%f", &a);

    printf("\n Enter the value of b: ");
    scanf("%f", &b);

    printf("\n Enter the value of c: ");
    scanf("%f", &c);

    x = (a / b) - c;

    printf("\n 	The value of X = %lf", x);

    return 0;
    //getch();
}
