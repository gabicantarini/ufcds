//Show  values in for cicle

#include <stdio.h>
//#include <string.h>
#include <stdlib.h>
int main()
{

    int littleMatrix[10];
    littleMatrix[0]=47;
    littleMatrix[1]=33;
    
    printf("The little indice Matrix %d is %d.",0,littleMatrix[0] );
    // Fill matrix with rand between 1 e 100
    for (int i = 2; i < 10; i++) {
        littleMatrix[i] = rand() % 100 + 1;
    }

    // Show 10 values with loop for ???
    printf("\nThe 10 values in the littleMatrix are:\n"); 
    for (int i = 0; i < 10; i++) {
        printf("%d ", littleMatrix[i]);
    }

    return 0;
}