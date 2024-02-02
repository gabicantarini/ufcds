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

# Solicita ao usuário o trimestre
trimestre = int(input("Digite o número do trimestre [1 a 4]: "))

# Retorna o conjunto de meses ao trimestre conforme solicitado pelo usuário
if trimestre == 1:
    print("%s, %s, %s" % ("O trimestre digitado é: " + MESES.get(1), MESES.get(2), MESES.get(3)))
elif trimestre == 2:
    print("%s, %s, %s" % ("O trimestre digitado é: " + MESES.get(4), MESES.get(5), MESES.get(6)))
elif trimestre == 3:
    print("%s, %s, %s" % ("O trimestre digitado é: " + MESES.get(7), MESES.get(8), MESES.get(9)))
elif trimestre == 4:
    print("%s, %s, %s" % ("O trimestre digitado é: " + MESES.get(10), MESES.get(11), MESES.get(12)))
else:
    print("Número do trimestre inválido. Por favor, digite um número entre 1 e 4.")
