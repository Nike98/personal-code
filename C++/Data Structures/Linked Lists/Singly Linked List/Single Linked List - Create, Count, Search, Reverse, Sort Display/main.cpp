///
/**
 *      WAP to implement Single Linked List for the
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
#include<stdlib.h>

using namespace std;

int count = 0;

struct node
{
    int data;
    struct node *next;
} *start, *temp, *ptr;

void swap(struct node *a, struct node *b)
{
    int temp = a->data;
    a->data = b->data;
    b->data = temp;
}

void create_node()
{
    int x;
    cout << "\n\n Enter the value to be added to the list : ";
    cin >> x;

    temp = new node;
    temp->data = x;
    temp->next = NULL;

    if (start == NULL)
        start = temp;
    else {
        ptr = start;
        while (ptr->next != NULL)
            ptr = ptr->next;
        ptr->next = temp;
    }
    count++;
    cout << "\n\n New Node added to the End of the List.";
}

void search()
{
    int value, flag = 0, pos;

    if (start == NULL)
        cout << "\n\n LIST EMPTY\n";
    else {
        cout << "\n\n Enter the value to be Searched in the list : ";
        cin >> value;

        pos = 0;
        for (temp = start; temp != NULL; temp = temp->next){
            if (temp->data == value){
                flag = 1;
                break;
            }
            pos++;
        }

        if (flag == 0)
            cout << "\n\n The requested data was not found the list.\n";
        else
            cout << "\n\n The requested data was found at " << pos+1 << " position in the list.\n";
    }
}

void sort(struct node *start)
{
    int swapped;

    if (start == NULL)
        cout << "\n\n LIST EMPTY \n";
    else {
        do {
            swapped = 0;
            ptr = start;

            while (ptr != NULL){
                if (ptr->data > (ptr->next)->data){
                    swap(ptr, ptr->next);
                    swapped = 1;
                }
                ptr = ptr->next;
            }
            ptr = NULL;
        } while (swapped);
        cout << "\n\n List Sorted Successfully.\n";
    }
}

void reverse()
{
    ptr = start;
    node *prev = NULL;
    node *next = NULL;

    while (ptr != NULL){
        next = ptr->next;
        ptr->next = prev;
        prev = ptr;
        ptr = next;
    }
    start = prev;
    cout << "\n\n List Reversed Successfully.\n";
}

void display()
{
    temp = start;
    cout << "\n\n";
    while (temp != NULL){
        cout << "  " << temp->data;
        temp = temp->next;
    }
    cout << "\n\n";
}

int main()
{
    start = NULL;
    int choice;

    do {
        cout << "\n\n ****** << SINGLE LINKED LIST >> ******\n\n"
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
            reverse();
            break;
        case 6:
            display();
            break;
        }
    } while (choice < 7);
    return 0;
}
