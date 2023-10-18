#include <stdio.h>
#include <stdlib.h>
#include <cstdio>
#include <string>
#include <iostream>
#include <clocale>
#include <unistd.h>

#include <iostream>

class Calculadora {
private:
    float numero1;
    float numero2;

public:
    Calculadora() {
        numero1 = 0.0;
        numero2 = 0.0;
    }

    void setNumeros(float num1, float num2) {
        numero1 = num1;
        numero2 = num2;
    }

    float soma() {
        return numero1 + numero2;
    }

    float subtracao() {
        return numero1 - numero2;
    }

    float multiplicacao() {
        return numero1 * numero2;
    }

    float divisao() {
        if (numero2 != 0) {
            return numero1 / numero2;
        } else {
            std::cout << "Erro: Divisão por zero!" << std::endl;
            return 0.0;
        }
    }
};

int main() {
    Calculadora calculadora;
    float num1, num2;
    char opcao;

    do {
        std::cout << "Digite o primeiro número: ";
        std::cin >> num1;
        std::cout << "Digite o segundo número: ";
        std::cin >> num2;

        calculadora.setNumeros(num1, num2);

        std::cout << "Escolha uma operação:\n";
        std::cout << "1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n5. Sair\n";
        std::cin >> opcao;

        switch (opcao) {
            case '1':
                std::cout << "Resultado da Soma: " << calculadora.soma() << std::endl;
                break;
            case '2':
                std::cout << "Resultado da Subtração: " << calculadora.subtracao() << std::endl;
                break;
            case '3':
                std::cout << "Resultado da Multiplicação: " << calculadora.multiplicacao() << std::endl;
                break;
            case '4':
                std::cout << "Resultado da Divisão: " << calculadora.divisao() << std::endl;
                break;
            case '5':
                std::cout << "Encerrando o programa." << std::endl;
                break;
            default:
                std::cout << "Opção inválida. Tente novamente." << std::endl;
        }
    } while (opcao != '5');

    return 0;
}
