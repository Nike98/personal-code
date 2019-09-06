#include<stdio.h>
#include<conio.h>

int main()
{
    int num, i, rem, sum = 0, num_copy;
    printf(" Enter the Number: ");
    scanf("%d", &num);

    num_copy = num;

    for (i = 1; i < num_copy; i++){
        rem = num_copy % i;
        if (rem == 0)
            sum += i;
    }

    if (sum == num)
        printf("\n It is a Perfect Number.");
    else
        printf("\n It i Not a Perfect Number.");

    return 0;
}
