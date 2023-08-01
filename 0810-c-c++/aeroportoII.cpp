#include <stdio.h>
#include <stdlib.h>
#include <cstdio>
#include <string>
#include <iostream>
#include <clocale>
#include <unistd.h>

using namespace std;

  
void cabecalho();
void menu();
void partidas();
void tempos();
void resultado_situacao();
int validar_hora(int hora);
int validar_minuto(int minuto);
string voos[3] = {"Número 1", "Número 2", "Número 3"};
string flight = voos[3];
int hp, mp, hd, md, hc, mc;
string situacao[2];

int main(){
   
    system("clear");
    cabecalho();
    menu();

    return(0);    
}

void cabecalho(){
   cout<<"   00   000  000    00   000    00   000  00000  00\n" << endl << endl;
   cout<<"  0  0  0    0  0  0  0  0  0  0  0  0  0   0   0  0 \n";
   cout<< " 0000  000  000   0  0  000   0  0  000    0   0  0\n";
   cout<< " 0  0  0    0  0  0  0  0     0  0  0  0   0   0  0\n";
   cout<< " 0  0  000  0   0  00   0      00   0   0  0    00 \n\n\n";
}

void menu(){
    int number = 3;
    cout<<"***** Programa Voar *****\n";
    cout<<"Digite 1 para recolha de dados\n";
    cout<<"Digite 2 para mostrar os dados com os tempos\n";
    cout<<"Digite 3 para sair\n";
    cout<<"Qual a sua escolha? \n";
    cin>>number; 
    
    
    switch (number) {
        case 1:
        {
            system("clear");
            cabecalho();
            partidas(); 
            system("clear");
            menu();
        }
            break;
            
        case 2:
            system("clear");
            tempos();
            break;
        case 3:
            cout<<"EXIT AEROPORTO\n"; 
            system("clear");
            cout<<"SEE YOU IN YOUR NEXT FLIGHT\n";
            break;
    }
    
}

int validar_hora(int hora){
    if(hora<0 || hora>23){
        return(0);
    }
    else{
        return(1);
    }
}

int validar_minuto(int minuto){
    if(minuto<0 || minuto>59){
        return(0);
    }
    else{
        return(1);
    }
}

void partidas() {
   
    for (int i = 0; i < 3; i++) {
        //setlocale(LC_ALL, "");
        cout << "\nVoo: " << voos[i] << endl;
        cout << "PARTIDA\n\n";
        // validar hora da partida
        do {
            cout << "HORA:";
            cin >> hp;
        } while (validar_hora(hp) == 0);
        // validar minuto da partida
        do {
            cout << "MINUTO:";
            cin >> mp;
        } while (validar_minuto(mp) == 0);
        cout << "\nDURAÇÃO\n\n";
        // validar hora da duração
        do {
            cout << "HORA:";
            cin >> hd;
        } while (validar_hora(hd) == 0);
        // validar minuto da duração
        do {
            cout << "MINUTO:";
            cin >> md;
        } while (validar_minuto(md) == 0);
        // calcular a hora e o minuto da chegada
        hc = hp + hd;
        mc = mp + md;

    }
}

void resultado_situacao() {
    for (int i = 0; i < 3; i++) {
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
    
}

void tempos() {
    int i=0;
    cout<<"------------------------------------------------------------------------------\n";
    cout<<" Nº        Hora Part. Min Par. Hora Dur. Min Dur. Hora Cheg. Min Che.  Situação\n";
    for(i=0; i<3; i++){
    cout<< " "<<voos[i]<< "      "<<hp<<"         "<<mp<<"         "<<hd<<"         "<<md<<"          "<<hc<<"       "<<mc<<"      "<<situacao;
    cout<< "            \n", 
           "            \n", 
           "            \n";
    };
    cout<<"\n------------------------------------------------------------------------------";
}