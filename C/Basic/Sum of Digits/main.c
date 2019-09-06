// Sum of Digits Entered

#include<stdio.h>
#include<conio.h>

int main()
{
    int num, sum = 0;

    printf(" Enter a Number: ");
    scanf("%d", &num);

    while(num){
        sum += num % 10;
        num /= 10;
    }

    printf("\n The Sum of the Entered Digits = %d", sum);

    return 0;
}
