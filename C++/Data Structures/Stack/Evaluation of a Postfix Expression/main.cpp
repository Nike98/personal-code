///
/**
 *      WAP to implement Evaluation of Postfix Expression
 *      using Stack.
 */
///

#include<iostream>
#include<stdio.h>
#include<ctype.h>

#define MAX 50

using namespace std;

float st[MAX];
int top = -1;

void push(float st[], float val)
{
    if (top == MAX-1)
        cout << "\n\n STACK OVERFLOW";
    else {
        top++;
        st[top] = val;
    }
}

float pop(float st[])
{
    float val = -1;
    if (top  == -1)
        cout << "\n\n STACK UNDERFLOW";
    else {
        val = st[top];
        top--;
    }
    return val;
}

float evaluate_postfixExp(char exp[])
{
    int i = 0;
    float op1, op2, value;

    while (exp[i] != '\0'){
        if (isdigit(exp[i]))
            push(st, (float) (exp[i] - '0'));
        else {
            op2 = pop(st);
            op1 = pop(st);

            switch (exp[i])
            {
            case '+':
                value = op1 + op2;
                break;
            case '-':
                value = op1 - op2;
                break;
            case '*':
                value = op1 * op2;
                break;
            case '/':
                value = op1 / op2;
                break;
            case '%':
                value = (int)op1 % (int)op2;
                break;
            }
            push(st, value);
        }
        i++;
    }
    return (pop(st));
}

int main()
{
    float val;
    char exp[50];

    cout << "\n\n Enter the Postfix Expression : ";
    gets(exp);

    val = evaluate_postfixExp(exp);

    cout << "\n\n Value of the Postfix Expression is : " << val << endl;;

    return 0;
}










































