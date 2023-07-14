#include <stdio.h>

//Fill in tje missing part to create a Car structure

struct Car {
    char brand[50];
    char model[50];
    int year;
};

int main() {

    struct Car car1 = {"BMW", "X5", 1999};
    printf("Car info: %d\n", car1);

    return 0;
};

