///
/**
 *      WAP to implement Circular Linked List for the
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

using namespace std;

int count = 0;

struct node
{
    int data;
    node *next;
} *start, *prev, *temp, *ptr;

void create_node()
{
    int x;
    cout << "\n\n Enter the data to be inserted at the end of the list: ";
    cin >> x;

    ptr = new node;
    ptr->data = x;
    ptr->next = NULL;

    if (start == NULL){
        start = ptr;
        ptr->next = start;
    }
    else {
        temp = start;
        while (temp->next != start)
            temp = temp->next;
        temp->next = ptr;
        ptr->next = start;
    }
    count++;
    cout << "\n\n New Node added at the end of the list." << endl;
}

void search()
{
    if (start == NULL)
        cout << "\n\n Cannot Search data in an Empty list." << endl;
    else {
        int value, flag = 0, pos = 0;
        cout << "\n\n Enter the value to be searched in the list: ";
        cin >> value;

        temp = start;
        while (temp->next != start){
            if (temp->data == value){
                flag = 1;
                break;
            }
            pos++;
        }

        if (flag)
            cout << "\n\n The value " << value << " was found at "
                 << pos << " position in the list." << endl;
        else
            cout << "\n\n The requested data was not found in the list." << endl
    }
}

void reverse()
{
    if (start == NULL)
        cout << "\n\n Cannot Reverse an Empty list." << endl;
    else {
        struct node *prev_node = start;
        struct node *curr = start->next;
        struct node *ptr = start->next;

        while (curr != start) {
            ptr = ptr->next;
            curr->next = prev_node;
            prev_node = curr;
            curr = ptr;
        }
        curr->next = prev_node;
        start = prev_node;

        cout << "\n\n List Reversed Successfully." << endl;
    }
}

void display()
{
    ptr = start->next;
    cout << "\n\n";
    cout << "  " << start->data;
    while (ptr != start) {
        cout << "  " << ptr->data;
        ptr = ptr->next;
    }
    cout << "\n";
}

int main()
{
    start = NULL;
    int choice;

    do {
        cout << "\n\n ****** << CIRCULAR LINKED LIST >> ******\n\n"
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
            //search();
            break;
        case 4:
            //sort(start);
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










































