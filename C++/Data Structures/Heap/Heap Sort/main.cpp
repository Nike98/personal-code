///
/**
 *      WAP to Heap Sort with the following operations:
 *          1. Create
 *          2. Display
 *          3. Delete
 *          4. Sort
 */
///

#include<iostream>
#include<stdlib.h>
#include<conio.h>

using namespace std;

const int size = 6;
int a[size];
int parent_root = 0;
int MAX = 0, left_child = 0, right_child = 0;

void reheapup(int a[], int node)
{
    if (node > 0) {
        parent_root = (node-1)/2;
        if (a[node] > a[parent_root]) {
            int temp = a[node];
            a[node] = a[parent_root];
            a[parent_root] = temp;
        }
        reheapup(a, parent_root);
    }
    else return;
}

void insertHeap(int a[], int *last, int data)
{
    if (*last == size-1) {
        cout << "\n\n Heap is Full!" << endl;
        return;
    }

    *last = *last + 1;
    a[*last] = data;

    cout << "\n\n The data to be inserted is : " << a[*last] << endl;
    reheapup(a, *last);
    cout << " Data Insertion Successful!" << endl;
    return;
}

void reheapdown(int a[], int root, int last)
{
    left_child = root*2+1;
    right_child = root*2+2;

    if (left_child <= last) {
        if (left_child == last)
            MAX = left_child;
        else {
            if (a[left_child] < a[right_child])
                MAX = right_child;
            else
                MAX = left_child;
        }

        if (a[root] < a[MAX]) {
            int temp = a[root];
            a[root] = a[MAX];
            a[MAX] = temp;
            reheapdown(a, MAX,last);
        }
    }
    return;
}

int deleteHeap(int a[], int*last, int root)
{
    int dataout = a[root];
    a[0] = a[*last];
    a[*last] = NULL;
    *last = *last-1;
    reheapdown(a, 0, *last);
    return dataout;
}

void heapSort(int a[], int total)
{
    int n = total;

    while (n >= 0) {
        int temp = a[0];
        a[0] = a[n];
        a[n] = temp;
        n--;
        reheapdown(a, 0, n);
    }
    return;
}

int main()
{
    int choice, del;
    int last = -1, j = -1, last1 = -1, total = 0;

    for (int i = 0; i < size; i++)
        a[i] = 0;

    do {
        cout << "\n\n ****** << HEAP SORT >> ******\n\n"
             << " 1. Create\n"
             << " 2. Delete\n"
             << " 3. Heap Sort\n"
             << " 4. Display\n"
             << " 5. Exit\n\n"
             << " Enter your choice : ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                cout << "\n\n Enter the data: ";
                j++;
                cin >> a[j];
                insertHeap(a, &last, a[j]);
                last1 = j;
                total = j;
                break;
            case 2:
                del = deleteHeap(a, &last1, 0);
                total = last1;
                cout << "\n\n The data Deleted from the Heap is : " << del << endl;
                break;
            case 3:
                heapSort(a, total);
                cout << "\n\n Heap Sort completed successfully." << endl;
                break;
            case 4:
                cout << "\n\n The current Heap is : \n\n";
                for (int i = 0; i < size; i++)
                    cout << "\t" << a[i];
                cout << "\n";
                break;
        }
        cout << "\n\n Press Enter..." << endl;
        getch();
        system("cls");
    } while (choice < 5);
    return 0;
}





































