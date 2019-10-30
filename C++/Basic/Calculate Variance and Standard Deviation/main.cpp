///
/**
 *      WAP to calculate Variance and Standard Deviation of n numbers.
 *
 *      Variance = 1/n summation n=i to (xi-x')^2
 *      Standard Deviation = sqrt(Variance)
 *
 *      where,
 *          x' = 1/n summation n=i to n(xi)
 */
///

#include<iostream>
#include<math.h>

using namespace std;

int main()
{
    int size;
    float arr[100];
    float sum = 0, xi_sqr = 0;

    cout << " Enter the Size : ";       // Getting the Size of the Data
    cin >> size;

    cout << "\n Enter the Elements : " << endl; // Getting the Elements Input from the User
    for (int i = 0; i < size; i++)
        cin >> arr[i];

    for (int i = 0; i < size; i++)
        sum += arr[i];  //Calculating the Sum of xi

    cout << "\n\n Summation of xi : " << sum << endl;   // Printing the Sum of xi

    for (int i = 0; i < size; i++)
        xi_sqr += pow(arr[i], 2);   // Calculating the Summation of xi Square

    cout << " Summation of xi Square : " << xi_sqr << endl; // Printing the value of xi Square

    float sum_xi_sqr = xi_sqr / size;   // Calculating the Sum of xi square divided by size

    cout << "\n Summation of xi square divided by Size : " << sum_xi_sqr << endl;   // Printing the result of the previous calculation

    // Calculating the value of xi by size the whole Square

    float xi_by_size = sum / size;
    float ans_whole_sqr = pow(xi_by_size, 2);

    // Printing the above calculation
    cout << " Summation of xi by size the whole Square : " << ans_whole_sqr << endl;

    // Calculating the difference between the two answers (sum_xi_sqr - ans_whole_sqr)
    float diff = sum_xi_sqr - ans_whole_sqr;
    cout << "\n The difference of the above two answers : " << diff << endl;

    // Calculating the Standard Deviation and printing it
    float sd = sqrt(diff);
    cout << "\n\n The Standard Deviation is : " << sd << endl;

    // Printing the Variance
    cout << "\n Variance : " << pow(sd, 2) << endl;

    return 0;
}
