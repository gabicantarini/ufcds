Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonQuadrado_Click(sender As Object, e As EventArgs) Handles ButtonQuadrado.Click
        Dim C As Double ' define a variável do comprimento
        Dim A1 As Double ' define a variável daárea
        C = TextBox1.Text ' Obter o comprimento.
        A1 = C ^ 2 ' Calculara area
        TextBox6.Text = A1 ' mostra aárea na segundatext box
        ' ListBox1.Items.Add("A área do Quadrado é:" & A1) ' adiciona à listbox
    End Sub

    Private Sub ButtonRetangulo_Click(sender As Object, e As EventArgs) Handles ButtonRetangulo.Click
        Dim L As Double ' ' define a variável do Largura
        Dim A As Double ' ' define a variável do Altura
        Dim A2 As Double ' define aarea
        L = TextBox3.Text ' obtém a Largura
        A = TextBox4.Text ' obtém aAltura
        A2 = L * A ' Calcula a área
        TextBox7.Text = A2 ' mostra aáreado retângulo
        ' ListBox1.Items.Add(S2) ' adiciona a mensagemna list box
    End Sub

    Private Sub ButtonTriangulo_Click(sender As Object, e As EventArgs) Handles ButtonTriangulo.Click
        Dim base As Double ' define abase
        Dim altura As Double ' define a Altura
        Dim Area As Double ' define aarea
        base = TextBox5.Text ' obtém base
        altura = TextBox4.Text ' obtém a Altura
        Area = 0.5 * base * altura ' Calcula a area(1/2 x base x altura)
        TextBox8.Text = Area ' mostra o resultado.
        ' ListBox1.Items.Add(Str) ' adiciona a mensagemna list box
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        TextBox1.Text = "" ' Limpar todas as text boxes
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ' ListBox1.Items.Clear() ' Limpar  a list box
    End Sub
End Class
