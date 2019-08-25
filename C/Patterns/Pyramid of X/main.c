///
/**
 *  Use For Loop to construct a program that displays
 *  a Pyramid of X's on the Screen. The pyramid should
 *  be of 20 lines.
 */
///

#include<stdio.h>
#include<conio.h>

int main()
{
    int row, col, space, n;

    printf(" Enter the number of lines = ");
    scanf("%d", &n);
    printf("\n");

    for(row = 0 ; row <= n ; row++)
    {
        for(space = 0 ; space <= n-row ; space++)
        {
            printf("  ");
        }
        for(col = 0 ; col <= row*2 ; col++)
        {
            printf(" *");
        }
        printf("\n");
    }
    return 0;
}

