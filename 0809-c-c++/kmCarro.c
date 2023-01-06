#include <stdio.h>

int main() {
    int quilometros, dias;
    char tipo_carro;
    float montante_devido;
    
    printf("Digite o número de quilómetros efetuados: ");
    scanf("%d", &quilometros);
    
    printf("Digite o número de dias de aluguer: ");
    scanf("%d", &dias);
    
    printf("Digite o tipo de carro (V para Volkswagen, T para Toyota, M para Mercedes): ");
    scanf(" %c", &tipo_carro);
    
    if (quilometros <= 75) {
        quilometros = 0;  // Primeiros 75 quilómetros gratuitos
    } else {
        quilometros -= 75;
    }
    

    
    switch (tipo_carro) {
        case 'V':
            montante_devido = (30 * dias) + (1.20 * quilometros);
            break;
        case 'T':
            montante_devido = (35 * dias) + (1.50 * quilometros);
            break;
        case 'M':
            montante_devido = (60 * dias) + (2.50 * quilometros);
            break;
        default:
            printf("Tipo de carro inválido.\n");
            return 1;  // Terminar o programa com código de erro
    }
    
    printf("O montante devido é %.2f€.\n", montante_devido);
    
    return 0;
}
