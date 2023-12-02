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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKmIni = New System.Windows.Forms.TextBox()
        Me.txtKmFim = New System.Windows.Forms.TextBox()
        Me.lblKms = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblValDia = New System.Windows.Forms.Label()
        Me.lblValKm = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnLimp = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MP Rent A Car"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data de Início:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de Fim:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kms Início:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kms Fim:"
        '
        'lblDias
        '
        Me.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDias.Location = New System.Drawing.Point(114, 367)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(79, 29)
        Me.lblDias.TabIndex = 5
        Me.lblDias.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(244, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "dias @ 35 € / dia:"
        '
        'txtKmIni
        '
        Me.txtKmIni.Location = New System.Drawing.Point(467, 250)
        Me.txtKmIni.Name = "txtKmIni"
        Me.txtKmIni.Size = New System.Drawing.Size(205, 22)
        Me.txtKmIni.TabIndex = 7
        '
        'txtKmFim
        '
        Me.txtKmFim.Location = New System.Drawing.Point(467, 305)
        Me.txtKmFim.Name = "txtKmFim"
        Me.txtKmFim.Size = New System.Drawing.Size(205, 22)
        Me.txtKmFim.TabIndex = 8
        '
        'lblKms
        '
        Me.lblKms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKms.Location = New System.Drawing.Point(114, 438)
        Me.lblKms.Name = "lblKms"
        Me.lblKms.Size = New System.Drawing.Size(79, 26)
        Me.lblKms.TabIndex = 9
        Me.lblKms.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(244, 444)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Kms @ 0,10 € /Km:"
        '
        'lblValDia
        '
        Me.lblValDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValDia.Location = New System.Drawing.Point(467, 360)
        Me.lblValDia.Name = "lblValDia"
        Me.lblValDia.Size = New System.Drawing.Size(205, 36)
        Me.lblValDia.TabIndex = 11
        Me.lblValDia.Text = "-"
        '
        'lblValKm
        '
        Me.lblValKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValKm.Location = New System.Drawing.Point(467, 433)
        Me.lblValKm.Name = "lblValKm"
        Me.lblValKm.Size = New System.Drawing.Size(205, 31)
        Me.lblValKm.TabIndex = 12
        Me.lblValKm.Text = "-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(467, 131)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 13
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(467, 192)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 508)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "TOTAL A PAGAR:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(467, 494)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(205, 34)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "-"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.Location = New System.Drawing.Point(119, 590)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(113, 36)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "Calcular"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnLimp
        '
        Me.btnLimp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimp.ForeColor = System.Drawing.Color.White
        Me.btnLimp.Location = New System.Drawing.Point(286, 590)
        Me.btnLimp.Name = "btnLimp"
        Me.btnLimp.Size = New System.Drawing.Size(113, 36)
        Me.btnLimp.TabIndex = 18
        Me.btnLimp.Text = "Limpar"
        Me.btnLimp.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(454, 590)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(113, 36)
        Me.btnSair.TabIndex = 19
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 663)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimp)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblValKm)
        Me.Controls.Add(Me.lblValDia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblKms)
        Me.Controls.Add(Me.txtKmFim)
        Me.Controls.Add(Me.txtKmIni)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDias As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKmIni As TextBox
    Friend WithEvents txtKmFim As TextBox
    Friend WithEvents lblKms As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblValDia As Label
    Friend WithEvents lblValKm As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnLimp As Button
    Friend WithEvents btnSair As Button
End Class
