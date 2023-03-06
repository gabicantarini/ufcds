#include <stdio.h>

int main() {
    int horaPartida;
   

    // Solicitar a hora de partida
    printf("AEROPORTO: INFORMAÇÕES DE EMBARQUE!\n");
    printf("Digite a hora de partida (0-23): ");
    scanf("%d", &horaPartida);

    // Validar a hora de partida
    if (horaPartida < 0 || horaPartida > 23) {
        printf("Hora de partida inválida.\n");
        return 0;
    }



    return 0;
}