///
/**
 *      WAP for Addition, Subtraction and
 *      Multiplication of 2 Matrices.
 */
///

#include<stdio.h>
#include<conio.h>

void add(int size1, int size2, int arr1[size1][size2], int arr2[size1][size2]);
void subtract(int size1, int size2, int arr1[size1][size2], int arr2[size1][size2]);
void multiply(int size1, int size2, int arr1[size1][size2], int arr2[size1][size2]);
void display(int size1, int size2, int arr[size1][size2]);

int main()
{
    //clrscr();
    int row_size, col_size;

    // Enter the Size of both the Arrays
    printf("\n Enter the Row Size of the Array: ");
    scanf("%d", &row_size);

    printf("\n Enter the Column Size of the Array: ");
    scanf("%d", &col_size);

    int first[row_size][col_size], second[row_size][col_size], i, j;

    printf("\n Enter the Elements of the 1st Array:\n");
    for (i = 0; i < row_size; i++){
        for (j = 0; j < col_size; j++){
            scanf("%d",&first[i][j]);
        }
    }

    printf("\n Enter the Elements of the 2nd Array:\n");
    for (i = 0; i < row_size; i++){
        for (j = 0; j < col_size; j++){
            scanf("%d",&second[i][j]);
        }
    }

    printf("\n\n The values entered are: \n");
    printf(" FIRST ARRAY\n");
    display(row_size, col_size, first);

    printf("\n SECOND ARRAY\n");
    display(row_size, col_size, second);

    add(row_size, col_size, first, second);
    subtract(row_size, col_size, first, second);
    multiply(row_size, col_size, first, second);
    return 0;
}

void add(int size1, int size2, int arr1[size1][size2], int arr2[size1][size2])
{
    int sum[size1][size2], row, col;
    for (row = 0; row < size1; row++){
        for (col = 0; col < size2; col++){
            sum[row][col] = arr1[row][col] + arr2[row][col];
        }
    }

    printf("\n\n ADDITION\n");
    for (row = 0; row < size1; row++){
        for (col = 0; col < size2; col++){
            printf(" %d", sum[row][col]);
        }
        printf("\n");
    }
}

void subtract(int size1, int size2, int arr1[size1][size2], int arr2[size1][size2])
{
    int sum[size1][size2], row, col;
    for (row = 0; row < size1; row++){
        for (col = 0; col < size2; col++){
            sum[row][col] = arr1[row][col] - arr2[row][col];
        }
    }

    printf("\n\n SUBTRACTION\n");
    display(size1, size2, sum);
}

void multiply(int size1, int size2, int arr1[size1][size2], int arr2[size1][size2])
{
    int sum[size1][size2], row, col;
    for (row = 0; row < size1; row++){
        for (col = 0; col < size2; col++){
            sum[row][col] = arr1[row][col] * arr2[row][col];
        }
    }

    printf("\n\n MULTIPLICATION\n");
    display(size1, size2, sum);
}

void display(int size1, int size2, int arr[size1][size2])
{
    int row, col;
    for (row = 0; row < size1; row++){
        for (col = 0; col < size2; col++){
            printf(" %d", arr[row][col]);
        }
        printf("\n");
    }
}
