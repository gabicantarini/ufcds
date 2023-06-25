#include <stdio.h>

class Bicicleta {
private:
    int cor;
    int numeroDeRodas;
    
public:
    void DefinirCor(int c)
    {
    cor=c;
    }
    int ObterCor()
    {
    return cor;
    }
    void DefinirNumeroDeRodas(int n)
    {
    numeroDeRodas=n;
    }
    int ObterNumeroDeRodas()
    {
    return numeroDeRodas;
    }
};

int main()
{
    Bicicleta bike1;
    bike1.DefinirCor(2);
    bike1.DefinirNumeroDeRodas(1);
    
    
    //printf("Qual a Cor: %d\n",bike1.DefinirCor());
    //scanf("%d", &bike1.DefinirCor());
    //printf("Qual a Cor: %d\n",DefinirNumeroDeRodas());
    printf("Cor: %d\n",bike1.ObterCor());
    printf("numero de rodas: %d\n", bike1.ObterNumeroDeRodas());

    return 0;
};