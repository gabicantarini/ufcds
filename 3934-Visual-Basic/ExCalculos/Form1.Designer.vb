<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnIva = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculo Comissão"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendas"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 20)
        Me.TextBox1.TabIndex = 2
        '
        'lblComm
        '
        Me.lblComm.AutoSize = True
        Me.lblComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComm.Location = New System.Drawing.Point(45, 150)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(24, 20)
        Me.lblComm.TabIndex = 3
        Me.lblComm.Text = "---"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular a Comissão"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Calculo IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nome do Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(467, 99)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(288, 20)
        Me.txtCliente.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Valor do Produto:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(467, 150)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(113, 20)
        Me.txtValor.TabIndex = 9
        '
        'btnIva
        '
        Me.btnIva.Location = New System.Drawing.Point(680, 150)
        Me.btnIva.Name = "btnIva"
        Me.btnIva.Size = New System.Drawing.Size(75, 23)
        Me.btnIva.TabIndex = 10
        Me.btnIva.Text = "Calcular "
        Me.btnIva.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(369, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(386, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Limpar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(375, 265)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(380, 160)
        Me.ListBox1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnIva)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblComm As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnIva As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
