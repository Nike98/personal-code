///
/**
 *  WAP to implement a Double Linked List
 */
///

#include<iostream>

using namespace std;

struct node
{
    int data;
    node *prev;
    node *next;
} *temp, *start, *temp1, *ptr, *np;

node *create_node()                             /// Function to << CREATE >> a node in the memory
{
    int x;                                      // to get the input from the user

    cout << " Enter the value to be added to the List : ";
    cin >> x;

    temp = new node;                            // using a temp pointer to store the new node
    temp->data = x;                             // accessing data property of struct node to store the data
    temp->prev = NULL;                          // setting the previous pointer of the node to NULL initially
    temp->next = NULL;                          // setting the next pointer of the node to NULL initially
    cout << "\n New Node Created !" << endl;

    return temp;
}

void insert_at_beginning(node *temp)            /// Function to << INSERT A NODE AT BEGINNING >> of the Double Linked List
{
    if (start == NULL){                         // if the start is set to NULL, i.e. the List is Empty,
        temp->prev = start;                     // point the previous pointer of the node to start,
        start = temp;                           // point the start of the list to the new node
        cout << "\n Node Inserted at the Beginning Successfully !" << endl;
        cout << " The value added to the Node is : " << temp->data << endl;
    }
    else {                                      // if the list has one or more nodes present in it,
        temp1 = start;                          // make a pointer variable temp1 point to the first node
        start = temp;                           // make start point to the newly created node stored as temp
        temp->next = temp1;                     // make next pointer of temp point to temp1 i.e. previously the first node in the list
        temp1->prev = temp;                     // make the previous pointer of the next node point back to the new node
        cout << "\n Node Inserted at the Beginning Successfully !" << endl;
        cout << " The value added to the Node is : " << temp1->data << endl;
    }
}

void insert_at_end(node *temp)                  /// Function to << INSERT A NODE AT END >> of the Double Linked List
{
    if (start == NULL){                         // if the list is empty,
        temp->prev = start;                     // perform the same node addition as in the insert in the beginning
        start = temp;
        cout << "\n Node Inserted Successfully !" << endl;
        cout << " The value added to the Node is : " << temp->data << endl;
    }
    else {                                      // if the list contains one or more than one nodes,
        temp1 = start;                          // make temp1 point to the first node,
        while(temp1->next != NULL)              // traverse through the list up till the last node,
            temp1 = temp1->next;
        cout << "\n\n Insertion of data at the End Successful !" << endl;
        cout << " The data added at the End of the list is : " << temp->data << endl;
        temp1->next = temp;                     // make temp1(currently the last node in the list) to the new node
        temp->prev = temp1;                     // make the previous pointer of temp point back to temp1
    }
}

void delete_at_beginning()                      /// Function to << DELETE NODE AT BEGINNING >> of the Double Linked List
{
    if (start == NULL)                          // if the list is empty and has no nodes present, prompt the user for Underflow
        cout << "\n\n #### LIST  UNDERFLOW ####"
             << "\n Deletion of Node cannot be performed since the Double Link List is Empty." << endl;
    else {                                      // if the list has nodes existing in it,
        temp1 = start;                          // make temp1 point the 1st node in the list
        start = temp1->next;                    // make start point to the node after the first node, i.e. the second node in the list,
        temp1->next->prev = NULL;               // since temp1 contains the first node in the list and is getting deleted, make the previous of the next node in the list as NULL
        cout << "\n\n The Node currently Deleted contained the value : " << temp1->data;
        delete(temp1);                          // delete the node pointed by temp1
    }
}

void delete_at_end()                            /// Function to << DELTE AT END >>
{
    if (start == NULL)                          // if the list is Empty, prompt for Underflow
        cout << "\n\n #### LIST  UNDERFLOW ####"
             << "\n Deletion of Node cannot be performed since the Double Link List is Empty." << endl;
    else {                                      // if the list has one or more nodes present in it,
        if (start->next == NULL){               // if only one node is existing
            cout << "\n\n The last Node in the List contained the value : " << start->data << endl;
            cout << "\n The List is now Empty!" << endl;    // prompt the user, and show the data contained in the node
            delete(start);                                  // delete the node
            start = NULL;                       // set the start pointer to Null
        }
        else {                                  // if more than one node is existing in the list,
            ptr = start;                        // make ptr point to the 1st node
            while (ptr->next != NULL)           // traverse through the list till you reach the last node
                ptr = ptr->next;
            cout << "\n\n The Node currently Deleted contained the value : " << ptr->data;
            ptr->prev->next = NULL;             // make the next of the previous node as Null
            delete(ptr);                        // delete the last node stored in the ptr pointer variable

        }
    }
}

void display()
{
    temp = start;
    cout << "\n\n";
    while (temp->next != NULL){
        cout << "  " << temp->data;
        temp = temp->next;
    }
    cout << "  " << temp->data << "\n\n";                   // for printing the last node
}

int main()
{
    start = NULL;
    int choice, value;
    do {
        cout << "\n\n ######--- DOUBLE LINKED LIST ---######"
             << "\n\n ###### MENU ######\n\n"
             << " 1. Insert at the Beginning\n"
             << " 2. Insert at the End\n"
             << " 3. Delete at the Beginning\n"
             << " 4. Delete at the End\n"
             << " 5. Display\n"
             << " 6. Exit\n\n"
             << " Enter your choice : ";
        cin >> choice;
        switch (choice){
        case 1:{
            np = create_node();
            insert_at_beginning(np);
            break;
        }
        case 2:{
            np = create_node();
            insert_at_end(np);
            break;
        }
        case 3:
            delete_at_beginning();
            break;
        case 4:
            delete_at_end();
            break;
        case 5:
            display();
            break;
        }
    } while (choice < 6);
    return 0;
}
