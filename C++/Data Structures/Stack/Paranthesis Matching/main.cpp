///
/**
 *      WAP to implement Parenthesis Matching
 */
///

#include<iostream>
#include<string.h>

#define MAX 10

int top = -1;

int arr[MAX];

using namespace std;

void push(char x)
{
    if (top >= MAX-1)
        cout << "\n STACK OVERFLOW" << endl;
    else {
        top++;
        arr[top] = x;
    }
}

char pop()
{
    char a;
    if (top  <= -1)
        cout << "\n STACK EMPTY!" << endl;
    else {
        a = arr[top];
        top = top-1;
        return a;
    }
}

bool isEmpty()
{
    if (top == -1)
        return true;
    else
        return false;
}

bool isBalanced(char expr[])
{
    char x, temp;
    for (int i = 0; i < strlen(expr); i++) {
        if (expr[i] == '(' || expr[i] == '[' || expr[i] == '{') {
                push(expr[i]);
                continue;
        }

        if (isEmpty())
            return false;

        switch (expr[i]) {
        case ')':
            x = pop();
            if (x == '{' || x == '[')
                return false;
            break;

        case '}':
            x = pop();
            if (x == '(' || x == ']')
                return false;
            break;

        case ']':
            x = pop();
            if (x == '(' || x == '{')
                return false;
            break;
        }
    }
    return isEmpty();
}

int main()
{
    char expr[MAX];

    cout << "\n\n Enter the expression: ";
    cin >> expr;

    if (isBalanced(expr))
        cout << "\n\n It is a Balanced Expression." << endl;
    else
        cout << "\n\n It is not a Balanced Expression." << endl;
}
