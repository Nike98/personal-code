///
/**
 *      WAP to perform Multiplication of 2 Matrices
 */
///

#include <iostream>

using namespace std;

void getData(int first[][10], int second[][10], int rowFirst, int colFirst, int rowSecond, int colSecond);
void multiply(int first[][10], int second[][10], int mult[][10], int rowFirst, int colFirst, int rowSecond, int colSecond);
void display(int mult[][10], int rowFirst, int colSecond);

int main()
{
    int first[10][10], second[10][10], mult[10][10], rowFirst, rowSecond, colFirst, colSecond;

    cout << " Enter the Row for the First Matrix : ";
    cin >> rowFirst;
    cout << " Enter the Column for the First Matrix : ";
    cin >> colFirst;

    cout << "\n\n Enter the Row for the Second Matrix : ";
    cin >> rowSecond;
    cout << " Enter the Column for the Second matrix : ";
    cin >> colSecond;

    // If the column of the First matrix and the row of the
    // Second Matrix don't match make the user perform the
    // input again
    while (colFirst != rowSecond){
        cout << "\n\n Error! Column of the First matrix is not Equal to the Row of the Second." << endl;

        cout << "\n\n Enter the Row for the First Matrix : ";
        cin >> rowFirst;
        cout << " Enter the Column for the First Matrix : ";
        cin >> colFirst;

        cout << "\n\n Enter the Row for the Second Matrix : ";
        cin >> colFirst;
        cout << " Enter the Column for the Second matrix : ";
        cin >> colSecond;
    }

    // Method to get the input of the matrix elements
    getData(first, second, rowFirst, colFirst, rowSecond, colSecond);

    // Method to Multiply the Matrices
    multiply(first, second, mult, rowFirst, colFirst, rowSecond, colSecond);

    // Displaying the Matrix after Multiplication
    display(mult, rowFirst, colSecond);

    return 0;
}


void getData(int first[][10], int second[][10], int rowFirst, int colFirst, int rowSecond, int colSecond){

    cout << "\n\n Enter the Elements of Matrix 1: " << endl;
    for (int i = 0; i < rowFirst; i++){
        for (int j = 0; j < colFirst; j++){
            cin >> first[i][j];
        }
    }

    cout << "\n\n Enter the Elements of Matrix 2: " << endl;
    for (int i = 0; i < rowSecond; i++){
        for (int j = 0; j < colSecond; j++){
            cin >> second[i][j];
        }
    }
}

void multiply(int first[][10], int second[][10], int mult[][10], int rowFirst, int colFirst, int rowSecond, int colSecond){

    // Initializing the Matrix mult[][] to 0
    for (int i = 0; i < rowFirst; i++){
        for (int j = 0; j < colSecond; j++)
            mult[i][j] = 0;
    }

    // Performing Matrix Multiplication and saving in mult[][]
    for (int i = 0; i < rowFirst; i++){
        for (int j = 0; j < colSecond; j++){
            for (int k = 0; k < colFirst; k++)
                mult[i][j] += first[i][k] * second[k][j];
        }
    }
}

void display(int mult[][10], int rowFirst, int colSecond){

    cout << "\n\n Multiplied Matrix : " << endl;
    for (int i = 0; i < rowFirst; i++){
        for (int j = 0; j < colSecond; j++){
            cout << mult[i][j] << " ";
            if (j == colSecond - 1)
                cout << endl << endl;
        }
    }
}
