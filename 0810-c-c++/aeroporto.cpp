#include <iostream>
#include <string>
#include <cstdlib> // Para utilizar o comando system
#include <locale>
using namespace std;

 

void cabecalho();
void menu();
void partidas();
void tempos();
void resultado_situacao(int i);
int validar_hora(int hora);
int validar_minuto(int minuto);

 

string voos[3] = {"Número 1", "Número 2", "Número 3"};
int hp, mp, hd, md, hc, mc;
string situacao[3];

 

int main() {
	setlocale(LC_ALL, "Portuguese");
    system("cls"); // Limpar a tela no Windows: mas fiz o programa no site onlinegdb e para limpar é clear
    cabecalho();
    menu();
    return 0;
}

 




void cabecalho() {
    cout << "   00   000  000    00   000    00   000  00000  00" << endl << endl;
    cout << "  0  0  0    0  0  0  0  0  0  0  0  0  0   0   0  0" << endl;
    cout << " 0000  000  000   0  0  000   0  0  000    0   0  0" << endl;
    cout << " 0  0  0    0  0  0  0  0     0  0  0  0   0   0  0" << endl;
    cout << " 0  0  000  0   0  00   0      00   0   0  0    00" << endl << endl;
}

 

void menu() {
    int number;
    cout << "***** Programa Voar *****" << endl;
    cout << "Digite 1 para recolha de dados" << endl;
    cout << "Digite 2 para mostrar os dados com os tempos" << endl;
    cout << "Digite 3 para sair" << endl;
    cout << "Qual a sua escolha? ";
    cin >> number;

 

    switch (number) {
        case 1:
            system("cls"); // Limpar a tela no Windows
            cabecalho();
            partidas();
            menu();
            break;

 

        case 2:
            system("cls"); // Limpar a tela no Windows
            tempos();
            menu();
            break;

 

        case 3:
            cout << "EXIT AEROPORTO" << endl;
            cout << "SEE YOU IN YOUR NEXT FLIGHT" << endl;
            break;

 

        default:
            cout << "Escolha inválida!" << endl;
            menu();
            break;
    }
}

 

int validar_hora(int hora) {
    return (hora >= 0 && hora <= 23);
}

 

int validar_minuto(int minuto) {
    return (minuto >= 0 && minuto <= 59);
}

 

void partidas() {
    for (int i = 0; i < 3; i++) {
        cout << "\nVoo: " << voos[i] << endl;
        cout << "PARTIDA" << endl;
        do {
            cout << "HORA: ";
            cin >> hp;
        } while (!validar_hora(hp));
        do {
            cout << "MINUTO: ";
            cin >> mp;
        } while (!validar_minuto(mp));
        cout << "\nDURAÇÃO" << endl;
        do {
            cout << "HORA: ";
            cin >> hd;
        } while (!validar_hora(hd));
        do {
            cout << "MINUTO: ";
            cin >> md;
        } while (!validar_minuto(md));
        hc = hp + hd;
        mc = mp + md;
        resultado_situacao(i);
    }
}

 

void resultado_situacao(int i) {
    if (mc > 59) {
        hc++;
        mc -= 60;
    }
    if (hc > 23) {
        hc -= 24;
        situacao[i] = "Dia seguinte.";
    } else {
        situacao[i] = "Mesmo dia.";
    }
}

 

void tempos() {
    cout << "------------------------------------------------------------------------------" << endl;
    cout << " Nº        Hora Part. Min Par. Hora Dur. Min Dur. Hora Cheg. Min Che.  Situação" << endl;
    for (int i = 0; i < 3; i++) {
        cout << " " << voos[i] << "      " << hp << "         " << mp << "        " << hd << "     " << md
    << "     " << hc << "     " << mc << "      " << situacao[i] << endl;
    }
    cout << "------------------------------------------------------------------------------" << endl;
}