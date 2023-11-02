Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Vendas As Integer

        Vendas = Integer.Parse(TextBox1.Text)

        If Vendas < 200 Then
            Label4.Text = "Tem de esforçar muito..."
            Label4.ForeColor = System.Drawing.Color.Red

        ElseIf Vendas < 400 Then
            Label4.Text = "Não vendeu mal..."
            Label4.ForeColor = System.Drawing.Color.Green
        ElseIf Vendas < 600 Then
            Label4.Text = "Bom"
            Label4.ForeColor = System.Drawing.Color.Blue
        ElseIf Vendas < 800 Then
            Label4.Text = "Muito Bom"
            Label4.ForeColor = System.Drawing.Color.Violet
        Else
            Label4.Text = "Excelente"
            Label4.ForeColor = System.Drawing.Color.HotPink
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
