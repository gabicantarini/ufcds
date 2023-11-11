Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vendas As Integer

        Dim comm As Double 'por causa das casas decimais

        vendas = Val(TextBox1.Text)

        If vendas >= 500 And vendas < 1000 Then
            comm = vendas * 0.05
        ElseIf vendas >= 1000 And vendas < 1500 Then
            comm = vendas * 0.1
        ElseIf vendas >= 1500 And vendas < 2000 Then
            comm = vendas * 0.15
        ElseIf vendas >= 2000 Then
            comm = vendas * 0.2
        Else
            comm = 0
        End If

        lblComm.Text = ("A sua comissão é: " & comm & "€" & vbCrLf & "e o valor de vendas foi: " & vendas & "€")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnIva_Click(sender As Object, e As EventArgs) Handles btnIva.Click
        Const Valor_Iva = 0.23

        Dim Valor As Double = CDbl(txtValor.Text)

        Dim Iva As Double = Valor * Valor_Iva

        Dim Custototal As Double = Valor + Iva
        'limpar a listBOX
        ListBox1.Items.Clear()



        'mostra os clientes na listbox
        ListBox1.Items.Add("Nome Cliente: " & txtValor.Text)

        'mostra o valor da compra, ToString mostra em euros
        ListBox1.Items.Add("Valor do Produto: " & Valor.ToString("C"))

        'informa o percentual do valor do IVA na listbox
        ListBox1.Items.Add("Taxa de IVA 23%")

        'mostra o percentual do valor do IVA na listbox
        ListBox1.Items.Add("Valor do IVA :" & Iva.ToString("C"))

        'mostra o total na listbox
        ListBox1.Items.Add("Valor Total a pagar :" & Custototal.ToString("C"))



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        txtCliente.Text = " "
        txtValor.Text = " "
    End Sub
End Class
