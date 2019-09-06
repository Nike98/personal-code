// Vowel or not

#include<stdio.h>
#include<conio.h>

int main()
{
    char ch;
    printf(" Enter a Single Character: ");
    scanf("%c", &ch);

    if (ch == 'A' || ch == 'a' || ch == 'E' || ch == 'e' ||
        ch == 'I'  || ch == 'i' || ch == 'O' || ch == 'o' ||
        ch == 'U' || ch == 'u')
            printf("\n The Entered Character is a Vowel.");
    else
        printf("\n The Entered Character is Not a Vowel.");

    return 0;\
}
