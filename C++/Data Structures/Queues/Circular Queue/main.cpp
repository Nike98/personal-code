///
/**
 *      WAP to implement a Circular Queue using Arrays
 */
///

#include<iostream>

#define MAX 5

using namespace std;

int front = -1;
int rear = -1;
int arr[MAX];

void enqueue(int x)                             /// Function to << Enqueue >> or insert the data at the rear of the Queue
{
    if (front == 0 && rear == MAX-1)            // check if the Queue is full or not
        cout << "\n\n QUEUE OVERFLOW\n";
    else if (front == -1 && rear == -1) {       // if the Queue is empty,
        front=rear=0;                           // start the front and rear both from 0,
        arr[rear] = x;                          // add the value entered by the User to the Queue
    }
    else if (rear == MAX-1 && front != 0){      // if the Queue has reached Max limit, and there are existing spaces at the initial array indexes,
        rear = 0;                               // set the Queue rear to 0,
        arr[rear] = x;                          // and add the new element at the start of the Array(but it will be understood as the rear of the Queue going by the Circular Queue logic)
    }
    else {                                      // on a normal Queue state,
        rear++;                                 // increment rear to the next position,
        arr[rear] = x;                          // add the element entered by the user at the new location
    }
}

void dequeue()                                  /// Function to << Dequeue >> or delete the data from the front of the Queue
{
    if (front == -1 || front > rear)            // if front is still -1 i.e. the Queue is empty or front is greater than rear, prompt the user for Queue Underflow
        cout << "\n\n QUEUE UNDERFLOW" << endl;

    int x = arr[front];                         // save the value in some variable to display to the user,
    if (front == rear)                          // when dequeuing, if the front and rear match(which will mostly happen when both become 0) then,
        front = rear = -1;                      // set both front and rear to -1
    else{                                       // if the queue is full or contains proper rear value,
        if (front == MAX-1)                     // if the front has reached the end of the Queue, i.e. the Queue is now empty,
            front = 0;                          // set the front back to 0
        else {                                  // regular element dequeuing
            cout << "\n\n The Dequeued element was : " << x << endl;
            front = front + 1;                  // increment the value of front to the next index in the array
        }
    }
}

void display()								    /// Function to << Display >> the Queue
{
    cout << "\n\n";

    if (front == -1 && rear == -1)              // if the Queue is Empty, prompt the User
        cout << " The QUEUE is EMPTY.";
    else {                                      // if it is a Circular Queue,
        if (front < rear){
            for (int i = front; i <= rear; i++) // to display a Linear Queue
                cout << "  " << arr[i];
        }
        else {
            for (int i = front; i < MAX; i++)   // print the elements from the Queue front to the Array end
                cout << "  " << arr[i];
            for (int i = 0; i <= rear; i++)     // then start from the 0 index of the Array and print till the rear position
                cout << "  " << arr[i];
        }
    }
    cout << "\n\n";
}

int main()
{
    int choice, element;

    do{
        cout << "\n\n ****** << QUEUE >> ******\n"
            << "\n 1. Enqueue (insertion at the rear)"
            << "\n 2. Dequeue (deletion at the front)"
            << "\n 3. Display"
            << "\n 4. Exit\n"
            << "\n Enter you choice: ";
        cin >> choice;

        switch(choice){
        case 1:
            cout << "\n Enter the element to Enqueue : ";
            cin >> element;
            enqueue(element);
            break;
        case 2:
            dequeue();
            break;
        case 3:
            display();
            break;
        }
    } while (choice < 4);

    return 0;
}
