
// A Basic C program to demonstrate the use of * pointers

#include <stdio.h>

int main()
{
    // Normal integer variable declaration
    int var = 10;

    // A pointer variable to hold the address of integer -> var
    int *ptr = &var;

    // This line prints the value at address stored in ptr
    // Value stored is the value of variable -> var
    printf(" Value of var = %d\n", *ptr);

    // The address of the integer -> var
    printf(" Address of var = %p\n", ptr);

    // Trying to reinitialize the value at
    // the address
    *ptr = 20;

    // Checking if the original value has been changed or not
    printf(" New value of var = %d\n", var);

    return 0;
}
