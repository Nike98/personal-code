///
/**
 *      WAP to find the Largest of 3
 *      using Conditional Operator.
 */
///

#include<stdio.h>
#include<conio.h>

int main()
{
    int a, b, c, largest;
    //clrscr();

    printf(" Enter the value of a: ");
    scanf("%d", &a);

    printf("\n Enter the value of b: ");
    scanf("%d", &b);

    printf("\n Enter the value of c: ");
    scanf("%d", &c);

    largest = a > b ? (a > c ? a : c) : (b > c ? b : c);

    printf("\n The Largest of all the 3 Numbers is: %d", largest);

    return 0;
}
