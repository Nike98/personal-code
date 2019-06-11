#include<stdio.h>
#include<conio.h>

int main()
{
    int row, col, space, n;

    printf(" Enter the number of lines = ");
    scanf("%d", &n);
    printf("\n");

    for(row = 1 ; row <= n ; row++)
    {
        for(col = 1 ; col <= (n + 1) - row ; col++)
        {
            printf("*");
        }
        for(space = 1 ; space < row ; space++)
        {
            printf(" ");
        }
        for(col = 1 ; col <= (n + 1) - row ; col++)
        {
            printf("*");
        }
        printf("\n");
    }
    for(row = 1 ; row <= n ; row++)
    {
        for(col = 1 ; col <= row ; col++)
        {
            printf("*");
        }
        for(space = 1 ; space <= n - row ; space++)
        {
            printf(" ");
        }
        for(col = 1 ; col <= row ; col++)
        {
            printf("*");
        }
        printf("\n");
    }
    return 0;
}
