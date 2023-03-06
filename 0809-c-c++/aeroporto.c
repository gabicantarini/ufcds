#include <stdio.h>

int main() {
    int horaPartida, minutoPartida, horaDuracao, minutoDuracao;
    int horaChegada, minutoChegada, diaChegada;

    // Solicitar a hora de partida
    printf("AEROPORTO: INFORMAÇÕES DE EMBARQUE!\n");
    printf("Digite a hora de partida (0-23): ");
    scanf("%d", &horaPartida);

    // Validar a hora de partida
    if (horaPartida < 0 || horaPartida > 23) {
        printf("Hora de partida inválida.\n");
        return 0;
    }
    // Solicitar o minuto de partida
    printf("Digite o minuto de partida (0-59): ");
    scanf("%d", &minutoPartida);

    // Validar o minuto de partida
    if (minutoPartida < 0 || minutoPartida > 59) {
        printf("Minuto de partida inválido.\n");
        return 0;
    }

    // Solicitar a hora de duração
    printf("Digite a hora de duração (0-23): ");
    scanf("%d", &horaDuracao);

    // Validar a hora de duração
    if (horaDuracao < 0 || horaDuracao > 23) {
        printf("Hora de duração inválida.\n");
        return 0;
    }

    // Solicitar o minuto de duração
    printf("Digite o minuto de duração (0-59): ");
    scanf("%d", &minutoDuracao);

    // Validar o minuto de duração
    if (minutoDuracao < 0 || minutoDuracao > 59) {
        printf("Minuto de duração inválido.\n");
        return 0;
    }

    // Calcular a hora e o minuto de chegada
    horaChegada = horaPartida + horaDuracao;
    minutoChegada = minutoPartida + minutoDuracao;

    // Verificar se houve passagem para o próximo dia
    if (minutoChegada >= 60) {
        minutoChegada -= 60;
        horaChegada++;
    }
    if (horaChegada >= 24) {
        horaChegada -= 24;
        diaChegada = 1;
    } else {
        diaChegada = 0;
    }

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