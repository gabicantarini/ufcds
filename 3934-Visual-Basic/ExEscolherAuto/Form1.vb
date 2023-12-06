Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Dim Marca, Cor, Tipo, Total As Double

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Marca = "11000"
        ElseIf RadioButton2.Checked Then
            Marca = "15000"
        ElseIf RadioButton3.Checked Then
            Marca = "19000"
        ElseIf RadioButton4.Checked Then
            Marca = "13000"
        Else
            Marca = "15000"

        End If

        If RadioButton6.Checked Then
            Cor = "5000"
        ElseIf RadioButton7.Checked Then
            Cor = "4000"
        ElseIf RadioButton8.Checked Then
            Cor = "3000"
        ElseIf RadioButton9.Checked Then
            Cor = "2000"
        Else
            Cor = "1000"

        End If

        If RadioButton11.Checked Then
            Tipo = "12000"
        Else
            Tipo = "8000"

        End If


        Total = Marca + Cor + Tipo

        RichTextBox1.Text = "Valor da Marca: " & Marca & " euros" &
        Environment.NewLine & "Valor da Cor: " & Cor & " euros" &
        Environment.NewLine & "Valor do Tipo de Combustível: " & Tipo & " euros"

        TextBox2.Text = Total & " euros"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim penFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
