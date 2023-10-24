#include <iostream>

class Calculadora {
private:
    float valor1;
    float valor2;

public:
    Calculadora(float v1, float v2) {
        valor1 = v1;
        valor2 = v2;
    }

    float Somar() {
        return valor1 + valor2;
    }

    float Subtrair() {
        return valor1 - valor2;
    }

    float Multiplicar() {
        return valor1 * valor2;
    }

    float Dividir() {
        if (valor2 != 0) {
            return valor1 / valor2;
        } else {
            std::cout << "Erro: Divisão por zero!" << std::endl;
            return 0.0; // Neste caso, retornamos 0 como resultado de erro
        }
    }
};

int main() {
    float num1, num2;

    std::cout << "Digite o primeiro número: ";
    std::cin >> num1;
    std::cout << "Digite o segundo número: ";
    std::cin >> num2;

    Calculadora calc(num1, num2);

    char operacao;
    bool continuar = true;

    while (continuar) {
        std::cout << "Escolha a operação (s para soma, u para subtração, m para multiplicação, d para divisão, q para sair): ";
        std::cin >> operacao;

        switch (operacao) {
            case 's':
                std::cout << "Resultado da soma: " << calc.Somar() << std::endl;
                break;
            case 'u':
                std::cout << "Resultado da subtração: " << calc.Subtrair() << std::endl;
                break;
            case 'm':
                std::cout << "Resultado da multiplicação: " << calc.Multiplicar() << std::endl;
                break;
            case 'd':
                std::cout << "Resultado da divisão: " << calc.Dividir() << std::endl;
                break;
            case 'q':
                continuar = false;
                break;
            default:
                std::cout << "Operação inválida." << std::endl;
                break;
        }
    }

    return 0;
}
