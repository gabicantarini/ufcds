Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            RichTextBox1.Text = "Descrição sobre Minho - Tradicional, Gastronomia, Cultura"
            PictureBox1.Image = Image.FromFile("img1.jpg")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RichTextBox1.Text = "Descrição sobre Beira Litoral - Tradicional, Gastronomia, Cultura"
            PictureBox1.Image = Image.FromFile("img2.jpg")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RichTextBox1.Text = "Descrição sobre Douro - Tradicional, Gastronomia, Cultura"
            PictureBox1.Image = Image.FromFile("img3.jpg")
        End If
    End Sub
End Class
