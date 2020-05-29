///
/**
 *  WAP to implement a Circular Linked List
 */
///

#include<iostream>

using namespace std;

struct node
{
    int data;
    node *next;
} *start, *prev, *temp, *ptr, *np;

node *create_node()                             /// Function to Create a << Node in the Memory >>
{
    int x;                                      // variable to get the data entered by the user
    cout << "\n\n Enter the value to insert : ";
    cin >> x;
    ptr = new node;
    ptr->data = x;                              // Setting the value inserted by the User as the Node value
    ptr->next = NULL;                           // Setting the next address as NULL as there is no node after the current one
    cout << "\n New Node Created !" << endl;
    return ptr;                                 // returning the value of the ptr pointer
}

void insert_at_beginning(node *temp)            /// Function to << Insert a Node at the End >> of the Linked List
{
    if (start == NULL){                         // if the list is empty/there is no existing node,
        start = temp;                           // set the temp pointer as start and,
        temp->next = start;                     // point the next value of temp node back to start
        cout << "\n Node Inserted at the Beginning Successfully !" << endl;
        cout << " The value added to the node is : " << temp->data << endl;
    }
    else {                                      // if there are existing nodes in the list, and still want to insert at the beginning,
        ptr = start;                            // assign the 1st node to ptr
        while (ptr->next != start)              // loop through the list to reach up till the last node
            ptr = ptr->next;

        temp->next = ptr->next;                 // point temp to the last pointer
        ptr->next = temp;                       // point the last point back to the start, i.e. temp here
        start = temp;                           // point start to temp as temp is the new beginning node

        cout << "\n Node Inserted at the Beginning Successfully !" << endl;
        cout << " The value added to the node is : " << temp->data << endl;
    }
}

void insert_at_end(node *temp)                  /// Function to << Insert a Node at the End >> of the Linked List
{
    if (start == NULL){                         // Creation of a new node at the beginning if the list is empty
        start = temp;
        temp->next = start;
        cout << "\n Node Inserted Successfully !" << endl;
        cout << " The value added to the node is : " << temp->data << endl;
    }
    else {                                      // if the list has existing nodes,
        ptr = start;                            // assign the first node to ptr
        while (ptr->next != start)              // loop through the list to reach the end node
            ptr = ptr->next;
        cout << "\n\n Insertion of data at the End Successful !" << endl;
        cout << " The data added at the End of the list is : " << temp->data << endl;
        ptr->next = temp;                       // point the last node the new node
        temp->next = start;                     // point the newly made last node to the start
    }
}

void delete_at_beginning()                      /// Function to << Delete a Node at the Beginning >> of the Linked List
{
    if (start == NULL)                          // if no odes are present in the list, prompt the User
        cout << "\n\n << LIST EMPTY >> \n"
             << " Deletion of node(s) cannot be performed as the List is Empty." << endl;
    else {
        ptr = start;                            // assign the start node to the ptr pointer
        while (ptr->next != start)              // loop through the list to reach the last node
            ptr = ptr->next;
        temp = ptr->next;                       // assign the next value of the last pointer to temp i.e. the start/first node
        cout << "\n\n The Node currently Deleted contained the value : " << start->data;
        ptr->next = temp->next;                 // join the last node to the second node in the list
        start = temp->next;                     // point the start pointer to the second pointer
    }
}

void delete_at_end()                            /// Function to << Delete a Node at the End >> of the Linked List
{
    temp = start;                               // assign the first/start node to the temp pointer
    if (start == NULL)                          // if the list is empty prompt the user for no deletion
        cout << "\n\n << LIST EMPTY >> \n"
             << " Deletion of node(s) cannot be performed as the List is Empty." << endl;

    if (temp->next == start){                   // if there is only one left in the List before Deletion,
        cout << "\n\n The last Node in the List contained the value : " << temp->data << endl;
        cout << "\n The List is now Empty!" << endl;    // prompt the user, and show the data contained in the node
        delete(temp);                           // delete the node
        start = NULL;                           // set the start as null, since the list will then be empty
    }

    else {                                      // if there are nodes existing in the list,
        prev = start;                           // assign the value of start to prev pointer
        while (temp->next != start){            // using the temp pointer get to the last node, and
            prev = temp;                        // assign prev the temp - 1 node (the node before temp)
            temp = temp->next;
        }
        cout << "\n\n The Node currently Deleted contained the value : " << temp->data;
        prev->next = start;                     // point the node present at prev to start
    }
}

void display()                                  /// Function to << Display >> the Linked List
{
    temp = start->next;
    cout << "\n";
    cout << "  " << start->data;
    while (temp != start){
        cout << "  " << temp->data;
        temp = temp->next;
    }
    cout << "\n";
}

int main()
{
    start = NULL;
    int choice, value;
    do {
        cout << "\n\n ######--- CIRCULAR LINKED LIST ---######"
             << "\n\n ###### MENU ######\n\n"
             << " 1. Insert at the Beginning\n"
             << " 2. Insert at the End\n"
             << " 3. Delete at the Beginning\n"
             << " 4. Delete at the End\n"
             << " 5. Display\n"
             << " 6. Exit\n\n"
             << "Enter your choice : ";
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
