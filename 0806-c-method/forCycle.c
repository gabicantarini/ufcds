
/*
    1) criar um vector chamado exemplo, com 5 elementos inteiros

    2) criar um ciclo for para o utilizador introduzir os valores

    3) criar um ciclo for para mostrar os valores
*/

#include <stdio.h>

int main() {
    int exemplo[5];  // Criar um vetor chamado "exemplo" com 5 elementos inteiros

    // Ciclo for para o utilizador introduzir os valores
    printf("Introduza os valores:\n");
    for (int i = 0; i < 5; i++) {
        printf("Valor %d: ", i + 1);
        scanf("%d", &exemplo[i]);
    }

    // Ciclo for para mostrar os valores
    printf("Valores introduzidos:\n");
    for (int i = 0; i < 5; i++) {
        printf("%d ", exemplo[i]);
    }
    printf("\n");

    return 0;
}


