///
/**
 *  WAP to implement a Basic Queue
 */
///

#include<iostream>

#define MAX 5

using namespace std;

int front = -1;                             // initialize the value of front and rear
int rear = -1;                              // to -1 so that the Queue starts from 0 when incremented
int arr[MAX];                               // set the Array size as the defined MAX size

void enqueue(int x)                         /// Function to << Enqueue >> or insert the data at the rear of the Queue
{
    if (front == -1 && rear == -1){         // check if the Queue is empty .. i.e. the values of both front and rear are -1
        rear = rear + 1;                    // increment rear,
        arr[rear] = x;                      // add the value inserted by the User within the array at the rear position
        front = front + 1;                  // increment front and make it point to the first element of the Array
        cout << "\n Enqueue Successful." << endl;
    }
    else{                                   // if the Queue already contains some elements,
        rear = rear + 1;                    // increment rear to the next position,
        arr[rear] = x;                      // add the element entered by the user at the new location
        cout << "\n Enqueue Successful." << endl;
    }
    if (rear == MAX-1)                      // if the value of rear has reach the MAX size, prompt the user for Queue Overflow
        cout << "\n\n QUEUE OVERFLOW" << endl;
}

void dequeue()                              /// Function to << Dequeue >> or delete the data from the front of the Queue
{
    if (front == -1 || front > rear)        // if front is still -1 i.e. the Queue is empty or front is greater than rear, prompt the user for Queue Underflow
        cout << "\n\n QUEUE UNDERFLOW" << endl;
    else{                                   // if the queue is full or contains proper rear value,
        int x = arr[front];                   // save the value in some variable to display to the user,
        cout << "\n\n The Dequeued element was : " << x << endl;
        front = front + 1;                  // increment the value of front to the next index in the array
    }
}

void display()								/// Function to << Display >> the Queue
{
    cout << "\n\n";
    for (int i = front; i <= rear; i++)
        cout << "  " << arr[i];
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
