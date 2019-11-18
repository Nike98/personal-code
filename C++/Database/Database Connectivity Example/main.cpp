///
/**
 *      Write a program to demonstrate the database connectivity.
 */
///

#include<iostream>
#include<winsock.h>
#include<mysql.h>

using namespace std;

int main()
{
    char HOST[] = "localhost";
    char USERNAME[] = "root";
    char DB_NAME[] = "project";   // For Dummy purpose
    MYSQL* conn;
    conn = mysql_init(NULL);
    conn = mysql_real_connect(conn, HOST, USERNAME, "", DB_NAME, 0, NULL, 0);

    if (conn)
        cout << " Database Connection Successful!" << endl;
    else
        cout << " Database Connection Unsuccessful!" << endl;

    return 0;
}
