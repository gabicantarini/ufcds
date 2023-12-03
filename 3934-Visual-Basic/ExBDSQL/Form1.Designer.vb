<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Apelido As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApelido = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EmpresaDataSet = New ExBDSQL.EmpresaDataSet()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New ExBDSQL.EmpresaDataSetTableAdapters.TableTableAdapter()
        Apelido = New System.Windows.Forms.Label()
        CType(Me.EmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Apelido
        '
        Apelido.AutoSize = True
        Apelido.Location = New System.Drawing.Point(69, 229)
        Apelido.Name = "Apelido"
        Apelido.Size = New System.Drawing.Size(66, 20)
        Apelido.TabIndex = 5
        Apelido.Text = "Apelido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(160, 99)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(144, 26)
        Me.txtId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sistema de Gestão RH"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(160, 163)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 26)
        Me.txtName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Idade:"
        '
        'txtApelido
        '
        Me.txtApelido.Location = New System.Drawing.Point(160, 229)
        Me.txtApelido.Name = "txtApelido"
        Me.txtApelido.Size = New System.Drawing.Size(270, 26)
        Me.txtApelido.TabIndex = 7
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(160, 289)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(270, 26)
        Me.txtIdade.TabIndex = 8
        '
        'btn_inserir
        '
        Me.btn_inserir.Location = New System.Drawing.Point(74, 359)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(117, 38)
        Me.btn_inserir.TabIndex = 9
        Me.btn_inserir.Text = "Inserir"
        Me.btn_inserir.UseVisualStyleBackColor = True
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Location = New System.Drawing.Point(245, 359)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(149, 38)
        Me.btn_atualizar.TabIndex = 10
        Me.btn_atualizar.Text = "Actualizar"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(442, 359)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 38)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EmpresaDataSet
        '
        Me.EmpresaDataSet.DataSetName = "EmpresaDataSet"
        Me.EmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.EmpresaDataSet
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 599)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.btn_inserir)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtApelido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Apelido)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApelido As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents btn_inserir As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents EmpresaDataSet As EmpresaDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As EmpresaDataSetTableAdapters.TableTableAdapter
End Class
