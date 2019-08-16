///
/**
 *      WAP to check if the entered number is
 *      even or odd and prime or not.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int num, i, num_copy, flag = 0;

    printf("\n Enter a positive integer: ");
    scanf("%d", &num);

    // Taking this to check Even and Odd further in the program
    num_copy = num;

    if (num == 1)
        printf("\n 1 is neither a Prime or a Composite Number.");
    else{
        for (i = 2; i <= num/2; i++){
            // For Non Prime numbers
            if (num % i == 0){
                flag = 1;
                break;
            }
        }

        if (flag){
            // Condition for Even and Odd Numbers
            if (num_copy % 2 == 0)
                printf("\n The entered number is an Even Number.");
            else
                printf("\n The entered number is an Odd Number.");
            printf("\n It is Not a Prime Number.");
        }
        else
            printf("\n It is a Prime Number.");
    }
}
