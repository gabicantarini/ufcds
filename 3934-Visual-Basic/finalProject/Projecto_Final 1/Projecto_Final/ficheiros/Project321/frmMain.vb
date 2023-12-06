Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class frmMain
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim datatable As New DataTable
    Dim cmd As New OleDbCommand
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=..\db_project321.mdb"
        showData() 'BD no datagridview
        CustomColumnWidth() 'ajustar colunas
    End Sub
    Private Sub CustomColumnWidth()
        Dim ColumnID As DataGridViewColumn = dgvInfo.Columns(0)

        ColumnID.Width = 40
        Dim ColumnSurname As DataGridViewColumn = dgvInfo.Columns(1)
        ColumnSurname.Width = 100

    End Sub

    Private Sub showData()
        Dim dbCommand As String
        dbCommand = "Select * from Info"
        adt = New OleDbDataAdapter(dbCommand, dbconn)
        datatable = New DataTable

        adt.Fill(datatable)
        dgvInfo.DataSource = datatable
    End Sub

    Private Sub dgvInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfo.CellContentClick
        Dim i As Integer
        i = dgvInfo.CurrentRow.Index
        txtID.Text = dgvInfo.Item(0, i).Value.ToString
        txtSurname.Text = dgvInfo.Item(1, i).Value.ToString
        txtEmail.Text = dgvInfo.Item(2, i).Value.ToString
        txtAddress.Text = dgvInfo.Item(3, i).Value.ToString
        txtContact_no.Text = dgvInfo.Item(4, i).Value.ToString
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Guardar infomração?", "Guardar Registo", MessageBoxButtons.YesNo)

        If dr = DialogResult.No Then
            'Sem informação
        Else
            If Len(Trim(txtSurname.Text)) = 0 Then
                MessageBox.Show("Digite o Nome", "Guardar Registo-Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                txtSurname.Focus()
            ElseIf Len(Trim(txtEmail.Text)) = 0 Then
                MessageBox.Show("Digite o Email", "Guardar Registo-Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                txtEmail.Focus()
            ElseIf Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Digite o Endereço", "Guardar Registo-Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                txtAddress.Focus()
            ElseIf Len(Trim(txtContact_no.Text)) = 0 Then
                MessageBox.Show("Digite o Contacto", "Guardar Registo-Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                txtContact_no.Focus()
            Else

                adt = New OleDbDataAdapter("insert into info (Nome, email, Morada, Contacto) values ('" & txtSurname.Text & "', '" & txtEmail.Text & "', '" & txtAddress.Text & "', '" & txtContact_no.Text & "')", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData()
                MsgBox("Inserido com Sucess")
                'clearText()
            End If
        End If

    End Sub
    Sub clearText()
        txtID.Text = ""
        txtSurname.Text = ""
        txtEmail.Text = ""
        txtID.Text = ""
        txtID.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try

            Dim Sql = "Select * from info where id like " & txtID.Text & ""
            adt = New OleDbDataAdapter(Sql, dbconn)
            cmd = New OleDbCommand(Sql)
            adt.Fill(ds, "info")

            txtSurname.Text = ds.Tables("info").Rows(0)(1).ToString
            txtEmail.Text = ds.Tables("info").Rows(0)(2).ToString
            txtAddress.Text = ds.Tables("info").Rows(0)(3).ToString
            txtContact_no.Text = ds.Tables("info").Rows(0)(4).ToString
            ds = New DataSet
        Catch ex As Exception
            MsgBox("Não existem Dados da pesquisa", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class
