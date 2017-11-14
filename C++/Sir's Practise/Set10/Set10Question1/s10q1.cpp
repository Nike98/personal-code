///
/**
  *##############################################
  *
  *       WAP for Prefix and Postfix type
  *         of auto increment operator.
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

int main ()
{
    int pre1 = 1;
    int pre2 = ++pre1;                  /// Prefix type of Auto Increment
    int pre3 = ++ ++pre1;
    int post1 = 1;
    int post2 = post1++;                /// Postfix type of Auto increment

    cout << " The values are : " << endl << endl;
    cout << " pre2 = " << pre2 << endl;
    cout << " pre3 = " << pre3 << endl << endl;

    cout << " post2 = " << post2 << endl;

    return 0;
}
