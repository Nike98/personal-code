///
/**
 *      WAP to show the Implementation of a Linear Queue
 */

#include<stdio.h>
#define MAX 10

typedef struct {
    int arr[MAX];
    int front_element, rear;
} que;

void enque(que *q, int element);
int dequeue(que *q);
int isEmpty(que *q);
int queueTop(que *q);
void display(que *q);

int main()
{
    que q;
    int front_element = 0, rear = -1;
    int element, choice;

    do {
        printf("\n\n *****MAIN MENU*****\n");
        printf(" 1. ENQUEUE\n");
        printf(" 2. DEQUEUE\n");
        printf(" 3. QUEUE TOP\n");
        printf(" 4. DISPLAY\n");
        printf(" 5. EXIT\n");
        printf(" Enter your choice: ");
        scanf("%d", &choice);

        switch(choice){
        case 1:
            printf("\n Enter the Element to be Pushed: ");
            scanf("%d", &element);
            enque(&q, element);
            break;
        case 2:
            element = dequeue(&q);
            if (element == -1)
                printf("\n QUEUE UNDERFLOW\n");
            else
                printf("\n Element Deleted: %d\n", element);
            break;
        case 3:
            element = queueTop(&q);
            if (element == -1)
                printf("\n QUEUE OVERFLOW\n");
            else
                printf("\n Queue Top: %d\n", element);
            break;
        case 4:
            display(&q);
            break;
        }
    } while (choice < 5);
    return 0;
}

void enque(que *q, int element){
    if (q -> rear == MAX - 1){
        printf("\n QUEUE OVERFLOW\n");
        return;
    }

    q -> rear++;
    q -> arr[q -> rear] = element;
}

int dequeue(que *q){
    int x;
    if (isEmpty(q))
        return -1;
    x = q -> arr[q -> front_element];
    q -> front_element--;
    return x;
}

int isEmpty(que *q){
    if (q -> front_element == q -> rear + 1)
        return 1;
    else
        return 0;
}

int queueTop(que *q){
    if (isEmpty(q))
        return -1;
    else
        return q -> arr[q -> front_element];
}

void display(que *q){
    int i;
    if (isEmpty(q)){
        printf("\nQUEUE UNDERFLOW\n");
        return;
    }
    else{
        for (i = q -> front_element; i <= q -> rear; i++)
            printf("%d\n", q -> arr[i]);
    }
}
