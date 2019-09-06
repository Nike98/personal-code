// 12345 Pattern

#include <stdio.h>
#include <conio.h>

int main()
{
    int n, i, j, line;
    printf(" Enter the number of lines to be printed: ");
    scanf("%d", &line);

    for (i = 1; i <= line; i++){
            n = 1;
        for (j = 1; j <= i; j++){
            printf(" %d", n);
            n++;
        }
        printf("\n");
    }
    return 0;
}
