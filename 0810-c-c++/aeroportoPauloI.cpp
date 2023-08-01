#include <iostream>
#include <iomanip>
#include <vector>

// Definir uma estrutura para armazenar os dados
struct Voo {
    int horapartida;
    int minutopartida;
    int duracaohora;
    int duracaominuto;
    int horachegada;
    int minutochegada;
};

// Função para recolher dados
void RecolherDados(Voo* voo) {
    std::cout << "Indique a hora de partida do voo(0-23): ";
    std::cin >> voo->horapartida;

    std::cout << "Indique o minuto de partida do voo(0-59): ";
    std::cin >> voo->minutopartida;

    std::cout << "Indique a duração em horas do voo(0-23): ";
    std::cin >> voo->duracaohora;

    std::cout << "Indique a duração em minutos do voo(0-59): ";
    std::cin >> voo->duracaominuto;

    // Calcular a hora de chegada
    voo->horachegada = voo->horapartida + voo->duracaohora;
    voo->minutochegada = voo->minutopartida + voo->duracaominuto;

    // Verificar se os minutos excedem 59 e ajustar a hora de chegada
    if (voo->minutochegada >= 60) {
        voo->horachegada++;
        voo->minutochegada -= 60;
    }

    // Verificar se a hora excede 23 e ajustar o dia de chegada
    if (voo->horachegada >= 24) {
        voo->horachegada -= 24;
        std::cout << "O voo chega no dia seguinte.\n";
    } else {
        std::cout << "O voo chega no mesmo dia.\n";
    }
}

// Função para mostrar os dados de um voo
void MostrarDados(const Voo* voo) {
    std::cout << "Hora de partida: " << std::setfill('0') << std::setw(2) << voo->horapartida << ":"
              << std::setw(2) << voo->minutopartida << std::endl;
    std::cout << "Hora de chegada: " << std::setfill('0') << std::setw(2) << voo->horachegada << ":"
              << std::setw(2) << voo->minutochegada << std::endl;
}

int main() {
    const int numVoos = 3; // Número de voos

    // matriz de apontadores para Voo
    Voo* matrizVoos[numVoos];

    int opcao;
    do {
        std::cout << "\nMenu Inicial\n";
        std::cout << "1-Recolha de dados (3 voos)\n";
        std::cout << "2-Mostrar os dados com os tempos\n";
        std::cout << "3-Sair\n";
        std::cout << "Digite a sua opção [ ]: ";
        std::cin >> opcao;

        switch (opcao) {
            case 1: // Recolher dados dos 3 voos
                for (int i = 0; i < numVoos; ++i) {
                    matrizVoos[i] = new Voo; /*A destacar o uso do operador new que aloja de forma dinâmica, e agora usando struct 
                    e assim podendo ser considerado como objecto denominado Voo*/
                    std::cout << "\nDados do Voo " << i + 1 << ":\n";
                    RecolherDados(matrizVoos[i]);
                }
                break;

            case 2: // Mostrar dados dos voos
                for (int i = 0; i < numVoos; ++i) {
                    std::cout << "\nDados do Voo " << i + 1 << ":\n";
                    MostrarDados(matrizVoos[i]);
                }
                break;

            case 3: // Sair 
                std::cout << "Fim do programa.\n";
                break;

            default:
                std::cout << "Opção inválida. Tente novamente.\n";
        }
    } while (opcao != 3);

    return 0;
}