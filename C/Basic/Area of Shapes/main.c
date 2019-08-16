///
/**
 *     WAP to compute Area of the Shapes like
 *     Square, Circle, Rectangle, Triangle.
 *
 *     Take inputs from the User and Use
 *     Switch Case block to give the choice
 *     to the user for selection of the Shape.
 */
///
#include<stdio.h>
//#include<conio.h>

/* Global declaration of PI value made to be
 * used throughout the main
 * and (if) any other functions
 */
float pie = 3.142857;

int main()
{
    int choice;
    float length, breadth, height, side, radius, area;
    //clrscr();
    printf("*****MAIN MENU*****");
    printf("\n\n 1. Square");
    printf("\n 2. Circle");
    printf("\n 3. Rectangle");
    printf("\n 4. Triangle");
    printf("\n 5. Exit");
    printf("\n Enter your choice: ");
    scanf("%d", &choice);

    switch(choice){
    case 1:
        printf("\n\n You chose for Square...");
        printf("\n Enter the side of the Square: ");
        scanf("%f", &side);
        area = side * side;
        printf("\n\n The Area of the Square = %f", area);
        break;
    case 2:
        printf(" You chose for Circle...");
        printf("\n Enter the Radius for the Circle: ");
        scanf("%f", &radius);
        area = pie * (radius * radius);
        printf("\n\n The Area of the Circle = %f", area);
        break;
    case 3:
        printf("\n\n You chose for Rectangle...");
        printf("\n Enter the Length: ");
        scanf("%f", &length);
        printf("\n Enter the Breadth: ");
        scanf("%f", &breadth);
        area = length * breadth;
        printf("\n\n The Area of the Rectangle = %f", area);
        break;
    case 4:
        printf("\n\n You chose for Triangle...");
        printf("\n Enter the Height: ");
        scanf("%f", &height);
        printf("\n Enter the Breadth: ");
        scanf("%f", &breadth);
        area = 0.5 * (height * breadth);
        printf("\n\n The Area of the Rectangle = %f", area);
        break;
    default:
        printf("\n\n You chose to EXIT...");
        break;
    }
  //getch();
  return 0;
}
