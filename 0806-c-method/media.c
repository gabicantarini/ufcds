#include <stdio.h>

int main() {
    float valores[5], soma, media; 

    printf("Insira 5 valores:\n");
    for (int i = 0; i < 5; i++) {
        printf("Valor %d: ", i + 1);
        scanf("%f", &valores[i]);
    }

    printf("\nValores inseridos:\n");
    for (int i = 0; i < 5; i++) {
        printf("Elemento com indice %d ", i + 1);
        printf("valor: %.2f\n", valores[i]);
        soma += valores[i];
    }

    media = soma / 5;
    printf("\nValor médio: %.2f\n", media);
    
    return 0;
}