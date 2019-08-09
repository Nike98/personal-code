///
/**
 *      Write a program to perform Push,
 *      Pop and Peek operations on a Stack using Arrays.
 */
///

#include <stdio.h>
#include <conio.h>
#define MAX 5   // Altering this value changes the size of the Stack

int stk[MAX], top = -1;

void push(int stk[], int val);
int pop(int stk[]);
int peek(int stk[]);
void display(int stk[]);

int main(){
    int val, option;

    do{
        printf("\n\n *****MAIN MENU*****");
        printf("\n 1. PUSH");
        printf("\n 2. POP");
        printf("\n 3. PEEK");
        printf("\n 4. DISPLAY");
        printf("\n 5. EXIT");
        printf("\n Enter your option: ");
        scanf("%d", &option);

        switch (option){
        case 1:
            printf("\n\n Enter the number to be pushed to the Stack: ");
            scanf("%d", &val);
            push(stk, val);
            break;

        case 2:
            val = pop(stk);
            if (val != -1)
                printf("\n\n The value deleted/popped from the Stack is: %d", val);
            break;

        case 3:
            val = peek(stk);
            if (val != -1)
                printf("\n\n The value stored at the top of the Stack is: %d", val);
            break;

        case 4:
            display(stk);
            break;
        }
    } while (option != 5);
    return 0;
}

void push(int stk[], int val){
    if (top == MAX - 1)
        printf("\n STACK OVERFLOW");
    else {
        top++;
        stk[top] = val;
    }
}

int pop(int stk[]){
    int val;
    if (top == -1){
        printf("\n STACK UNDERFLOW");
        return -1;
    } else {
        val = stk[top];
        top--;
        return val;
    }
}

int peek(int stk[]){
    if (top == -1){
        printf("\n STACK IS EMPTY");
        return -1;
    } else
        return (stk[top]);
}

void display(int stk[]){
    int i;
    if (top == -1)
        printf("\n STACK IS EMPTY");
    else {
        for (i = top ; i > 0 ; i--)
            printf("\n %d", stk[i]);
        printf("\n");   // Added for better formatting
    }
}
