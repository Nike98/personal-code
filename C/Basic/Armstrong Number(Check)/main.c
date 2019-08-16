///
/**
 *      WAP to check if the number entered
 *      by the User is an Armstrong Number or not.
 */
///

#include<stdio.h>
//#include<conio.h>

void main ()
{
    int num, sum = 0, digit, temp;
    //clrscr();

    printf(" Enter the Number: ");
    scanf("%d", &num);

    temp = num;

    while(temp != 0)
    {
    digit = temp % 10;
    sum += digit * digit * digit;
    temp /= 10;
    }

    if (sum == num)
        printf("\n It is an Armstrong Number");
    else
        printf("\n It is Not an Armstrong Number");

    //getch();
    return 0;
}
