Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim d1 As Date = DateTimePicker1.Value
        Dim d2 As Date = DateTimePicker2.Value

        Dim calcDias As TimeSpan = d2.Subtract(d1)
        Dim dias As Integer = calcDias.TotalDays
        Dim ValDias As Double = dias * 35.0

        lblDias.Text = dias
        lblValDia.Text = ValDias.ToString("C")

        Dim kmIni As Double = Val(txtKmIni.Text)
        Dim kmFim As Double = Val(txtKmFim.Text)
        Dim kmTts As Double = kmFim - kmIni

        lblKms.Text = kmTts

        Dim valKms As Double = kmTts * 0.1

        lblValKm.Text = ValKms.ToString("C")

        Dim total As Double = ValDias + valKms

        lblTotal.Text = total.ToString("C")


    End Sub

    Private Sub btnLimp_Click(sender As Object, e As EventArgs) Handles btnLimp.Click

        lblDias.Text = ""
        lblKms.Text = ""
        lblValDia.Text = ""
        lblValKm.Text = ""
        lblTotal.Text = ""
        txtKmIni.Clear()
        txtKmFim.Clear()

        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today


    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Application.Exit()

    End Sub
End Class
