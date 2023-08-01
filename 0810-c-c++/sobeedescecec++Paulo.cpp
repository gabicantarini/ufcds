/*
As bibliotecas utilizadas e o que cada uma faz:
<iostream>:
biblioteca padr�o de C++ para entrada e sa�da de dados, e entrada/sa�da de fluxo (streams). 
<cstdlib>:
biblioteca que fornece v�rias fun��es relacionadas � manipula��o de strings, aloca��o de mem�ria din�mica e outras fun��es utilit�rias.
Usada no c�digo para gerar n�meros aleat�rios usando a fun��o rand().
<ctime>:
biblioteca que fornece fun��es e tipos relacionados ao tempo e data.Usada para para o gerador de n�meros aleat�rios com base no tempo actual usando srand(time(NULL)).
<chrono>:
usada para medir o tempo e definir intervalos de tempo. No c�digo, � usada para criar pausas (esperas) entre as mensagens exibidas no jogo.
<thread>:
biblioteca <thread> � usada para criar e gerir threads (tarefas paralelas) no programa. No c�digo, � usada para criar pausas entre as mensagens exibidas no jogo.
<locale>:
biblioteca <locale>  usada para definir a localiza��o (idioma) do programa para "Portuguese", de modo que as mensagens exibidas estejam em portugu�s.
<windows.h> (apenas no Windows):
biblioteca espec�fica do Windows que fornece funcionalidades de sistema, incluindo a fun��o system("cls"), usada para limpar o terminal no Windows.*/

#include <iostream>
#include <cstdlib>
#include <ctime>
#include <chrono>
#include <thread>
#include <locale>
#include <windows.h>
using namespace std;

// Defini��o de constantes auxiliares
#define MIN_NIVEL 1
#define MAX_NIVEL 3
#define MIN_TENTATIVAS 1
#define MAX_TENTATIVAS 3

int gerar_numero_misterio(int min, int max) {  // fun��o para gerar n�meros aleat�rios
    return (rand() % (max - min + 1)) + min;
}

int obter_valor_manual(const string& mensagem) {
    int valor;
    cout << mensagem << ": ";
    cin >> valor;
    return valor;
}

int obter_nivel() {
    int nivel;
    do {
        nivel = obter_valor_manual("Escolha o n�vel (1 a 3)\n1- numero entre 1 e 100\n2- numero entre 1 e 1000\n3- numero entre 1 e 10000");
    } while (nivel < MIN_NIVEL || nivel > MAX_NIVEL);
    return nivel;
}

int obter_max_tentativas() {
    int opcao;
    do {
        cout << "Escolha o n�mero m�ximo de tentativas:" << endl;
        cout << "1. 10 tentativas" << endl;
        cout << "2. 15 tentativas" << endl;
        cout << "3. 20 tentativas" << endl;
        opcao = obter_valor_manual("Op��o");
    } while (opcao < MIN_TENTATIVAS || opcao > MAX_TENTATIVAS);

    switch (opcao) {
        case 1:
            return 10;
        case 2:
            return 15;
        case 3:
            return 20;
        default:
            return 10; // Valor padr�o, caso ocorra algum erro inesperado
    }
}

int obter_numero_misterio(int min, int max) {
    int numero_misterio;
    do {
        numero_misterio = obter_valor_manual("Digite o n�mero mist�rio");
    } while (numero_misterio < min || numero_misterio > max);
    return numero_misterio;
}

void aguardar(int segundos) {
    cout << "Aguarde ";
    for (int i = 0; i < segundos; i++) {
        cout << ".";
        cout.flush();
        this_thread::sleep_for(chrono::seconds(1));
    }
    cout << endl;
}

void jogo() {
    int nivel, numero_misterio, max_tentativas;
    int min_range, max_range;
    cout << "BEM VINDO AO JOGO SOBE E DESCE!!!!!!!!!!!!!!!!" << endl;
    cout << "   TENTE ADIVINHAR O N�MERO   !!!!!!!!!!!!!!!!" << endl;
    cout << "Escolha como deseja definir o n�mero mist�rio:" << endl;
    cout << "1. Introduzir manualmente o n�mero" << endl;
    cout << "Qualquer outro valor para aleat�rio: ";
    int escolha_numero_misterio = 0;
    cin >> escolha_numero_misterio;

    if (escolha_numero_misterio != 1) {
        // Modo autom�tico para o n�mero mist�rio
        numero_misterio = gerar_numero_misterio(1, 10000);
    } else {
        // Modo manual para o n�mero mist�rio
        numero_misterio = obter_numero_misterio(1, 10000);
    }

    // Modo manual para o n�vel e n�mero m�ximo de tentativas
    nivel = obter_nivel();
    max_tentativas = obter_max_tentativas();

    // Definir os limites do intervalo de acordo com o n�vel escolhido
    switch (nivel) {
        case 1:
            min_range = 1;
            max_range = 100;
            break;
        case 2:
            min_range = 1;
            max_range = 1000;
            break;
        case 3:
            min_range = 1;
            max_range = 10000;
            break;
    }

    // Ajustar o n�mero mist�rio para ficar dentro dos limites do n�vel selecionado
    if (escolha_numero_misterio != 1) {
        numero_misterio = gerar_numero_misterio(min_range, max_range);
    } else {
        while (numero_misterio < min_range || numero_misterio > max_range) {
            cout << "N�mero inv�lido! O n�mero mist�rio deve estar entre " << min_range << " e " << max_range << endl;
            numero_misterio = obter_numero_misterio(min_range, max_range);
        }
    }

    int tentativas_restantes = max_tentativas;

    cout << endl;
    cout << "N�vel " << nivel << ": N�mero entre " << min_range << " e " << max_range << endl;
    cout << "N�mero m�ximo de tentativas: " << max_tentativas << endl;

    int palpite;
    do {
        palpite = obter_valor_manual("Digite o seu palpite!!!!");

        if (palpite == numero_misterio) {
            cout << "Parab�ns! Voc� acertou o n�mero mist�rio " << numero_misterio << " em " << max_tentativas - tentativas_restantes + 1 << " tentativas." << endl;
            break;
        } else if (palpite < numero_misterio) {
            cout << "O n�mero mist�rio est� mais alto. ";
        } else {
            cout << "O n�mero mist�rio est� mais baixo. ";
        }

        tentativas_restantes--;
        cout << "Tentativas restantes: " << tentativas_restantes << endl;

        if (tentativas_restantes == 0) {
            cout << "Suas tentativas acabaram! O n�mero mist�rio era: " << numero_misterio << endl;
            break;
        }

    } while (true);

    cout << "Fim do jogo" << endl;
}

int main() {
    setlocale(LC_ALL, "Portuguese");

    srand(time(NULL));
    
    char jogarNovamente;
    do {
        jogo();
         
        cout << "Deseja jogar novamente? (s/S para sim, qualquer outra tecla para sair): ";
        cin >> jogarNovamente;
         system("cls"); // para limpar o terminal em sistemas operativos Windows
    } while (jogarNovamente == 's' || jogarNovamente == 'S');

    aguardar(5);
    return 0;
}
