#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{

    int littleMatrix[10], i;
    srand(time(NULL));
    

    for (i = 0; i < 5; i++) {
        printf("\ndê um valor %d: ", i);
        scanf("%d",&littleMatrix[i]);
    }
    
    printf("\nShow range values: ");
    for (i = 0; i < 5; i++) {
        littleMatrix[i] = rand() % 12;
        printf("Little Matrix [%d] \n ",littleMatrix[i]);
    }
    
    return 0;

}
