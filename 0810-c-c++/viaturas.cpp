#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>

class RegistoAutomovel {
public:
    // Construtor
    RegistoAutomovel() {}

    // Destrutor
    ~RegistoAutomovel() {
        for (auto& viatura : viaturas) {
            delete viatura;
        }
    }

    // Método para registar uma nova viatura
    void registarViatura() {
        std::string marca, modelo, matricula;
        double preco;

        // Solicitar informações ao utilizador
        std::cout << "Marca: ";
        std::cin >> marca;
        std::cout << "Modelo: ";
        std::cin >> modelo;
        std::cout << "Matrícula: ";
        std::cin >> matricula;

        // Verificar se a matrícula já existe
        if (existeMatricula(matricula)) {
            std::cout << "Matrícula já existe. Viatura não registada.\n";
            return;
        }

        std::cout << "Preço: ";
        std::cin >> preco;

        // Criar uma nova viatura e adicioná-la ao vetor
        Viatura* novaViatura = new Viatura(marca, modelo, matricula, preco);
        viaturas.push_back(novaViatura);

        std::cout << "Viatura registada com sucesso.\n";
    }

    // Método para listar todas as viaturas
    void listarViaturas() const {
        if (viaturas.empty()) {
            std::cout << "Nenhuma viatura registada.\n";
        } else {
            for (size_t i = 0; i < viaturas.size(); ++i) {
                viaturas[i]->mostrarInformacoes(i + 1);
            }
        }
    }

    // Método para pesquisar uma viatura por matrícula
    void pesquisarPorMatricula() const {
        std::string matricula;
        std::cout << "Digite a matrícula: ";
        std::cin >> matricula;

        auto it = std::find_if(viaturas.begin(), viaturas.end(),
                               [&matricula](const Viatura* v) {
                                   return v->getMatricula() == matricula;
                               });

        if (it != viaturas.end()) {
            (*it)->mostrarInformacoes();
        } else {
            std::cout << "Viatura não encontrada.\n";
        }
    }

    // Método para listar viaturas por marca
    void listarPorMarca() const {
        std::string marca;
        std::cout << "Digite a marca: ";
        std::cin >> marca;

        std::vector<Viatura*> viaturasMarca;

        std::copy_if(viaturas.begin(), viaturas.end(),
                     std::back_inserter(viaturasMarca),
                     [&marca](const Viatura* v) {
                         return v->getMarca() == marca;
                     });

        if (viaturasMarca.empty()) {
            std::cout << "Nenhuma viatura encontrada para a marca especificada.\n";
        } else {
            for (size_t i = 0; i < viaturasMarca.size(); ++i) {
                viaturasMarca[i]->mostrarInformacoes(i + 1);
            }
        }
    }

    // Método para eliminar uma viatura pelo número de registo
    void eliminarRegisto() {
        if (viaturas.empty()) {
            std::cout << "Nenhuma viatura registada para eliminar.\n";
            return;
        }

        listarViaturas();

        int numeroRegisto;
        std::cout << "Digite o número de registo da viatura a eliminar: ";
        std::cin >> numeroRegisto;

        if (numeroRegisto > 0 && static_cast<size_t>(numeroRegisto) <= viaturas.size()) {
            delete viaturas[numeroRegisto - 1];
            viaturas.erase(viaturas.begin() + numeroRegisto - 1);
            std::cout << "Viatura eliminada com sucesso.\n";
        } else {
            std::cout << "Número de registo inválido.\n";
        }
    }

private:
    // Estrutura da viatura
    struct Viatura {
        std::string marca;
        std::string modelo;
        std::string matricula;
        double preco;

        // Construtor da viatura
        Viatura(const std::string& marca, const std::string& modelo,
                const std::string& matricula, double preco)
            : marca(marca), modelo(modelo), matricula(matricula), preco(preco) {}

        // Método para mostrar as informações da viatura
        void mostrarInformacoes(size_t numeroRegisto = 0) const {
            std::cout << "\nRegisto " << numeroRegisto << ":\n";
            std::cout << "Marca: " << marca << "\n";
            std::cout << "Modelo: " << modelo << "\n";
            std::cout << "Matrícula: " << matricula << "\n";
            std::cout << "Preço: " << std::fixed << std::setprecision(2) << preco << " euros\n";
        }

        // Método para obter a matrícula da viatura
        const std::string& getMatricula() const {
            return matricula;
        }

        // Método para obter a marca da viatura
        const std::string& getMarca() const {
            return marca;
        }
    };

    // Vetor dinâmico para armazenar as viaturas
    std::vector<Viatura*> viaturas;

    // Método privado para verificar se a matrícula já existe
    bool existeMatricula(const std::string& matricula) const {
        return std::any_of(viaturas.begin(), viaturas.end(),
                           [&matricula](const Viatura* v) {
                               return v->getMatricula() == matricula;
                           });
    }
};

int main() {
    RegistoAutomovel stand;

    int opcao;
    do {
        std::cout << "\nStand A Guiar, Lda.\n";
        std::cout << "1-Registar viatura\n";
        std::cout << "2-Listagem de viaturas\n";
        std::cout << "3-Pesquisa por matrícula\n";
        std::cout << "4-Listagem de viaturas por marca\n";
        std::cout << "5-Eliminar um registo (o utilizador indica o número de registo)\n";
        std::cout << "6-Sair\n";
        std::cout << "Digite a sua opção: ";
        std::cin >> opcao;

        switch (opcao) {
        case 1:
            stand.registarViatura();
            break;
        case 2:
            stand.listarViaturas();
            break;
        case 3:
            stand.pesquisarPorMatricula();
            break;
        case 4:
            stand.listarPorMarca();
            break;
        case 5:
            stand.eliminarRegisto();
            break;
        case 6:
            std::cout << "Programa encerrado.\n";
            break;
        default:
            std::cout << "Opção inválida. Tente novamente.\n";
        }

    } while (opcao != 6);

    return 0;
}
