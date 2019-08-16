///
/**
 *      WAP to check if the given number
 *      is a Palindrome Number or not.
 */
///

#include<stdio.h>
//#include<conio.h>

int main()
{
    int rem, num, num_copy, revnum = 0;

    printf("Enter the Number: ");
    scanf("%d", &num);

    num_copy = num;

    while(num_copy != 0){
        rem = num_copy % 10;
        revnum = (revnum * 10) + rem;
        num_copy /= 10;
    }

    if (revnum == num)
        printf("\n It is a Palindrome Number.");
    else
        printf("\n It is Not a Palindrome Number.");

    return 0;
}

