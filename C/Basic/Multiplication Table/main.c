// Table of Integer

#include<stdio.h>
#include<conio.h>

int main()
{
    int i, num;

    printf(" Enter a Positive Integer: ");
    scanf("%d", &num);

    for (i = 1; i <= 10; i++)
        printf("\n %d X %d = %d", num, i, num * i);

    return 0;
}
