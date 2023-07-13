// Crie uma função em C, do tipo void, que receba um valor float e uma percentagem de desconto e apresente o valor do desconto.

#include <stdio.h>

void calcularDesconto(float valor, float percentual) {
    float desconto = valor * (percentual / 100.0);
    
    printf("O valor do desconto é: %.2f\n", desconto);
   
}


int main() {
    float valor, percentual;
    printf("Digite o valor: ");
    scanf("%f", &valor);
    printf("Digite a porcentagem de desconto: ");
    scanf("%f", &percentual);

    calcularDesconto(valor, percentual);

    return 0; 
}

