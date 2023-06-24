#include <stdio.h>

class Bicicleta {
private:
    int cor;
    int numeroDeRodas;
    int tamanhoDeRodas;
    
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
    void DefinirTamanhoDeRodas(int t)
    {
    tamanhoDeRodas=t;
    }
    int ObterTamanhoDeRodas()
    {
    return tamanhoDeRodas;
    }
};

int main()
{
    Bicicleta bike1;
    
    bike1.DefinirCor(4);
    bike1.DefinirNumeroDeRodas(5);
    bike1.DefinirTamanhoDeRodas(10);
    printf("Cor: %d\n",bike1.ObterCor());
    printf("numero de rodas: %d\n", bike1.ObterNumeroDeRodas());
    printf("numero de rodas: %d\n", bike1.ObterTamanhoDeRodas());

    return 0;
};