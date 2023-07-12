#include <stdio.h>
//Add a name parameter of type char (string) to myFunction.

void myFunction (char name[]) {
  printf("HEllo %s\n", name);
}

int main() {
  
    myFunction("Liam");
    myFunction("Gabi");
    myFunction("Ceci");

    return 0;
}