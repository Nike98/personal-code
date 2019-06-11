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
        for(space = row ; space < n ; space++)
        {
            printf(" ");
        }
        for(col = 1 ; col < (row * 2) ; col++)
        {
            printf("*");
        }
        printf("\n");
    }
    for(row = n - 1 ; row >= 1 ; row--)
    {
        for(space = n ; space > row ; space--)
        {
            printf(" ");
        }
        for(col = 1 ; col < (row * 2) ; col++)
        {
            printf("*");
        }
        printf("\n");
    }
    return 0;
}
