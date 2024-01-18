#Cria a classe pai Pessoa 
class Pessoa:
    def __init__(self, nome, idade, nif):
        self.nome = nome
        self.idade = idade  
        self.nif = nif

    def exibir_informacoes(self):
        print(f"Nome: {self.nome}, Idade: {self.idade}, NIF: {self.nif}")

    def definir_limite(self, limite):
        print(f"{self.nome} terá o limite de €{limite}. \n")

    def definir_idade(self):
        if self.idade >= 18:
            print(f"{self.nome} tem {self.idade} anos e pode ter uma conta no banco.")
        else:
            print(f"{self.nome} tem {self.idade} anos e não pode ter uma conta no banco.")

#Cria a classe filha AberturaConta, que herda as informações da classe pai
class AberturaConta(Pessoa):
    def __init__(self, nome, idade, cpf, endereco, conta):
        super().__init__(nome, idade, cpf)
        self.endereco = endereco
        self.conta = conta

    def exibir_informacoes_conta(self):
        print(f"\nNome: {self.nome}, Idade: {self.idade}, NIF: {self.nif}, Endereço: {self.endereco}, Conta Nº: {self.conta}")

    def realizar_deposito(self, valor):
        print(f"{self.nome} realizou um deposito de €{valor} na nova conta.")

    def solicitar_cartao_credito(self):
        print(f"{self.nome} solicitou um cartão de crédito.\n")

# Exemplo de cadastro
pessoa1 = AberturaConta("Gabriela Canta", 21, "222 222 222", "Rua ABC, 123", 1235-9)
pessoa1.exibir_informacoes()
pessoa1.definir_limite(300)
pessoa1.definir_idade()
pessoa1.realizar_deposito(1000)
pessoa1.solicitar_cartao_credito()

# Instância da classe Pai (Pessoa)
pessoa2 = Pessoa("Cecília Canta", 20, "333 333 333")
pessoa2.exibir_informacoes()
pessoa2.definir_limite(500)

# Instância da classe Filha (AberturaConta)
pessoa2.Pessoa = AberturaConta("Cecília Canta", 20, "333 333 333", "Rua XYZ, 456", 1234)
pessoa2.Pessoa.exibir_informacoes_conta()

# Instância da classe Filha (AberturaConta)
pessoa3 = AberturaConta("Leandro Canta", 23, "444 444 444", "Rua XYZ, 456", 1456)
pessoa3.exibir_informacoes_conta()
pessoa3.realizar_deposito(1500)
pessoa3.solicitar_cartao_credito()

# Alterando valores dos atributos
pessoa1.nome = "Gabriela I Canta"
pessoa2.Pessoa.endereco = "Avenida Principal, 789"

# Exibindo informações atualizadas
print("\nInformações após alterações:")
pessoa1.exibir_informacoes()
pessoa2.Pessoa.exibir_informacoes_conta()