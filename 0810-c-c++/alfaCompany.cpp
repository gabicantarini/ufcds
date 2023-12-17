#include <iostream>
#include <vector>
#include <string>
#include <locale>
 
// Classe para representar um vendedor 
class Vendedor {
private:
    int number; 
    std::string name; 
    std::string zone; 
    double sales; 
public:
    // Construtor da classe
    Vendedor(int n, const std::string& nm, const std::string& zn, double vd)
        : number(n), name(nm), zone(zn), sales(vd) {}
 
    // Métodos de acesso aos atributos da classe
    int getNumber() const { return number; }
    std::string getName() const { return name; }
    std::string getZone() const { return zone; }
    double getSales() const { return sales; }
};
 
// Registra um novo vendedor e o adiciona ao vetor
void sellerRegister(std::vector<Vendedor>& v) {
    int n;
    std::string nm, zn;
    double vd;
    std::cout << "Insira o número do vendedor: ";
    std::cin >> n;
    std::cout << "Insira o nome do vendedor: ";
    std::cin >> nm;
    std::cout << "Insira a zona de atuação do vendedor: ";
    std::cin >> zn;
    std::cout << "Insira o valor das vendas do vendedor: ";
    std::cin >> vd;
    v.emplace_back(n, nm, zn, vd); // Cria um objeto da classe Vendedor
    std::cout << "Vendedor registrado com sucesso!\n";
}
 
// Mostra os dados de um vendedor específico
void showSeller(const std::vector<Vendedor>& v) {
    int n;
    bool encontrado = false;
    std::cout << "Insira o número do vendedor que deseja consultar: ";
    std::cin >> n;
    for (const auto& vendedor : v) {
        if (vendedor.getNumber() == n) { // Se o número do vendedor for igual ao digitado
            encontrado = true;
            std::cout << "Nome: " << vendedor.getName() << "\n";
            std::cout << "Zona: " << vendedor.getZone() << "\n";
            std::cout << "Vendas: " << vendedor.getSales() << "\n";
            break;
        }
    }
    if (!encontrado) { // Se o vendedor não foi encontrado
        std::cout << "Vendedor não cadastrado!\n";
    }
}
 
// Lista as vendas de uma determinada zona
void zoneListSales(const std::vector<Vendedor>& v) {
    std::string zn;
    double total = 0;
    std::cout << "Insira a zona que deseja consultar: ";
    std::cin >> zn;
    std::cout << "Vendedores da zona " << zn << ":\n";
    for (const auto& vendedor : v) {
        if (vendedor.getZone() == zn) { // Retorna comparação da zona do vendedor se é for igual a digitada
            std::cout << vendedor.getName() << " - " << vendedor.getSales() << "\n";
            total += vendedor.getSales(); // Soma as vendas ao total
        }
    }
    std::cout << "Total de vendas da zona " << zn << ": " << total << "\n";
}
 
// Lista todas as vendas e apresenta um total final
void totalListSales(const std::vector<Vendedor>& v) {
    double total = 0;
    std::cout << "Vendedores e suas vendas:\n";
    for (const auto& vendedor : v) {
        std::cout << vendedor.getName() << " - " << vendedor.getSales() << "\n";
        total += vendedor.getSales(); // Total das vendas
    }
    std::cout << "Total de vendas de todos os vendedores: " << total << "\n";
}
 
// Programa principal
int main() {
     setlocale(LC_ALL,"Portuguese");
    std::vector<Vendedor> vendedores; // para armazenar os vendedores
    int opcao;
    std::cout << "Empresa Alfa, S.A\n";
    do {
        std::cout << "\n\n1-Registar vendedor\n\n";
        std::cout << "2-Apresentar dados de um vendedor especifico\n\n";
        std::cout << "3-Listar as vendas de uma zona\n\n";
        std::cout << "4-Listar todas as vendas com um total final\n\n";
        std::cout << "5-Sair\n\n";
        std::cout << "Insira a sua opção: ";
        std::cin >> opcao;
        switch (opcao)
        {
        case 1:
            sellerRegister(vendedores);
            break;
        case 2:
            showSeller(vendedores);
            system("cls"); 
            break;
        case 3:
            zoneListSales(vendedores);
            system("cls"); 
            break;
        case 4:
            totalListSales(vendedores);
            system("cls"); 
            break;
        case 5:
            std::cout << "Obrigada e até a próxima!\n";
            break;
        default:
            std::cout << "Opção inválida!\n";
            break;
        }
    } while (opcao != 5);
    return 0;
}