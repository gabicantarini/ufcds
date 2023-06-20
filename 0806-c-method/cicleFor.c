//Show  values in for cicle

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    int littleMatrix[10];
    srand(time(NULL));
    
    // Fillout range between 1 n 100
    for (int i = 0; i < 11; i++) {
        littleMatrix[i] = rand() % 100;
        printf("Little Matrix [%d]: %d\n ",littleMatrix[i]);
    }

}