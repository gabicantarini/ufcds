Imports System.Data.Entity.Migrations
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'EmpresaDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
        Me.TableTableAdapter.Fill(Me.EmpresaDataSet.Table)

    End Sub


    Public Sub executarQuery(query As String)
        Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLlocalDB;AttachDbFilename=|DataDirectory|\Empresa.mdf;Integrated Security=True;Connect Timeout=30")
        Dim Command As New SqlCommand(query, con)
        con.Open()
        Command.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        Dim inserirQuery As String = "Insert into Utilizadores(Id, Nome, Apelido,Idade)VALUES('" & txtId.Text & "','" & txtName.Text & "','" & txtApelido.Text & "', '" & txtIdade.Text & "')"

        'criar uma rotina para a inserção de Dados ser executada
        executarQuery(inserirQuery)

        MessageBox.Show("Dados inseridos com sucesso")



    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        'Try
        '    con.Open()
        '    Str = "update Utilizadores set Nome='" & txtName.Text & "',Apelido='" & txtApelido.Text & "',idade='" & txtIdade.Text & "' 
        '    where id=" & id
        '    com = New SqlCommand(Str, con)
        '    sqlda = New SqlDataAdapter(com)
        '    Dim resultado As Integer
        '    resultado = com.ExecuteNonQuery()
        '    con.Close()
        '    If resultado = 1 Then
        '        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Sucesso", "javascript:Display('" & lblNome.Text & "')", True)
        '    End If
        'Catch ex As Exception
        '    lblmsg.Text = ex.Message
        'End Try


    End Sub

End Class
