///
/**
 *      Program to implement Depth First Search traversal of graphs
 */
///

#include<iostream>

#define M 15
#define N 15

using namespace std;

int adjacent[M][N];
int visited[15];
int stk[15];
int top;
int vertex;

void adjacency(int adjacent[M][N], int vertices, int edges)
{
    int a, b;

    for (int i = 0; i < vertices; i++) {
        for (int j = 0; j < edges; j++)
            adjacent[i][j] = 0;
    }

    for (int i = 0; i < edges; i++) {
        cout << "\n Enter an edge: ";
        cin >> a >> b;
        adjacent[a][b] = 1;
        adjacent[b][a] = 1;
    }

    cout << "\n\n Adjacency Matrix..." << endl;

    for (int i = 0; i < vertices; i++) {
        for (int j = 0; j < vertices; j++)
            cout << " " << adjacent[i][j];
        cout << endl;
    }
}

void DFS(int adjacenct[M][N], int vertices)
{
    for (int i = 0; i < 15; i++)
        visited[i] = 0;

    cout << "\n\n Enter initial vertex : ";
    cin >> vertex;
    cout << "\n\n ORDER O VISITED VERTICES...\n";
    cout << vertex << " ";

    visited[vertex] = 1;

    for (int k = 1; k < vertices; k++) {
        for (int j = 0; j < vertices; j++) {
            if (adjacenct[vertex][j] == 1 && visited[j] == 0) {
                visited[j] = 1;
                stk[top] = j;
                top++;
            }
        }
        vertex = stk[--top];
        cout << " " << vertex;
    }
}

int main()
{
    int vertices, edges, adjacency_list_created = 0;
    int choice = 0;
    int a, b;

    do {
        cout << "\n\n ***** << DFS >> *****\n\n"
             << " 1. Create Adjacency List\n"
             << " 2. DFS Traversal\n"
             << " 3. Exit\n"
             << "\n Enter your choice: ";
        cin >> choice;

        switch(choice)
        {
        case 1:
            cout << "\n Enter number of vertices and edges: ";
            cin >> vertices >> edges;

            adjacency(adjacent, vertices, edges);
            adjacency_list_created = 1;
            break;

        case 2:
            if (adjacency_list_created == 0)
                cout << "\n\n You need to create an Adjacency List first." << endl;
            else
                DFS(adjacent, vertices);
            break;
        }
    } while (choice < 3);
    return 0;
}
