Imports System.Security.Cryptography

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Dia As Date

        Dia = DateTimePicker1.Value

        MessageBox.Show("A Data escolhida é: " & Dia)

        Label2.Text = ("A Data escolhida é: " & Dia)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Linguagens As String

        Linguagens = ComboBox1.Text

        MessageBox.Show("A Linguagem que escolheu foi: " & Linguagens)
        Label3.Text = ("A Linguagem que escolheu foi:: " & Linguagens)


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LabelNotas_Click(sender As Object, e As EventArgs) Handles LabelNotas.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim Notas As String

        Notas = ListBox1.Text
        LabelNotas.Text = ("A Nota avaliada foi: " & vbNewLine & Notas)
    End Sub
End Class
