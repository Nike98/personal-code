#include<stdio.h>
#include<conio.h>

int main()
{
    int row, col, n;

    printf(" Enter the number of lines = ");
    scanf("%d", &n);
    printf("\n");

    for(row = 1 ; row <= n ; row++)
    {
        for(col = 1 ; col <= row ; col++)
        {
            printf(" *");
        }
        printf("\n");
    }
    return 0;
}
