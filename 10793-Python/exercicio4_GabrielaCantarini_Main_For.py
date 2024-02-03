
def trim_meses(trimestre):
    # Dicionário 
    MESES = {
        1: 'Janeiro',
        2: 'Fevereiro',
        3: 'Março',
        4: 'Abril',
        5: 'Maio',
        6: 'Junho',
        7: 'Julho',
        8: 'Agosto',
        9: 'Setembro',
        10: 'Outubro',
        11: 'Novembro',
        12: 'Dezembro'
    }

# Verificar se o trimestre é válido
    if 1 <= trimestre <= 4:
        meses_trimestre = [MESES.get(i) for i in range((trimestre - 1) * 3 + 1, trimestre * 3 + 1)]
        print("O trimestre digitado é:", ", ".join(meses_trimestre))
    else:
        print("Número do trimestre inválido. Por favor, digite um número entre 1 e 4.")

def main():
    # Solicita ao usuário o trimestre
    trimestre = int(input("Digite o número do trimestre [1 a 4]: "))
    #retorna a função dos meses por trimestre
    trim_meses(trimestre)
    #encerra o programa
    print("Fim do programa.")
  
if __name__ == "__main__":
    #retorna a  função main
    main()        
