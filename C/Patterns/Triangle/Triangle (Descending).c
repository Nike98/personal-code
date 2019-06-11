#include<stdio.h>
#include<conio.h>

int main()
{
    int row, col, n;

    printf(" Enter the number of lines = ");
    scanf("%d", &n);
    printf("\n");

    for(row = n ; row >= 1 ; row--)
    {
        for(col = 1 ; col <= row ; col++)
        {
            printf(" *");
        }
        printf("\n");
    }
    return 0;
}
