

/*Pretende-se desenvolver, em C++, um programa que recolhaos dados de uma possívelencomenda.
A empresa fabrica o produto Xna forma de 4modelos (Pequeno, Médio, Grandee MuitoGrande).

PossívelLayout:
Modelo Descrição Quantidade Preço Total
1      Pequeno     10        5      50
2      Médio        5        2      10
-------------------------------------------------------------------------------------------------------
Total     60
Notas:-------------------------------------------------------------------------------------------------------
→A encomenda, no detalhe,deve ter no mínimo 
1 produto e no máximo 
4.→Não podem existirmodelos repetidos.*/

#include <stdio.h>
#include <iostream>
#include <clocale>
#include <cstdio>
#include <windows.h>
#include <cmath>
#include <icmanip>
#include <fstream>



using namespace std; // declarar o namespace std


struct Encomenda{
    int modelo;
    string modelo;
    float peso;
    int quantidade;
    double preco;
}

int Encomenda E[3][7]; // matriz definido globalmente
int escolha;

void menu();
void pedido();
int validarhora(int hora);
int validarminuto(int minuto);
void pausa();
void mostrar();

int main(){
    setlocale(LC_ALL,"Portuguese");
    menu();
    return 0;
}

void menu(){
    do{
    system("cls");
    cout<<"/*** Encomenda CTT ***/"<<endl<<endl;
    cout<<"1-Inserir os dados da encomenda"<<endl;
    cout<<"2-Mostrar os dados da encomenda"<<endl;
    cout<<"3-Sair"<<endl<<endl;
    cout<<"Digite a sua escolha:";
    cin>>escolha;
    switch(escolha){
        case 1:
            pedido();
            break;
        case 2:
            mostrar();
            break;
        case 3:
            exit(0);
        default:
            cout<<endl<<"Opcao inválida."<<endl;
            pausa();
    }
    }while(escolha!=3);
}
void pedido(){
    system("cls");
    cout<<"Recolha de dados da encomendas"<<endl;
    for(int i=0;i<3;i++){
        cout<<"Encomenda Nº"<<(i+1)<<endl;
        cout<<"Partida"<<endl;
        encomenda[i][0]=validarhora(encomenda[i][0]);
        encomenda[i][1]=validarminuto(encomenda[i][1]);
        cout<<"Duração"<<endl;
        encomenda[i][2]=validarhora(encomenda[i][2]);
        encomenda[i][3]=validarminuto(encomenda[i][3]);
        // validação dos dados ok!
        // calcular a chegada e verificar a situação (dia seguinte, ou próprio dia)
        encomenda[i][4]=encomenda[i][0]+encomenda[i][2];
        encomenda[i][5]=encomenda[i][1]+encomenda[i][3];
        if(encomenda[i][5]>59){
            encomenda[i][4]++;
            encomenda[i][5]-=60;
        }
        if(encomenda[i][4]>23){
            encomenda[i][4]-=24;
            encomenda[i][6]=1; //dia seguinte
        }
        else{
            encomenda[i][6]=0;
        }
    }
    pausa();

}

void mostrar(){
    system("cls");
    cout<<endl<<"Listagem dos encomendas"<<endl;
    cout<<"Nº\tHP\tMP\tHD\tMD\tHC\tMC\tSituação"<<endl;
    for(int i=0;i<3;i++){
        cout<<(i+1);
        for(int j=0;j<6;j++){
            cout<<"\t"<<encomenda[i][j];
        }
        if(encomenda[i][6]==0){
            cout<<"\tPróprio dia."<<endl;
        }
        else{
            cout<<"\tDia seguinte."<<endl;
        }
    }
    system("pause");
}

int validarhora(int hora){
    do{
        cout<<"Digite a hora entre 0 e 23:";
        cin>>hora;
        if(hora<0 || hora>23) cout<<endl<<"A hora não é válida !";
    }while(hora<0 || hora>23);
    return(hora);
}

int validarminuto(int minuto){
    do{
        cout<<"Digite os minutos entre 0 e 59:";
        cin>>minuto;
        if(minuto<0 || minuto>59) cout<<endl<<"O minuto não é válido !";
    }while(minuto<0 || minuto>59);
    return(minuto);
}

void pausa(){
    cout<<endl<<"Aguarde 3 seg. sff."<<endl;
    //Sleep(3000);
}
