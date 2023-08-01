#include <iostream>
#include <clocale>
#include <cstdlib>
#include <windows.h>

using namespace std; 
void gotoxy(int x, int y);
void layout();
void erase_eol(int x, int y);

int modelo,linha,quantidade,detalhe=0;
string modelos[4]={"Pequeno","Médio","Grande","Muito Grande"};
float precos[4]={8,10,12,15};
float total=0;
char continuar;

int main(){
    setlocale(LC_ALL,"Portuguese");
    layout();
    linha=5;
    gotoxy(2, 5);
    while(true){
        do{
            gotoxy(2,linha);cin>>modelo;
            if(modelo<1 || modelo>4){
                gotoxy(55,linha);cout<<"Nº de modelo inexistente. Digite 1, 2, 3 ou 4.";
                
            }
        }while(modelo<1 || modelo>4);
        // eliminar a linha caso exista erro no nº do modelo
        erase_eol(55,linha);
        gotoxy(2,linha);cout<<modelo;
        gotoxy(11,linha);cout<<modelos[modelo-1];
        gotoxy(39,linha);cout<<precos[modelo-1];
        do{
            // solicitar a quantidade
            gotoxy(27,linha);cin>>quantidade;
            if(quantidade<=0){
            gotoxy(55,linha);cout<<"A quantidade deve ser superior a 0."; 
            } 
        }while(quantidade<=0);
        // apresentar o total por linha
        erase_eol(55,linha);
        gotoxy(48,linha);cout<<(quantidade*precos[modelo-1]);   
        total+=quantidade*precos[modelo-1];
        // apresentar o total
        gotoxy(48,10);cout<<total;
        linha++;
        detalhe++;
        if(detalhe>=4){
            gotoxy(0,13);cout<<"Validação da encomenda Ok!";
            gotoxy(0,15);cout<<"Para nova encomenda digite sS ou outra tecla seguida de Enter para Terminar:";
            cin>>continuar;
            if(continuar=='s' || continuar=='S'){
                layout();
            }
            else{
                gotoxy(0,17);cout<<"Fim do programa.";
                exit(0);
            }
            
        }

        }
    return 0;
}

void gotoxy(int x, int y){
    COORD point;
    point.X=x; point.Y=y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),point);
}

void layout(){
    system("cls");
    gotoxy(0,0);cout<<"Encomenda";
    gotoxy(0,1);cout<<"Produto X";
    gotoxy(0,3);cout<<"\nModelo     Descrição    Quantidade    Preço    Total";
    gotoxy(0,4);cout<<"\n-----------------------------------------------------";
    gotoxy(0,9);cout<<"\n-----------------------------------------------------";
    gotoxy(40,10);cout<<"\nTotal";
    total=0;linha=5;detalhe=0;

}
void erase_eol(int x, int y){
    for(int i=x;i<120;i++){
        gotoxy(i,y);cout<<" ";
    }
}
