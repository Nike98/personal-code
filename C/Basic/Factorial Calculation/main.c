///
/**
 *      WAP to find the Factorial of the
 *      number input by the User.
 *
 *      This program produces factorial up till 65.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int i, num;
    unsigned long long fact = 1;

    printf("\n Enter the Number: ");
    scanf("%d", &num);

    if (num < 0)
        printf("\n Factorial of a Negative Number does not Exist!");
    else if (num > 65)
        printf("\n Cannot produce a Factorial beyond 65!");
    else if (num == 1 || num == 0)
        printf("\n The Factorial of %d is 1", num);
    else{
        for (i = 1; i <= num; i++)
            fact *= i;
        printf("\n The Factorial of %d is: %llu", num, fact);
    }
    //getch();
    return 0;
}
