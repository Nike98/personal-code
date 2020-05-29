///
/**
 *      WAP to implement Double Linked List for the
 *      following operations:
 *      1. Create
 *      2. Search for a Node
 *      3. Count
 *      4. Reverse the list
 *      5. Sort the data
 *      6. Display
 */
///

#include<iostream>
#include<conio.h>
#include<stdlib.h>

using namespace std;

int count = 0;

struct node
{
    int data;
    node *prev;
    node *next;
} *start, *temp, *ptr, *np;

void swap(struct node *a, struct node *b)
{
    int temp = a->data;
    a->data = b->data;
    b->data = temp;
}

void create_node()
{
    int x;

    cout << "\n\n Enter the data to be added at the end of the list : ";
    cin >> x;

    np = new node;
    np->data = x;
    np->next = NULL;
    np->prev = NULL;

    if (start == NULL){
        start = np;
        count++;
    }
    else {
        temp = start;
        while (temp->next != NULL)
            temp = temp->next;

        temp->next = np;
        np->prev = temp;
        np->next = NULL;
        count++;
        cout << "\n Node Creation Successful." << endl;
        cout << " The Node contains the value: " << np->data << endl;
    }
}

void search()
{
    if (start == NULL)
        cout << "\n\n The List is Empty." << endl;
    else {
        temp = start;
        int pos = 0, flag = 0, value;

        cout << "\n\n Enter the value you want to find : ";
        cin >> value;

        while (temp != NULL) {
            if (temp->data == value){
                flag = 1;
                break;
            }
            pos++;
            temp = temp->next;
        }

        if (flag)
            cout << "\n\n The value " << value << " was found at position "
                 << pos+1 << " in the list." << endl;
        else
            cout << "\n\n The requested data was not found in the list." << endl;
    }
}

void sort(struct node *start)
{
    int swapped;

    if (start == NULL)
        cout << "\n\n The List is Empty." << endl;
    else {
        do {
            swapped = 0;
            ptr = start;

            while (ptr->next != NULL) {
                if (ptr->data > (ptr->next)->data) {
                    swap(ptr, ptr->next);
                    swapped = 1;
                }
                ptr = ptr->next;
            }
            ptr = NULL;
        } while (swapped);

        cout << "\n\n List Sorted Successfully." << endl;
    }
}

void reverse_list()
{
    ptr = start;
    temp = NULL;
    node *prev = NULL;   // previous node address
    node *next = NULL;   // next node address

    while (ptr != NULL) {
        temp = ptr->prev;
        ptr->prev = ptr->next;
        ptr->next = temp;
        ptr = ptr->prev;
    }
    start = temp->prev;

    cout << "\n List Reversed Successfully." << endl;
}

void display()
{
    temp = start;
    cout << "\n\n";
    while (temp != NULL){
        cout << "  " << temp->data;
        temp = temp->next;
    }
    cout << "\n";
}

int main()
{
    start = NULL;
    int choice;

    do {
        cout << "\n\n ****** << DOUBLY LINKED LIST >> ******\n\n"
             << " 1. Create\n"
             << " 2. Count\n"
             << " 3. Search\n"
             << " 4. Sort (Using Bubble Sort)\n"
             << " 5. Reverse\n"
             << " 6. Display\n"
             << " 7. Exit\n"
             << "\n Enter your choice: ";
        cin >> choice;

        switch (choice){
        case 1:
            create_node();
            break;
        case 2:
            cout << "\n\n The total number of nodes in the list is: " << count << endl;
            break;
        case 3:
            search();
            break;
        case 4:
            sort(start);
            break;

        case 5:
            reverse_list();
            break;
        case 6:
            display();
            break;
        }
    } while (choice < 7);
    return 0;
}







































