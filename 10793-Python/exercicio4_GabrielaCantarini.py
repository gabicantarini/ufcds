# Dicionário 
meses = {
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
    print("%s, %s, %s" % ("O trimestre digitado é: " + meses.get(1), meses.get(2), meses.get(3)))
elif trimestre == 2:
    print("%s, %s, %s" % ("O trimestre digitado é: " + meses.get(4), meses.get(5), meses.get(6)))
elif trimestre == 3:
    print("%s, %s, %s" % ("O trimestre digitado é: " + meses.get(7), meses.get(8), meses.get(9)))
elif trimestre == 4:
    print("%s, %s, %s" % ("O trimestre digitado é: " + meses.get(10), meses.get(11), meses.get(12)))
else:
    print("Número do trimestre inválido. Por favor, digite um número entre 1 e 4.")
