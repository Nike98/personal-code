///
/**
 *          Write a program of using the overloading binary operators
 *          +, -, *, / and of Extraction (>>) and Insertion (<<) operator.
 */
///

#include<iostream>

using namespace std;

class Matrix
{
private:
    long m[3][3];
    int row, col;

public:
    int operator == (Matrix);
    Matrix operator + (Matrix);
    Matrix operator - (Matrix);
    Matrix operator * (Matrix);
    Matrix operator / (Matrix);
    friend istream & operator >> (istream &, Matrix &);
    friend ostream & operator << (ostream &, Matrix &);
};

// Function to check whether the order of the Matrix is same or not
int Matrix :: operator == (Matrix check)
{
    if (row == check.row && col == check.col)
        return 1;

    return 0;
}

// Function to Add two Matrices
Matrix Matrix :: operator + (Matrix add)
{
    Matrix temp;

    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            temp.m[i][j] = m[i][j] + add.m[i][j];
        }
        temp.row = row;
        temp.col  = col;
    }
    return temp;
}

// Function to Subtract two Matrices
Matrix Matrix :: operator - (Matrix sub)
{
    Matrix temp;

    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            temp.m[i][j] = m[i][j] - sub.m[i][j];
        }
        temp.row = row;
        temp.col  = col;
    }
    return temp;
}

// Function to Multiply two Matrices
Matrix Matrix :: operator * (Matrix mul)
{
    Matrix temp;
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            temp.m[i][j] = 0;
            for (int k = 0; k < col; k++)
                temp.m[i][j] += m[i][k] * mul.m[k][j];
        }
        temp.row = row;
        temp.col = col;
    }
    return temp;
}

// Function to Divide two Matrices
Matrix Matrix :: operator / (Matrix div)
{
    Matrix temp;
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            temp.m[i][j] = m[i][j] / div.m[i][j];
        }
        temp.row = row;
        temp.col  = col;
    }
    return temp;
}

// Function to get the Elements of the Matrix
istream & operator >> (istream &inp, Matrix &m)
{
    cout << "\n\n Enter the number of Rows : ";
    inp >> m.row;
    cout << " Enter the number of Columns : ";
    inp >> m.col;

    cout << "\n\n Enter the Elements of the Matrix... \n" << endl;
    for (int i = 0; i < m.row; i++){
        for (int j = 0; j < m.col; j++)
            inp >> m.m[i][j];
    }
    return (inp);
}

// Function to Display the Contents of the Matrix
ostream & operator << (ostream &out, Matrix &disp)
{
    out << endl;
    for (int i = 0; i < disp.row; i++){
        for (int j = 0; j < disp.col; j++){
            out << disp.m[i][j];
            out << " ";
        }
        out << endl;
    }
    return out;
}

int main()
{
    Matrix m1, m2, add, sub, mul, div;

    cin >> m1;
    cin >> m2;

    if (m1 == m2){
        add = m1 + m2;          // ADDITION
        sub = m1 - m2;          // SUBTRACTION
        mul = m1 * m2;          // MULTIPLICATION
        div = m1 / m2;          // DIVISION

        cout << "\n\n\n ADDITION of Matrices..." << endl;
        cout << add;

        cout << "\n\n SUBTRACTION of Matrices..." << endl;
        cout << sub;

        cout << "\n\n MULTIPLICATION of Matrices..." << endl;
        cout << mul;

        cout << "\n\n DIVSION of Matrices..." << endl;
        cout << div;
    }
    else
        cout << "\n\n\n Order of the Matrix Input is not Identical." << endl;

    return 0;
}
