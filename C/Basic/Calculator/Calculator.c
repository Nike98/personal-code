#include<stdio.h>
#include<conio.h>

int main()
{
    int arr[9], sum, i;

    printf(" Enter the equation = ");

    for(i = 1 ; i <= 9 ; i++)
    {
        //printf(" Enter the equation = ");
        scanf("%d", &arr[i]);
    }

    for(i = 1 ; i <= 15 ; i++)
    {
        sum += arr[i];
    }

    printf("\n\n The sum = %d", sum);

    return 0;
}
