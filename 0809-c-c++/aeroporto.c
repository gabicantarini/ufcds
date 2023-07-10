#include <stdio.h>

int main() {
    int horaPartida, minutoPartida, horaDuracao, minutoDuracao;
    int horaChegada, minutoChegada, diaChegada;

    // Solicitar a hora de partida
    printf("AEROPORTO: INFORMAÇÕES DE EMBARQUE!\n");
    printf("Digite a hora de partida (0-23): ");
    scanf("%d", &horaPartida);



    // Exibir a hora e o minuto de chegada
    printf("\nAEROPORTO: DIA E HORA DE CHEGADA!\n");
    printf("Hora de chegada: %02d:%02d\n", horaChegada, minutoChegada);

    // Exibir se a chegada é no mesmo dia ou no dia seguinte
    if (diaChegada == 0) {
        printf("Chegada no mesmo dia.\n");
    } else {
        printf("Chegada no dia seguinte.\n");
    }


    return 0;
}