Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            RichTextBox1.Text = "Este é um cruzeiro básico."
            PictureBox1.Image = Image.FromFile("C:\Users\Gabriela\Desktop\Cantarini\Gabriela\2022TI\Formação programação IEFP\UFCDs\3934-Visual Basic\img\cruzeiro1.jpg")

        ElseIf ComboBox1.SelectedIndex = 1 Then
            RichTextBox1.Text = "Este é um cruzeiro intermediário."
            PictureBox1.Image = Image.FromFile("C:\Users\Gabriela\Desktop\Cantarini\Gabriela\2022TI\Formação programação IEFP\UFCDs\3934-Visual Basic\img\cruzeiro2.jpg")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RichTextBox1.Text = "Este é um cruzeiro completo."
            PictureBox1.Image = Image.FromFile("C:\Users\Gabriela\Desktop\Cantarini\Gabriela\2022TI\Formação programação IEFP\UFCDs\3934-Visual Basic\img\cruzeiro3.jpg")
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RichTextBox1.Text = "Este é um cruzeiro de Luxo."
            PictureBox1.Image = Image.FromFile("C:\Users\Gabriela\Desktop\Cantarini\Gabriela\2022TI\Formação programação IEFP\UFCDs\3934-Visual Basic\img\cruzeiro4.jpg")
        End If
    End Sub
End Class
