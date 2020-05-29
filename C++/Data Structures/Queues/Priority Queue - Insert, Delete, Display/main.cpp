///
/**
 *      WAP to Insert, Delete and Display jobs in a Priority Queue
 */
///

#include<iostream>
#include<stdlib.h>

using namespace std;

const int MAX = 5;
int count = -1;

struct node
{
    int job_no;
    int priority_no;
    int order_no;
};

struct queue
{
    struct node arr[MAX];
    int front;
    int rear;
};

class pqueue
{
public:
    void initi(struct queue *p)
    {
        p->front = -1;
        p->rear = -1;

        for (int i = 0; i < MAX; i++) {
            p->arr[i].job_no = 0;
            p->arr[i].priority_no = 0;
            p->arr[i].order_no = 0;
        }
    }

    void add(queue *p, node new_node)
    {
        struct node temp;

        if (p->rear == MAX-1) {
            cout << "\n\n QUEUE is Full." << endl;
            return;
        }

        p->rear++;
        p->arr[p->rear] = new_node; // inserting the node at the position pointed by the rear

        if (p->front == -1)
            p->front = 0;   // the first node

        for (int i = p->front; i <= p->rear; i++) {
            for (int j = i+1; j <= p->rear; j++) {
                if (p->arr[i].priority_no > p->arr[j].priority_no) {
                    // swapping
                    temp = p->arr[i];
                    p->arr[i] = p->arr[j];
                    p->arr[j] = temp;
                }

                if (p->arr[i].priority_no == p->arr[j].priority_no) {
                    if (p->arr[i].order_no > p->arr[j].order_no) {
                        temp = p->arr[i];
                        p->arr[i] = p->arr[j];
                        p->arr[j] = temp;
                    }
                }
            }
        }
    }

    void del(struct queue *p)
    {
        if (p->front == -1) {
            cout << "\n\n QUEUE is Empty." << endl;
            return;
        }

        int value = p->arr[p->front].job_no;

        // actual deletion
        p->arr[p->front].job_no = NULL;
        p->arr[p->front].priority_no = NULL;
        p->arr[p->front].order_no = NULL;

        cout << "\n\n The Job Deleted is : " << value << endl;

        if (p->front == p->rear)
            p->front = p->rear = -1;
        else
            p->front = p->front + 1;
    }

    void display(struct queue *p)
    {
        int x = 0;

        if (p->rear == -1)
            cout << "\n\n QUEUE is Empty." << endl;

        cout << "\n\n";
        while (x <= p->rear) {
            cout << "\n The Job is : " << p->arr[x].job_no
                 << " and the Priority is : " << p->arr[x].priority_no;
            x++;
        }
        cout << "\n\n";
    }
};

int main()
{
    struct queue pq, *ptr;
    struct node dt, temp;
    int choice, num;
    int i = 0, j = 0;

    pqueue obj;
    ptr = &pq;

    obj.initi(ptr);

    do {
        cout << "\n\n ****** << PRIORITY QUEUE >> ******\n\n"
             << " 1. Insert Jobs\n"
             << " 2. Delete Jobs\n"
             << " 3. Display Queue\n"
             << " 4. Exit\n\n"
             << " Enter your choice: ";
        cin >> choice;

        switch (choice){
        case 1:
            cout << "\n Enter the Job Number : ";
            cin >> dt.job_no;
            cout << "\n Enter the Priority for the Job : ";
            cin >> dt.priority_no;

            dt.order_no = j+1;
            obj.add(ptr, dt);
            break;
        case 2:
            obj.del(ptr);
            break;
        case 3:
            obj.display(ptr);
            break;
        }
    } while (choice < 4);
    return 0;
}



































