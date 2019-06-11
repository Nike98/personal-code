#include <stdio.h>

int main()
{
  int row, col, n;

  printf("Enter the number of lines = ");
  scanf("%d", &n);
  printf("\n");

  for(row = n ; row > 0 ; row--)
  {
    for(col = 1 ; col <= row ; col++)
    {
        printf(" X");
    }
    printf("\n");
  }

  return 0;
}
