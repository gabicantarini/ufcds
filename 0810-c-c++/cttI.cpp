#include <iostream>
#include <clocale>
#include <cstdlib>
#include <windows.h>

using namespace std; 
void gotoxy(int x, int y);
void layout();
void erase_eol(int x, int y);

int modelo,linha,nenc=0,detalhe=0;
string modelos[4]={"Pequeno","Médio","Grande","Muito Grande"};
float precos[4]={8,10,12,15};
int modelo_qtd[4][2];
float total=0;
char continuar;
bool existe=false;

int main(){
    setlocale(LC_ALL,"Portuguese");
    layout();
    linha=5;
    while(true){
        do{
            existe=false;
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
        // ver se o modelo já existe na encomenda
        for(int i=0;i<4;i++){
            if(modelo_qtd[i][0]==modelo){
                gotoxy(55,linha);cout<<"Modelo já existe na encomenda.";
                Sleep(3000);
                // apagar a linha da consola
                erase_eol(0,linha);
                existe=true;
                break;
            }
        }
        if(existe==false){
            // procurar a 1ª posição livre da matriz modelos_qtd
            for(int i=0;i<4;i++){
                if(modelo_qtd[i][0]==0){
                    modelo_qtd[i][0]=modelo;
                    do{
                        gotoxy(27,linha);cin>>modelo_qtd[i][1];
                        if(modelo_qtd[i][1]<=0){
                           gotoxy(55,linha);cout<<"A quantidade deve ser superior a 0.";  
                        } 
                    }while(modelo_qtd[i][1]<=0);
                    erase_eol(55,linha);
                    gotoxy(48,linha);cout<<(modelo_qtd[i][1]*precos[modelo-1]);   
                    total+=modelo_qtd[i][1]*precos[modelo_qtd[i][0]-1];
                    // apresentar o total
                    gotoxy(48,10);cout<<total;
                    linha++;
                    detalhe++;
                    break;
                }
            }
        }
        
        // apresentar o total por linha
          
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
    gotoxy(0,0);cout<<"Encomenda Nº";
    nenc++;gotoxy(13,0);cout<<nenc;
    gotoxy(0,1);cout<<"Produto X";
    gotoxy(0,3);cout<<"Modelo     Descrição    Quantidade    Preço    Total";
    gotoxy(0,4);cout<<"----------------------------------------------------";
    gotoxy(0,9);cout<<"----------------------------------------------------";
    gotoxy(40,10);cout<<"Total";
    total=0;linha=5;detalhe=0;
    existe=false;
    // limpar a matriz dos modelos_qtd
    for(int i=0;i<5;i++){
        for(int j=0;j<2;j++){
            modelo_qtd[i][j]=0;
        }   
    }

}
void erase_eol(int x, int y){
    for(int i=x;i<120;i++){
        gotoxy(i,y);cout<<" ";
    }
}
