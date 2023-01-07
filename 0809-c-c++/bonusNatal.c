#include <stdio.h>

int main() {
    int idade, antiguidade, filhos, bonus = 0;
    
    printf("Digite a idade (em anos) do colaborador: ");
    scanf("%d", &idade);
    
    printf("Digite a antiguidade do colaborador: ");
    scanf("%d", &antiguidade);
    
    printf("Digite o número de filhos do colaborador: ");
    scanf("%d", &filhos);
    
    // Bónus da idade
    if (idade > 45) {
        bonus += (idade - 45) * 5;
    }
    
    // Bónus da antiguidade
    if (antiguidade <= 10) {
        bonus += antiguidade * 10;
    } else {
        bonus += 100 + (antiguidade - 10) * 20;
    }
    
    // Bónus dos filhos
    if (filhos <= 3) {
        bonus += filhos * 25;
    } else {
        bonus += 75;
    }
    
    printf("O valor do bónus é %d €.\n", bonus);
    
    return 0;
}