///
/**
 *      WAP to implement the Fibonacci Series.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int range, next, first = 0, second = 1, i;
    //clrscr();

    printf(" Enter the range of the series: ");
    scanf("%d", &range);

    printf("\n The series is:\n\n %d\n %d", first, second);

    for (i = 0; i < range; i++)
    {
    next = first + second;
    first = second;
    second = next;

    printf("\n %d", next);
    }


    //getch();
    return 0;
}
