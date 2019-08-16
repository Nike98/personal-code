///
/**
 *      WAP to find the Reverse Number.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int rem, num,revnum = 0;

    printf("Enter the Number: ");
    scanf("%d", &num);

    while(num != 0){
        rem = num % 10;
        revnum = (revnum * 10) + rem;
        num1 /= 10;
    }

    printf("\n The Reverse Number = %d", revnum);

    getch();
    return 0;
}

